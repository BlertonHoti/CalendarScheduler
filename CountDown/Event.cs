using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown
{
    
    public partial class Event : UserControl
    {
        public static string getEventName = "";
        public Event()
        {
            InitializeComponent();
        }
        public void SetEventName(string Name)
        {
            EventName.Text = Name;
        }
        public void SetEventTime(string Time)
        {
            TimeLbl.Text = Time;
        }
        private void EventName_Click(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Focus();
            getEventName = this.EventName.Text;
            SelectDesign.BackColor = Color.Aqua;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Event_Click(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Focus();
            SelectDesign.BackColor = Color.Aqua;
            getEventName = this.EventName.Text;
        }

        private void Event_Leave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            SelectDesign.BackColor = Color.Transparent;
        }

        private void TimeLbl_Click(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Focus();
            getEventName = this.EventName.Text;
            SelectDesign.BackColor = Color.Aqua;
        }

        private void TimeLbl_Leave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            SelectDesign.BackColor = Color.Transparent;
        }

        private void EventName_Leave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            SelectDesign.BackColor = Color.Transparent;
        }

        private void Event_Load(object sender, EventArgs e)
        {
            EventTime();
        }
        public void EventTime()
        {
            DateTime now = DateTime.Now;

            DateTime FutureEvent = new DateTime(Form1.static_year, Form1.static_month, int.Parse(UserControlDays.static_day));
            TimeSpan DiferenceTime = FutureEvent - now;
            if(DiferenceTime.Days <= 0)
            {
                if(DiferenceTime.Days < 0)
                {
                    Form1.instance.TimeLeft.Text = "To late!";
                    Form1.instance.TimeLeft.ForeColor = Color.Red;
                }
                else if(DiferenceTime.Days == 0)
                {
                    Form1.instance.TimeLeft.Text = "Today!";
                    Form1.instance.TimeLeft.ForeColor = Color.Orange;
                }
            }
            else
            {
                if(DiferenceTime.Days >= 93 && DiferenceTime.Days < 186)
                {
                    Form1.instance.TimeLeft.Text = "3+ months Left";
                }
                else if(DiferenceTime.Days >= 186 && DiferenceTime.Days < 365)
                {
                    Form1.instance.TimeLeft.Text = "6+ months Left";
                }
                else if(DiferenceTime.Days >= 365 && DiferenceTime.Days < 1825)
                {
                    Form1.instance.TimeLeft.Text = "1+ years Left";
                }
                else if (DiferenceTime.Days >= 1825 && DiferenceTime.Days < 3650)
                {
                    Form1.instance.TimeLeft.Text = "5+ years Left";
                }
                else if (DiferenceTime.Days >= 3650 && DiferenceTime.Days < 36500)
                {
                    Form1.instance.TimeLeft.Text = "10+ years Left";
                }
                else if (DiferenceTime.Days >= 36500)
                {
                    Form1.instance.TimeLeft.Text = "100+ years Left";
                }
                else
                {
                    Form1.instance.TimeLeft.Text = DiferenceTime.Days + " Days left";
                }
                Form1.instance.TimeLeft.ForeColor = Color.Green;
            }
        }
    }
}
