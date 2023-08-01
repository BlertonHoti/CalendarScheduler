using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown
{
    public partial class UserControlMonths : UserControl
    {
        
        public UserControlMonths()
        {
            InitializeComponent();
        }
        public void DisplayMonthName(string name)
        {
            MonthNameTxt.Text = name;
        }

        private void UserControlMonths_Click(object sender, EventArgs e)
        {
            DateTime TheDate = DateTime.ParseExact(this.MonthNameTxt.Text, "MMMM", CultureInfo.InvariantCulture);
            int TheMonth = TheDate.Month;
            int Theyear = MonthsOnly.static_year;

            this.Parent.Parent.Parent.Hide();
            frmMDI frm = new frmMDI();  
            frm.Show();
            frm.DisplayCostumDays(TheMonth, Theyear);
        }

        private void UserControlMonths_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            MonthNameTxt.ForeColor = Color.White;
        }

        private void UserControlMonths_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            MonthNameTxt.ForeColor = Color.DimGray;
        }

        private void MonthNameTxt_Click(object sender, EventArgs e)
        {
            DateTime TheDate = DateTime.ParseExact(this.MonthNameTxt.Text, "MMMM", CultureInfo.InvariantCulture);
            int TheMonth = TheDate.Month;
            int Theyear = MonthsOnly.static_year;

            this.Parent.Parent.Parent.Hide();
            frmMDI frm = new frmMDI();
            frm.Show();
            frm.DisplayCostumDays(TheMonth, Theyear);
        }

        private void MonthNameTxt_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            MonthNameTxt.ForeColor = Color.White;
        }

        private void MonthNameTxt_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            MonthNameTxt.ForeColor = Color.DimGray;
        }

        private void UserControlMonths_Load(object sender, EventArgs e)
        {
            
        }
    }
}
