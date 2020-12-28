using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace loanCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Button temp  = this.FindByName<Button>("tempButton");
            temp.BackgroundColor = Color.Red;


        }
    }
}
