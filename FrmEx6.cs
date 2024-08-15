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
    public partial class FrmEx6 : Form
    {
        public FrmEx6()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double regularhr, overtinehr, wagerate, regularpay,overtimepay,weeklypay;
            regularhr= double.Parse(txtRegular.Text);
            overtinehr=double.Parse(txtOvertime.Text);
            wagerate=double.Parse(txtWageRate.Text);
            regularpay = regularhr * wagerate;
            overtimepay = overtinehr * 1.5 * wagerate;
            weeklypay = regularpay + overtimepay;
            MessageBox.Show("Weekly pay ="+weeklypay.ToString(),"Payment Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOvertime.Clear();
            txtRegular.Clear();
            txtOvertime.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
