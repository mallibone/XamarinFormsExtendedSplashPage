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

            var rootPage = Navigation.NavigationStack[0];
            if (typeof (RootPage) == rootPage.GetType()) return; 
            Navigation.RemovePage(rootPage);
        }
    }
}
