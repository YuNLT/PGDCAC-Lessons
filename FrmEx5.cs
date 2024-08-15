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
    public partial class FrmEx5 : Form
    {
        public FrmEx5()
        {
            InitializeComponent();
        }
        int taxcode;
        double purchase;
        double saletax;
        double total;
        private void btnResult_Click(object sender, EventArgs e)
        {
            taxcode = int.Parse(txtCode.Text);
            purchase = double.Parse(txtPurchase.Text);
            switch (taxcode) {
                case 0:
                    saletax = 0;
                    break;
                case 1:
                    saletax = purchase * 0.03; break;
                case 2:
                    saletax = purchase * 0.05; break;
                case 3:
                    saletax = purchase * 0.07; break;
            }
            {
                txtSaleTax.Text=saletax.ToString();
                total = saletax + purchase;
                txtTotalAmount.Text=total.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
