using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_MetroEvents.ViewModels
{
    class ThirdPageVM
    {
        Command exitMe;
        public ThirdPageVM() {
            exitMe = new Command(()=> {
                Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }

        public Command ExitMe {
            get { return exitMe; }
            set { }
        
        }
        
    }

}
