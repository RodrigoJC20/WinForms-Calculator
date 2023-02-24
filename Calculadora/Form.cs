using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private List<string> ValidSymbols;
        private string LastResult = "";
        bool ResultInDisplay = false;

        public Calculadora()
        {
            InitializeComponent();

            ValidSymbols = new List<string>()
            {
                "+", "-", "*", "/", "%", "(", 
                ")", ".", "1", "2", "3", "4", 
                "5", "6", "7", "8", "9", "0"
            };
        }

        private void Button_Res_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length == 0) { return; }

            string ResultString = new DataTable().Compute(Display.Text, null).ToString();

            LastResult = ResultString;

            Display.Text = ResultString;

            History.Items.Add(ResultString);

            ResultInDisplay = true;
        }
        private void Display_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidSymbols.Contains(e.KeyChar.ToString()))
            {
                e.Handled = true;
                return;
            }

            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            } 
        }

        private void Button_Ans_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += LastResult;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "+";
        }

        private void Button_Sub_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "-";
        }

        private void Button_Mult_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "*";
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "/";
        }

        private void Button_Mod_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "%";
        }

        private void Button_Decimal_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += ".";
        }

        private void Button_AC_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "0";
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "1";
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "2";
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "3";
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "4";
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "5";
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "6";
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "7";
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "8";
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            Display.Text += "9";
        }

        private void Button_Del_Click(object sender, EventArgs e)
        {
            if (ResultInDisplay)
            {
                Display.Text = "";
                ResultInDisplay = false;
            }

            if (Display.Text.Length == 0) { return;  }

            Display.Text = Display.Text.Remove(Display.Text.Length - 1);
        }

        private void History_TextChanged(object sender, EventArgs e)
        {
            Display.Text += History.Text;
        }
    }
}
