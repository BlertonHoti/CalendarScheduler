using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace CountDown
{
    public partial class MonthsOnly : Form
    {
        int month, year;
        public MonthsOnly()
        {
            InitializeComponent();
        }
        public void DisplayMonths()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            lblDate.Text = year.ToString();
            

            for (int i = month; i <= 12; i++)
            {
                UserControlMonths ucBlank = new UserControlMonths();
                MonthContainer.Controls.Add(ucBlank);
                string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(i);
                ucBlank.DisplayMonthName(MonthName);
            }
            
        }

        private void MonthsOnly_Load(object sender, EventArgs e)
        {
            DisplayMonths();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MonthContainer.Controls.Clear();
            month = 1;
            year++;
            
            lblDate.Text = year.ToString();

            for (int i = month; i <= 12; i++)
            {
                UserControlMonths ucBlank = new UserControlMonths();
                MonthContainer.Controls.Add(ucBlank);
                string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(i);
                ucBlank.DisplayMonthName(MonthName);
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MonthContainer.Controls.Clear();
            if(year > now.Year)
            {
                month = 1;
                year--;

                lblDate.Text = year.ToString();

                for (int i = month; i <= 12; i++)
                {
                    UserControlMonths ucBlank = new UserControlMonths();
                    MonthContainer.Controls.Add(ucBlank);
                    string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(i);
                    ucBlank.DisplayMonthName(MonthName);
                }
            }
            else
            {
                MessageBox.Show("You cannot see date or add events in more than a month in past!!");
                DisplayMonths();
            }
            
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
