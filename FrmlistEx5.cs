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
    public partial class FrmlistEx5 : Form
    {
        public FrmlistEx5()
        {
            InitializeComponent();
        }
        double purchase;
        double total;
        double tax;
        private void cboTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTax.Items.Clear();
            purchase = int.Parse(txtPurchase.Text);
            if (cboTax.Text == "tax exempt")
            {
                lstTax.Items.Add("0%");
                tax = 0;
            }
            else if (cboTax.Text == "state sales tax only")
            {
                lstTax.Items.Add("3%");
                tax = purchase * 0.03;
            }
            else if (cboTax.Text == "federal and state sales tax")
            {
                lstTax.Items.Add("5%");
                tax = purchase * 0.05;
            }
            else 
            {
                lstTax.Items.Add("7%");
                tax = purchase * 0.07;
            }
            total = purchase + tax;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
           MessageBox.Show("total amount="+ total.ToString()+"\n sales tax"+tax.ToString(), "Purchase information",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
