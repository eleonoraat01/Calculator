using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkCalculator
{
    public partial class Form1 : Form
    {
        calculations cc = new calculations();

        private double MemoryStore;
        public Form1()
        {
            InitializeComponent();
            cc.Operation = true;
            cc.IsDecimalPoint = true;

            btnMC.Enabled = false;
            btnM_Plus.Enabled = false;
            btnMR.Enabled = false;
            btnM_Min.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblResult.ResetText();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (lblResult.Text=="0" || (cc.Operation))
            {
                lblResult.ResetText();
                cc.Operation = false;
            }

            Button btn = (Button)sender;

            if (btn.Text == ",")
            {
                if (cc.IsDecimalPoint)
                {
                    lblResult.Text = lblResult.Text + btn.Text;
                    cc.IsDecimalPoint = false;
                }
            }
            else
            {
                lblResult.Text = lblResult.Text + btn.Text;
            }
        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            cc.Calculation = btn.Text;
            cc.Value = double.Parse(lblResult.Text);
            cc.Operation = true;
            cc.IsDecimalPoint = true;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cc.Calculation)
                {
                    case "+":
                        lblResult.Text = calculations.Addition(cc.Value, double.Parse(lblResult.Text)).ToString();
                        break;
                    case "-":
                        lblResult.Text = calculations.Substraction(cc.Value, double.Parse(lblResult.Text)).ToString();
                        break;
                    case "*":
                        lblResult.Text = calculations.Multiplication(cc.Value, double.Parse(lblResult.Text)).ToString();
                        break;
                    case "/":
                        lblResult.Text = calculations.Division(cc.Value, double.Parse(lblResult.Text)).ToString();
                        break;
                    case "√":
                        lblResult.Text = calculations.SquareRoot(cc.Value).ToString();
                        break;
                    case "x²":
                        lblResult.Text = calculations.MathPow(cc.Value, 2).ToString();
                        break;
                    //case "x³":
                    //    lblResult.Text = calculations.MathPow(cc.Value, 3).ToString();
                    //    break;
                    case "1/x":
                        lblResult.Text = calculations.Reciprocal(cc.Value, double.Parse(lblResult.Text)).ToString();
                        break;
                    default:
                        break;
                }
                cc.Operation = true;
                cc.IsDecimalPoint = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case ",":
                    btnPoint.PerformClick();
                    break;
                case "-":
                    btnMin.PerformClick();
                    break;
                case "+":
                    btnPlus.PerformClick();
                    break;
                case "*":
                    btnMul.PerformClick();
                    break;
                case "/":
                    btnDiv.PerformClick();
                    break;
                case " ":
                    btnResult.PerformClick();
                    break;
                case "\r":
                    btnResult.PerformClick();
                    break;
                default:
                    break;
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                lblResult.Text = "0";
            }
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            //memory clear
            MemoryStore = 0;
            btnMC.Enabled = false;
            btnM_Plus.Enabled = false;
            btnMR.Enabled = false;
            btnM_Min.Enabled = false;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            //memory read
            lblResult.Text = MemoryStore.ToString();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            //memory save
            MemoryStore = double.Parse(lblResult.Text);
            btnMC.Enabled = true;
            btnM_Plus.Enabled = true;
            btnMR.Enabled = true;
            btnM_Min.Enabled = true;
        }

        private void btnM_Plus_Click(object sender, EventArgs e)
        {
            //add current number to the memorized number and save
            MemoryStore += double.Parse(lblResult.Text);
        }

        private void btnM_Minus_Click(object sender, EventArgs e)
        {
            //memorized number minus the current number and save
            MemoryStore -= double.Parse(lblResult.Text);
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MemoryStore.ToString(), "Memory");
        }
    }
}
