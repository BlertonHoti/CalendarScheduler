using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CountDown
{
    public partial class frmMDI : Form
    {
        bool mouseDown;
        private Point Offset;

        static frmMDI obj;
        public static frmMDI instance
        {
            get
            {
                if(obj == null)
                {
                    obj = new frmMDI();
                }
                return obj;
            }
        }
        public FlowLayoutPanel eventsHold
        {
            get { return EventContainer; }
            set { EventContainer = value; }
        }
        public Label eventselect
        {
            get { return EventSelected; }
            set { EventSelected = value; }
        }
        public Label TimeLeft
        {
            get { return DaysLeftLbl; }
            set { DaysLeftLbl = value; }
        }

        private SqlConnection Con;
        private SqlCommand Command;
        string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\blert\\OneDrive\\Documents\\db_calendar.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true";

        int month, year;
        public static int static_month, static_year;
        public frmMDI()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDays();
            obj = this;
            AutoDataDelete();
            DateTime now = DateTime.Now;
            UserControlDays.static_day = now.Day.ToString();
            UserControlDays load = new UserControlDays();
            load.ShowEvent();
        }
        public void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = MonthName + "  " + year;

            static_month = month;
            static_year = year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayContainer.Controls.Add(ucBlank);
            }
            for(int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }
        public void EventTime()
        {
            DateTime now = DateTime.Now;

            DateTime FutureEvent = new DateTime(frmMDI.static_year, frmMDI.static_month, int.Parse(UserControlDays.static_day));
            TimeSpan DiferenceTime = FutureEvent - now;
            if (DiferenceTime.Days <= 0)
            {
                if (DiferenceTime.Days < 0)
                {
                    DaysLeftLbl.Text = "Over";
                    DaysLeftLbl.ForeColor = Color.Red;
                }
                else if (DiferenceTime.Days == 0)
                {
                    DaysLeftLbl.Text = "Today";
                    DaysLeftLbl.ForeColor = Color.Yellow;
                }
            }
            else
            {
                DaysLeftLbl.Text = DiferenceTime.Days.ToString() + "Days Left";
                DaysLeftLbl.ForeColor = Color.LightGreen;
            }
        }
        public void DisplayCostumDays(int monthTemp, int yearTemp)
        {
            DateTime now = DateTime.Now;

            month = monthTemp;
            year = yearTemp;

            dayContainer.Controls.Clear();
            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = MonthName + "  " + year;

            

            static_month = month;
            static_year = year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayContainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }
        

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseBtn_MouseHover(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.LightGray;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.Transparent;
        }

        private void previousBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                int tempYear = now.Year;

                dayContainer.Controls.Clear();
                month--;
                

                if (month < now.Month && year == now.Year)
                {
                    MessageBox.Show("You cannot see date or add events in more than a month in past!!");
                    DisplayDays();
                }
                else
                {
                    if (year > tempYear && month < 1)
                    {
                        month = 12;
                        year--;
                    }
                    static_month = month;
                    static_year = year;

                    string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                    lblDate.Text = MonthName + "  " + year;


                    DateTime startOfMonth = new DateTime(year, month, 1);
                    int days = DateTime.DaysInMonth(year, month);
                    int daysOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

                    for (int i = 1; i < daysOfTheWeek; i++)
                    {
                        UserControlBlank ucBlank = new UserControlBlank();
                        dayContainer.Controls.Add(ucBlank);
                    }

                    for (int i = 1; i <= days; i++)
                    {
                        UserControlDays ucDays = new UserControlDays();
                        ucDays.days(i);
                        dayContainer.Controls.Add(ucDays);
                    }
                }
                
            }
            catch (Exception ex)
            {
                frmMDI theForm = new frmMDI();
                this.Hide();
                theForm.Show();
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void DelEventBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(Event.getEventName == "")
                {
                    MessageBox.Show("Please Select an Event!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you wanna delete this event?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Con = new SqlConnection(conString);
                        Con.Open();
                        Command = new SqlCommand("DELETE FROM tbl_calendar WHERE event = @id", Con);
                        Command.Parameters.AddWithValue("@id", Event.getEventName);
                        Command.ExecuteNonQuery();
                        Con.Close();
                        MessageBox.Show("Event has been deleted!");
                        UserControlDays control = new UserControlDays();
                        control.ShowEvent();
                        Event.getEventName = "";
                        UserControlDays temp = new UserControlDays();
                        temp.ShowEvent();
                        temp.displayEvent(UserControlDays.static_day);
                    }
                    else
                    {
                        Event.getEventName = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }

        private void TopHeader_MouseDown(object sender, MouseEventArgs e)
        {
            Offset.X = (int)e.X;
            Offset.Y = (int)e.Y;
            mouseDown = true;
        }

        private void TopHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point CurrentScreen = PointToScreen(e.Location);
                Location = new Point(CurrentScreen.X - Offset.X, CurrentScreen.Y - Offset.Y);
            }
        }

        private void TopHeader_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void TopHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void EditEventBtn_Click(object sender, EventArgs e)
        {
            if(Event.getEventName == "")
            {
                MessageBox.Show("Please Select an Event!");
            }
            else
            {
                EditEvent editEvent = new EditEvent();
                editEvent.Show();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            
            dayContainer.Controls.Clear();
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            static_month = month;
            static_year = year;

            string MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = MonthName + "  " + year;

            DateTime startOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            MonthsOnly monthonly = new MonthsOnly();
            monthonly.Show();
            this.Hide();
        }

        private void lblDate_MouseHover(object sender, EventArgs e)
        {
            lblDate.BackColor = SystemColors.Control;
        }

        private void lblDate_MouseLeave(object sender, EventArgs e)
        {
            lblDate.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void AutoDataDelete()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                DateTime now = DateTime.Now;
                string fullDateTemp = now.Year + "-" + now.Month + "-" + "1";

                connection.Open();
                
                string query = "SELECT Id, date FROM tbl_calendar WHERE date < @fullDateTemp";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fullDateTemp", DateTime.Parse(fullDateTemp));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["Id"]);
                                string deleteQuery = "DELETE FROM tbl_calendar WHERE Id = @id";
                                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@id", id);
                                    deleteCommand.ExecuteNonQuery();
                                }
                            }
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
        }
    }
}
