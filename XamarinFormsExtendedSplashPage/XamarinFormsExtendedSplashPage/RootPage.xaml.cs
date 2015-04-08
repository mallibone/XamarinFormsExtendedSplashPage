using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsExtendedSplashPage
{
    public partial class RootPage : ContentPage
    {
        public RootPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Navigation.RemovePage(Navigation.NavigationStack[0]);
        }
    }
}
