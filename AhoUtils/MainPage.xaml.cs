using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AhoUtils
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ClickCounterButtonMainPage.Clicked += ClickCounterButtonMainPage_Clicked;
        }

        async void ClickCounterButtonMainPage_Clicked(object sender, EventArgs e)
        {
            var CCPage = new ClickCounterPage();
            await Navigation.PushModalAsync(CCPage);
        }
    }
}
