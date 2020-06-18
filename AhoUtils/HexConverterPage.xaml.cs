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
    public partial class HexConverterPage : ContentPage
    {
        public HexConverterPage()
        {
            InitializeComponent();
            HexToDec.TextChanged += HexToDec_TextChanged;
            DecToHex.TextChanged += DecToHex_TextChanged;
        }

        private void HexToDec_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (HexToDec.Text.Length > 0)
            {
                uint num = checked((uint)Convert.ToUInt32(HexToDec.Text));
                DecToHex.Text = String.Format("{0:X}", num);
            }
            else if (HexToDec.Text.Length == 0)
            {
                DecToHex.Text = "";
            }
        }
        private void DecToHex_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DecToHex.Text.Length > 0)
            {
                uint decString = Convert.ToUInt32(DecToHex.Text, 16);
                HexToDec.Text = $"{decString}";
            }
            else if (DecToHex.Text.Length == 0)
            {
                HexToDec.Text = "";
            }
        }


    }
}