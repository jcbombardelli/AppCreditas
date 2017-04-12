using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppCreditas.View
{
    public partial class LoginView : ContentPage
    {


        public const string jc = "jcgama";
        public const string gama = "gamaacademy";

        public string User { get; set; }
        public string Pass { get; set; }




        public LoginView()
        {
            InitializeComponent();
            BindingContext = this;
        }





        private async void LoginButton_Clicked(object sender, EventArgs e)
        {

            if (User == jc && Pass == gama)
                App.Current.MainPage = new XForms.View.MasterDetailPageView(new OverviewPage(), StringTable.App_Creditas, App.ListPageItems);
            else
                await DisplayAlert(StringTable.App_Creditas, StringTable.Message_WrongLogin, StringTable.Label_OK);
        }

        private void SimulatorButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new SimulatorPage());
        }
    }
}
