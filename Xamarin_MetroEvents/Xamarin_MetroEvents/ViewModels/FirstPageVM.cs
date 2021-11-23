using Xamarin_MetroEvents.Models;
using Xamarin_MetroEvents.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_MetroEvents.ViewModels
{
    class FirstPageVM : BaseViewModel
    {
        string label, name, description;
        Command toSecond;

        public FirstPageVM() {
            toSecond = new Command(async () =>
            {
                Item item = new Item(name, description);
                await Application.Current.MainPage.Navigation.PushAsync(new SecondPage(item));
            });
            label = "The First";

        }

        public Command ToSecond {
            get { return toSecond; }
            set {
            }
        }

        public string Label {
            get { return label; }
            set {

            }
        }

        public string Name {
            get => name;
            set { SetProperty(ref name, value);
            }
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

    }
}
