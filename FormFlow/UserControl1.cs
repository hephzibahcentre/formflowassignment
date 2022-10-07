using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFlow
{
    public partial class UserControl1: UserControl
    {
        decimal decNumber;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decNumber = Convert.ToDecimal(txtNumber.Text);
            lblOutput.Text = decNumber.ToString();
            if (decNumber >= 15)
            {
                this.BackColor = Color.Red;
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;
            } else
            {
                this.BackColor = Color.Blue;
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (decNumber > 0)
            {
                btn1.Visible = false;
                btn2.Visible = true;
                btn3.Visible = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (decNumber > 0)
            {
                btn1.Visible = true;
                btn2.Visible = false;
                btn3.Visible = true;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (decNumber > 0)
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = false;
            }
        }
    }
}
