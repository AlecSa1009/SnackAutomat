
using Plugin.BluetoothLE;
using SnackAutomat.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SnackAutomat
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            DependencyService.Get<IAdapter>();
        }

        public async void MenueClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Benutzerverwaltung", "", "ok");
        }
        public async void InfoClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Zusammenfassung aller Sachen die wir übernommen haben", "1.Bluetooth Bibliothek, 2....","Schließen");
            
        }

        public async void BMenue(object sender, EventArgs e) => await Navigation.PushAsync(new MainBPage());

    }
}
