using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loanCalculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pmt : ContentPage
    {
        public pmt()
        {
            InitializeComponent();
        }

        void backToMain(object sender, EventArgs args)
        {
            Button temp = this.FindByName<Button>("otherTempButton");
            temp.BackgroundColor = Color.Blue;

        }
    }
}