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
using System.Drawing;
	

	

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IgricaAzbuka
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Oblici : Page
    {
        public Oblici()
        {
            this.InitializeComponent();

            
            string oblici = string.Format("{0}{1}{2}{3}{4}{5}", '\u041E', '\u0411', '\u041B', '\u0418', '\u0426', '\u0418');

           
            TitleOblici.Text = oblici;
        }

        
        
       
    }
}
