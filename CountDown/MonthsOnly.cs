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
        public static int static_month, static_year;
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
            static_month = month;
            static_year = year;

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
            static_month = month;
            static_year = year;

            lblDate.Text = year.ToString();

            for (int i = month; i <= 12; i++)
            {
                UserControlMonths ucBlank = new UserControlMonths();
                MonthContainer.Controls.Add(ucBlank);
                string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(i);
                ucBlank.DisplayMonthName(MonthName);
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            frmMDI form1 = new frmMDI();
            form1.Show();
            this.Close();
        }

        private void lblDate_MouseHover(object sender, EventArgs e)
        {
            lblDate.BackColor = SystemColors.Control;
        }

        private void lblDate_MouseLeave(object sender, EventArgs e)
        {
            lblDate.BackColor = Color.Transparent;
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MonthContainer.Controls.Clear();
            if(year > now.Year)
            {
                month = 1;
                year--;
                static_month = month;
                static_year = year;

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
        public void ApplicationClose()
        {
        }
    }
}
