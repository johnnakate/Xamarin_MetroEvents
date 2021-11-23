using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_MetroEvents.Models;
using Xamarin_MetroEvents.ViewModels;

namespace Xamarin_MetroEvents.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        Item item;
        public SecondPage()
        {
            InitializeComponent();
        }

        public SecondPage(Item ite) {
            this.item = ite;
            InitializeComponent();
            ((SecondPageVM)BindingContext).Item = ite;
            lblName.Text = ite.Name;
        }

    }
}