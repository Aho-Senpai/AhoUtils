using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AhoUtils
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClickCounterPage : ContentPage
    {
        uint ClickCounter;
        public ClickCounterPage()
        {
            InitializeComponent();
            ClickCounterButton.Clicked += ClickCounterButton_Clicked;
            ClickCounterReset.Clicked += ClickCounterReset_Clicked;
        }

        private void ClickCounterButton_Clicked(object sender, EventArgs e)
        {
            ClickCounter += 1;
            ClickCounterButton.Text = $"{ClickCounter}";
        }
        private void ClickCounterReset_Clicked(object sender, EventArgs e)
        {
            ClickCounter = 0;
            ClickCounterButton.Text = "Click Me!";
        }
    }
}