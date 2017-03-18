using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using IgricaAzbuka;
using IgricaAzbuka.Model;
using Microsoft.CSharp.RuntimeBinder;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IgricaAzbuka
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Azbuka : Page
      {

        string recZaPoredjenje = "";
        List<Rec> Reci = Rec.getReci();
        List<Slovo> Slova = Slovo.getAzbuka();
        
       

        public Azbuka()
        {
            this.InitializeComponent();
            string obrisi = string.Format("{0}{1}{2}{3}{4}{5}", '\u041E', '\u0411', '\u0420', '\u0418', '\u0428', '\u0418');
            string azbuka = string.Format("{0}{1}{2}{3}{4}{5}", '\u0410', '\u0417', '\u0411', '\u0423', '\u041A', '\u0410');

            ObrisiButton.Content = obrisi;
            TitleAzbuka.Text = azbuka;
        }
        private void AzbukaGridView_ItemClick(object sender, ItemClickEventArgs e)
        {

            Slovo izabranoSlovo = (Slovo)e.ClickedItem;
            recZaPoredjenje += izabranoSlovo.regularnoSlovo.ToString();
            MyMediaElement.Source = new Uri(this.BaseUri, izabranoSlovo.Zvuk);
            ResultTextBlock.Text += izabranoSlovo.Char.ToString();
            MyMediaElement.MediaEnded += (s, d) => poredjenje(recZaPoredjenje);
        }
        private void ObrisiButton_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "";
            recZaPoredjenje = "";
        }

        private void poredjenje(string rec)
        {
            foreach (Rec item in Reci)
            {
                if (recZaPoredjenje == item.Name)
                {
                    MyMediaElement.Source = new Uri(this.BaseUri, item.Zvuk);

                    int zbir = MainPage.zbirPoena + recZaPoredjenje.Length;
                    MainPage.zbirPoena = zbir;
                    MainPage.score = zbir.ToString();


                    

                    ResultTextBlock.Text = "";
                    recZaPoredjenje = "";

                }
            }

        }
    }
}
