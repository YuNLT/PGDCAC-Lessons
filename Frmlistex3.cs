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
    public partial class Frmlistex3 : Form
    {
        public Frmlistex3()
        {
            InitializeComponent();
        }
        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDays.Items.Clear();
            if (int.Parse(txtYear.Text) % 4 == 0)
            {
                if (cboMonth.Text == "February")
                {
                    lstDays.Items.Add("29");
                }
                else if (cboMonth.Text == "April")
                {
                    lstDays.Items.Add("30");
                }
                else if (cboMonth.Text=="June")
                {
                    lstDays.Items.Add("30");
                }
                else if (cboMonth.Text == "September")
                {
                    lstDays.Items.Add("30");
                }
                else if (cboMonth.Text == "November")
                {
                    lstDays.Items.Add("30");
                }
                else
                {
                    lstDays.Items.Add("31");
                }
            }
            else
            {
                if (cboMonth.Text == "February")
                {
                    lstDays.Items.Add("28");
                }
                else if (cboMonth.Text == "April")
                {
                    lstDays.Items.Add("30");
                }
                else if (cboMonth.Text == "June")
                {
                    lstDays.Items.Add("30");
                }
                else if (cboMonth.Text == "September")
                {
                    lstDays.Items.Add("30");
                }
                else if (cboMonth.Text == "November")
                {
                    lstDays.Items.Add("30");
                }
                else
                {
                    lstDays.Items.Add("31");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYear.Clear();
            cboMonth.Select();
            lstDays.ClearSelected();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
