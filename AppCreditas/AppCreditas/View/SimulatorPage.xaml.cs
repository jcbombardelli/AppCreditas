using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppCreditas.View
{
    public partial class SimulatorPage : ContentPage
    {
        private decimal moneyValue = 0m;
        public decimal Money
        {
            get { return moneyValue; }
            set
            {
                this.moneyValue = value;
                OnPropertyChanged(nameof(Money));
            }
        }


        private KindFinantial typeFin;
        public KindFinantial TypeFin
        {
            get { return typeFin; }
            set
            {
                typeFin = value;
                Reset();
            }
        }


        public void Reset()
        {
            frameValor.IsVisible = true;
            Money = 0;
        }

        public SimulatorPage()
        {
            InitializeComponent();
            BindingContext = this;


            money.TextChanged += Money_TextChanged;

            frameValor.IsVisible = false;

        }

        private void Money_TextChanged(object sender, TextChangedEventArgs e)
        {        }

        private void SelectSimulatorButton_Clicked(object sender, EventArgs e)
        {
            Button b = sender as Button;

            TypeFin = ((b.Text == StringTable.TextLabel_Page_Simulator_House) ? KindFinantial.House : KindFinantial.Car);
            Reset();

        }
    }



    public enum KindFinantial { Car, House }
}
