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
    public partial class StringSorterPage : ContentPage
    {
        public StringSorterPage()
        {
            InitializeComponent();

            SortButton.Clicked += SortButton_Clicked;
        }

        private void SortButton_Clicked(object sender, EventArgs e)
        {
            char[] characters = StringEntry.Text.ToArray();
            Array.Sort(characters);
            StringEntry.Text = new string(characters);
        }
    }
}