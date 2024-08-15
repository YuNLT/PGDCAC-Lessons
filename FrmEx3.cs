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
    public partial class FrmEx3 : Form
    {
        public FrmEx3()
        {
            InitializeComponent();
        }
        int month;
        int Day;
        private void btnResult_Click(object sender, EventArgs e)
        {
            month = int.Parse(txtMonth.Text);
            if (int.Parse(txtYear.Text) % 4 != 0)
            {

                switch (month)
                {
                    case 2:
                        Day = 28; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Day = 30; break;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Day = 31; break;
                }
            }
            else
            {
                month = int.Parse(txtMonth.Text);
               switch (month)
                {
                    case 2:
                        Day = 29; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Day = 30; break;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Day = 31; break;
                }
            }
            { 
                txtLastDay.Text = Day.ToString();
            }
    }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLastDay.Clear();
            txtMonth.Clear();   
            txtYear.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
