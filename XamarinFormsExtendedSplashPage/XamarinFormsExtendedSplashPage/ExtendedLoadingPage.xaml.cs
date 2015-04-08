using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsExtendedSplashPage
{
    public partial class ExtendedLoadingPage : ContentPage
    {
        public ExtendedLoadingPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            DelayedNaviagition();
        }

        private async void DelayedNaviagition()
        {
            await Task.Delay(2000);

            await Navigation.PushAsync(new RootPage());
        }
    }
}
