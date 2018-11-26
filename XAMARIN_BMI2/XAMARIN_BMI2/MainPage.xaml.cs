using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAMARIN_BMI2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            ButtonBMI.Clicked += ButtonBmiClickEvent;
            ButtonBMI2.Clicked += ButtonBmiClickedEvent2;
        }

        private void ButtonBmiClickedEvent2(object sender, EventArgs e)
        {
            float height = float.Parse(Height.Text);
            float weight = int.Parse(Weight.Text);
            

            if (height < 3)
            {
                height = height * height; //メートル
                weight = weight / height; //BMI計算
            }
            else
            {
                float height2 = int.Parse(Height.Text); //センチ
                height2 = height2 / 100;
                height2 = height2 * height2;
                weight = weight / height2;
            }

            Navigation.PushModalAsync(new NavigationPage(new BmiResult(weight)));
        }

        private void ButtonBmiClickEvent(object sender, EventArgs e)
        {

            //身長がメートルかセンチか判定する

            float height = float.Parse(Height.Text); //身長
            float weight = int.Parse(Weight.Text); //体重


            if ( height < 3)
            {
                height = height * height; //メートル
                weight = weight / height; //BMI計算
            }
            else
            {
                float height2 = int.Parse(Height.Text); //センチ
                height2 = height2 / 100;
                height2 = height2 * height2;
                weight = weight / height2;
            }


            //結果表示
            LabelResult.Text = "BMI=" + Math.Round(weight, 1);
        }
    }
}
