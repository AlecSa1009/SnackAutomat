using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SnackAutomat.ViewModels
{
    public enum Snacks 
    { 
        Mars = 0,
        Snickers = 1,
        Bounty = 2,
        KinderR = 3,
    }

   public class MainpageViewModel 
    {
        //Logik hinter den Buttons z.b.
        /*public MainpageViewModel()
        {
        DependencyService.get<>
        }*/

        public ICommand BuyMarsCommand => new Command(async () => await BuyAsync(Snacks.Mars)); //async & await c#// damit die App ned blockiert ist, sondern das es im hintergund auch was anderes laufen kann
        public ICommand BuySnickersCommand => new Command(async () => await BuyAsync(Snacks.Snickers));
        public ICommand BuyBountyCommand => new Command(async () => await BuyAsync(Snacks.Bounty));
        public ICommand BuyKinderRCommand => new Command(async () => await BuyAsync(Snacks.KinderR));

        private async Task BuyAsync(Snacks snack) 
        { 
            
        }

    }
}
