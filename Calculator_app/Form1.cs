using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_app
{
    public partial class Form1 : Form
    {
        double result_value = 0;
        string oparator = "";
        bool isOparationDone = false;

        public Form1()
        {
            InitializeComponent();
        }


        // For number buttons
        private void btn_click(object sender, EventArgs e)
        {
            if(result_window.Text == "0" || isOparationDone)
            {
                result_window.Clear();
            }
            Button button = (Button)sender;
            result_window.Text = result_window.Text + button.Text;
            isOparationDone = false ;
        }

        // For clear button
        private void calculator_clear_Click(object sender, EventArgs e)
        {
            result_window.Clear();
            result_window.Text = "0";
        }


        // For oparators button
        private void oparator_btn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            oparator = button.Text;
            result_value = double.Parse(result_window.Text);
            result_window.Text = button.Text;
            isOparationDone = true ;
        }

        // For equal button
        private void equal_button_Click(object sender, EventArgs e)
        {
            switch (oparator)
            {
                case "+":
                result_window.Text = (result_value + double.Parse(result_window.Text)).ToString();
                    break;

                case "-":
                result_window.Text = (result_value - double.Parse(result_window.Text)).ToString();
                    break;

                case "*":
                result_window.Text = (result_value * double.Parse(result_window.Text)).ToString();
                    break;

                case "/":
                result_window.Text = (result_value / double.Parse(result_window.Text)).ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
