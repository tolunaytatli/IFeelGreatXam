using IFeelGreat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IFeelGreatXAM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        private void submit_Clicked(object sender, EventArgs e)
        {
            var maleRatio = Convert.ToDouble(var1.Text);
            var maleYesRatio = Convert.ToDouble(var2.Text);
            var femaleYesRatio = Convert.ToDouble(var3.Text);

            Solution solution = new Solution(maleRatio, maleYesRatio, femaleYesRatio);
            var probabilityNo = solution.probabilityNo();
            var probabilityYes = solution.probabilityYes();
            ed1.Text = string.Join(";", probabilityNo);
            ed2.Text = string.Join(";", probabilityYes);
        }
    }
}
