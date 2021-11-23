using Xamarin_MetroEvents.Models;
using Xamarin_MetroEvents.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_MetroEvents.ViewModels
{
   class SecondPageVM : BaseViewModel
    {
        Item item;
        string name;
        public SecondPageVM() {

            toThird = new Command(async() =>
            {
                Console.WriteLine(item.Name);
                await Application.Current.MainPage.Navigation.PushModalAsync(new ThirdPage());
            });
            exitMe = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PopAsync();
            });
        }
        public Item Item {
            get => item;
            set => SetProperty(ref item, value);
        }

        public string Name {
            get => name;
            set{
                SetProperty(ref name, value);
                item.Name = value;
            }
        }
        Command toThird, exitMe;
        public Command ToThird
        {
            get { return toThird; }
            set { }
        }
        public Command ExitMe
        {
            get { return exitMe; }
            set { }
        }

    }
}
