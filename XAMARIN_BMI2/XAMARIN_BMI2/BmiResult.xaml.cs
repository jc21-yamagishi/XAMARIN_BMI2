using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMARIN_BMI2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BmiResult : ContentPage
	{

        private float weight;

		public BmiResult ()
		{
			InitializeComponent ();
            buttonBack.Clicked += buttonBackClicked;
		}

        private void buttonBackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        public BmiResult(float weight)
        {
            InitializeComponent();
            this.weight = weight;
            labelBMI.Text = "BMI=" + Math.Round(weight,1);
            buttonBack.Clicked += buttonBackClicked;
        }
    }
}