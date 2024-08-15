using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioandcombo
{
    public partial class exercise2 : Form
    {
        public exercise2()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtFirstNum.Text)>int.Parse(txtSecondNum.Text))
            {
                txtMaximum.Text = txtFirstNum.Text.ToString();
                txtMinimum.Text = txtSecondNum.Text.ToString();
            }
            else if(int.Parse(txtSecondNum.Text)>int.Parse(txtFirstNum.Text))
            {
                txtMaximum.Text=txtSecondNum.Text.ToString();
                txtMinimum.Text=txtFirstNum.Text.ToString();
            }
            else if(int.Parse(txtFirstNum.Text)==int.Parse(txtSecondNum.Text))
            {
                MessageBox.Show("The two numbers are equal","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNum.Clear();
            txtSecondNum.Clear();
            txtMinimum.Clear();
            txtMaximum.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
