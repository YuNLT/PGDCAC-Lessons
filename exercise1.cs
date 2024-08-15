using System;
using System.Windows.Forms;

namespace radioandcombo
{
    public partial class exercise1 : Form
    {
        public exercise1()
        {
            InitializeComponent();
        }
        int num1, num2;

        private void btnres_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtnum1.Text) > int.Parse(txtnum2.Text))
            {
                txtmaxnum.Text = txtnum1.Text;
            }
            else
            {
                txtmaxnum.Text = txtnum2.Text;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
