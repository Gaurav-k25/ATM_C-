using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + 0;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            btnbalance.Visible = false;
            btnwithdraw.Visible = false;
            btnloan.Visible = false;
            btndeposit.Visible = false;

        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit", "ATM system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(iExit==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnbalance.Visible = false;
            btnwithdraw.Visible = false;
            btnloan.Visible = false;
            btndeposit.Visible = false;
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            string pin1 = string.Format(txtdisplay.Text);
            string pin2 = string.Format(txtdisplay.Text);
            string pin3 = string.Format(txtdisplay.Text);
            string pin4 = string.Format(txtdisplay.Text);

            if (pin1=="1234")
            {
                btnbalance.Visible = true;
                btnwithdraw.Visible = true;
                btnloan.Visible = true;
                btndeposit.Visible =true;
            }
            else if (pin2 == "4567")
            {
                btnbalance.Visible = true;
                btnwithdraw.Visible = true;
                btnloan.Visible = true;
                btndeposit.Visible = true;
            }
            else if (pin3 == "78910")
            {
                btnbalance.Visible = true;
                btnwithdraw.Visible = true;
                btnloan.Visible = true;
                btndeposit.Visible = true;
            }
            else if (pin4 == "2512")
            {
                btnbalance.Visible = true;
                btnwithdraw.Visible = true;
                btnloan.Visible = true;
                btndeposit.Visible = true;
            }
            else
            {
                txtdisplay.Text = "Invalid pin";
                txtdisplay.ForeColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + ".";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "/";
        }
    }
}
