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
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
            frm.DisplayCostumDays(TheMonth, Theyear);
        }
    }
}
