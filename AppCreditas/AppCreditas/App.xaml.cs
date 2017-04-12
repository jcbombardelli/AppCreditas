using AppCreditas.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XForms.ViewModel;

namespace AppCreditas
{
    public partial class App : Application
    {

        public static List<MasterPageItem> ListPageItems
        {
            get
            {
                List<MasterPageItem> listMasterPageItem = new List<MasterPageItem>()
                {                   
                    new MasterPageItem() { Title = StringTable.Page_Simulator, Icon = "simulator", Target = typeof(SimulatorPage) },
                    new MasterPageItem() { Title = StringTable.Page_Outbound, Icon = "outbound", Target = typeof(OutboundPage) },
                    new MasterPageItem() { Title = StringTable.Page_Chat, Icon = "chat", Target = typeof(ChatPage) },
                };

                return listMasterPageItem;
            }
        }


        public App()
        {
            InitializeComponent();

            MainPage = new AppCreditas.View.LoginView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
