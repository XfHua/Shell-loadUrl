using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App217.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrowserPage : ContentPage
    {
        public BrowserPage()
        {
            InitializeComponent();

            Launcher.OpenAsync("https://www.xamarin.com");
        }
    }
}