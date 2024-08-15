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
    public partial class FrmEx4cs : Form
    {
        public FrmEx4cs()
        {
            InitializeComponent();
        }
        int bonus;
        int salary;
        private void button1_Click(object sender, EventArgs e)
        {
            salary=int.Parse(txtSalary.Text);
            if(salary<=5000)
            { 
                bonus = 500;
                salary = bonus + salary;
            }
            else if(salary>5000&&salary<=8000)
            {
                bonus = 800;
                salary = bonus + salary;
            }
            else
            {
                bonus = 1000;
                salary = bonus + salary;
            }
            MessageBox.Show("Bonus="+bonus.ToString()+"\n Payment="+salary.ToString(),"Payment Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
