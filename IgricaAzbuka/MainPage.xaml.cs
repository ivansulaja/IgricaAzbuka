using IgricaAzbuka.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using IgricaAzbuka;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IgricaAzbuka
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page

    {
        internal static int zbirPoena = 0;
        internal static string score = "0";
        
        
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Azbuka));


            string azbuka = string.Format("{0}{1}{2}{3}{4}{5}", '\u0410', '\u0417', '\u0411', '\u0423', '\u041A', '\u0410');
            string boje = string.Format("{0}{1}{2}{3}", '\u0411', '\u041E', '\u0408', '\u0415');
            string oblici = string.Format("{0}{1}{2}{3}{4}{5}", '\u041E', '\u0411', '\u041B', '\u0418', '\u0426', '\u0418');


            NazivAzbukaTextBlock.Text = azbuka;
            NazivBojeTextBlock.Text = boje;
            NazivObliciTextBlock.Text = oblici;
           
            
         }
        public void upisRezultata()
        {

        }




        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
           StackPanel item = (StackPanel)e.ClickedItem;
            string iconName = item.Name;
            
            switch(iconName)
            {
                case "Boje":
                    MyFrame.Navigate(typeof(Boje));
                    break;
                case "Oblici":
                    MyFrame.Navigate(typeof(Oblici));
                    break;
                case "Azbuka":
                    MyFrame.Navigate(typeof(Azbuka));
                    break;
            }
            
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void PinkButton_Click(object sender, RoutedEventArgs e)
        {
            ScoreTextBlock.Text = "Rezulat: " + score;
        }

        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
