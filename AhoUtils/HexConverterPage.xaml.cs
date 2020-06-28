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
            SwitchButtonHex2Dec.Clicked += SwitchButtonHex2Dec_Clicked;

            #region Keys Buttons Events Sub
            Button_1.Clicked += Button_1_Clicked;
            Button_2.Clicked += Button_2_Clicked;
            Button_3.Clicked += Button_3_Clicked;
            Button_4.Clicked += Button_4_Clicked;
            Button_5.Clicked += Button_5_Clicked;
            Button_6.Clicked += Button_6_Clicked;
            Button_7.Clicked += Button_7_Clicked;
            Button_8.Clicked += Button_8_Clicked;
            Button_9.Clicked += Button_9_Clicked;
            Button_0.Clicked += Button_0_Clicked;
            Button_A.Clicked += Button_A_Clicked;
            Button_B.Clicked += Button_B_Clicked;
            Button_C.Clicked += Button_C_Clicked;
            Button_D.Clicked += Button_D_Clicked;
            Button_E.Clicked += Button_E_Clicked;
            Button_F.Clicked += Button_F_Clicked;
            Button_Clear.Clicked += Button_Clear_Clicked;
            Button_Delete.Clicked += Button_Delete_Clicked;
            #endregion
        }

        bool ConversionDirrection = true;
        private void SwitchButtonHex2Dec_Clicked(object sender, EventArgs e)
        {
            if (ConversionDirrection)
            {
                ConversionDirrection = false;
                SwitchButtonHex2Dec.Text = "Dec <-- Hex";
                DecToHex.BackgroundColor = Color.DarkGreen;
                HexToDec.BackgroundColor = Color.DarkGray;
                Button_A.TextColor = Color.Black;
                Button_B.TextColor = Color.Black;
                Button_C.TextColor = Color.Black;
                Button_D.TextColor = Color.Black;
                Button_E.TextColor = Color.Black;
                Button_F.TextColor = Color.Black;
            }
            else if (!ConversionDirrection)
            {
                ConversionDirrection = true;
                SwitchButtonHex2Dec.Text = "Dec --> Hex";
                HexToDec.BackgroundColor = Color.DarkGreen;
                DecToHex.BackgroundColor = Color.DarkGray;
                Button_A.TextColor = Color.Red;
                Button_B.TextColor = Color.Red;
                Button_C.TextColor = Color.Red;
                Button_D.TextColor = Color.Red;
                Button_E.TextColor = Color.Red;
                Button_F.TextColor = Color.Red;
            }
        }

        private void HexToDec_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (HexToDec.Text.Length > 0)
            {
                try
                {
                    uint HexNum = checked((uint)Convert.ToUInt32(HexToDec.Text));
                    DecToHex.Text = String.Format("{0:X}", HexNum);
                }
                catch (OverflowException)
                {
                    DisplayAlert("Oops!", "Too Big OwO", "Ok");
                }
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
                try
                {
                    uint DecNum = Convert.ToUInt32(DecToHex.Text, 16);
                    HexToDec.Text = $"{DecNum}";
                }
                catch (OverflowException)
                {
                    DisplayAlert("Oops!", "Too Big OwO", "Ok");
                }
            }
            else if (DecToHex.Text.Length == 0)
            {
                HexToDec.Text = "";
            }
        }

        #region Buttons Keys Code
        private void Button_1_Clicked(object sender, EventArgs e)
        {
            if (ConversionDirrection)
            {
                HexToDec.Text += "1";
            }
            else if (!ConversionDirrection)
            {
                DecToHex.Text += "1";
            }
        }
        private void Button_2_Clicked(object sender, EventArgs e)
        {
            if (ConversionDirrection)
            {
                HexToDec.Text += "2";
            }
            else if (!ConversionDirrection)
            {
                DecToHex.Text += "2";
            }
        }
        private void Button_3_Clicked(object sender, EventArgs e)
        {
            if (ConversionDirrection)
            {
                HexToDec.Text += "3";
            }
            else if (!ConversionDirrection)
            {
                DecToHex.Text += "3";
            }
        }
        private void Button_4_Clicked(object sender, EventArgs e)
        {
            if (ConversionDirrection)
            {
                HexToDec.Text += "4";
            }
            else if (!ConversionDirrection)
            {
                DecToHex.Text += "4";
            }
        }
        private void Button_5_Clicked(object sender, EventArgs e)
        {
            if (ConversionDirrection)
            {
                HexToDec.Text += "5";
            }
            else if (!ConversionDirrection)
            {
                DecToHex.Text += "5";
            }
        }
        private void Button_6_Clicked(object sender, EventArgs e)
        {
            if (ConversionDirrection)
            {
                HexToDec.Text += "6";
            }
            else if (!ConversionDirrection)
            {
                DecToHex.Text += "6";
            }
        }
        private void Button_7_Clicked(object sender, EventArgs e)
        {
            if (ConversionDirrection)
            {
                HexToDec.Text += "7";
            }
            else if (!ConversionDirrection)
            {
                DecToHex.Text += "7";
            }
        }
        private void Button_8_Clicked(object sender, EventArgs e)
        {
            if (ConversionDirrection)
            {
                HexToDec.Text += "8";
            }
            else if (!ConversionDirrection)
            {
                DecToHex.Text += "8";
            }
        }
        private void Button_9_Clicked(object sender, EventArgs e)
        {
            if (ConversionDirrection)
            {
                HexToDec.Text += "9";
            }
            else if (!ConversionDirrection)
            {
                DecToHex.Text += "9";
            }
        }
        private void Button_0_Clicked(object sender, EventArgs e)
        {
            if (ConversionDirrection)
            {
                HexToDec.Text += "0";
            }
            else if (!ConversionDirrection)
            {
                DecToHex.Text += "0";
            }
        }
        private void Button_A_Clicked(object sender, EventArgs e)
        {
            if (!ConversionDirrection)
            {
                DecToHex.Text += "A";
            }
        }
        private void Button_B_Clicked(object sender, EventArgs e)
        {
            if (!ConversionDirrection)
            {
                DecToHex.Text += "B";
            }
        }
        private void Button_C_Clicked(object sender, EventArgs e)
        {
            if (!ConversionDirrection)
            {
                DecToHex.Text += "C";
            }
        }
        private void Button_D_Clicked(object sender, EventArgs e)
        {
            if (!ConversionDirrection)
            {
                DecToHex.Text += "D";
            }
        }
        private void Button_E_Clicked(object sender, EventArgs e)
        {
            if (!ConversionDirrection)
            {
                DecToHex.Text += "E";
            }
        }
        private void Button_F_Clicked(object sender, EventArgs e)
        {
            if (!ConversionDirrection)
            {
                DecToHex.Text += "F";
            }
        }
        private void Button_Clear_Clicked(object sender, EventArgs e)
        {
            HexToDec.Text = "";
            DecToHex.Text = "";
        }
        private void Button_Delete_Clicked(object sender, EventArgs e)
        {
            if (ConversionDirrection && HexToDec.Text.Length > 0)
            {
                HexToDec.Text = HexToDec.Text.Remove(HexToDec.Text.Length - 1, 1);
            }
            else if (!ConversionDirrection && DecToHex.Text.Length > 0)
            {
                DecToHex.Text = DecToHex.Text.Remove(DecToHex.Text.Length - 1, 1);
            }
        }
        #endregion

    }
}