﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using Guna.UI2.AnimatorNS;

namespace CountDown
{
    public partial class UserControlDays : UserControl
    {  
        public static string static_day;
        public static int counter;
        private SqlConnection Con;
        private SqlCommand Command;
        string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\blert\\OneDrive\\Documents\\db_calendar.mdf;Integrated Security=True;Connect Timeout=30";

        ToolTip t1 = new ToolTip();

        
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            displayEvent(lbDays.Text);
        }

        public void days(int numDay)
        {
            lbDays.Text = numDay + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbDays.Text;
            EventFrom eventform = new EventFrom();
            eventform.Show();
            timer1.Start();
        }
        public void displayEvent(string days)
        {
            Con = new SqlConnection(conString);
            Con.Open();
            string Query = "SELECT * FROM tbl_calendar where date = @date";
            Command = Con.CreateCommand();
            Command.CommandText = Query;
            Command.Parameters.AddWithValue("@date", (Form1.static_year + "-" + Form1.static_month + "-" + days).ToString());
            SqlDataReader reader = Command.ExecuteReader();
            counter = 0;
            while(reader.Read())    
            {
                counter++;
                lblEvent.Text = counter.ToString();
            }
            counter = 0;
            reader.Close();
            reader.Dispose();
            Command.Dispose();
            Con.Close();
            
        }
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                displayEvent(lbDays.Text);
            }
            catch
            {
                timer1.Stop();
            }

        }
        private void lblEvent_Click(object sender, EventArgs e)
        {
            static_day = lbDays.Text;
            if(lblEvent.Text == "")
            {
                EventFrom eventform = new EventFrom();
                eventform.Show();
                timer1.Start();
            }
            ShowEvent();
        }
        public void ShowEvent()
        {
            Con = new SqlConnection(conString);
            Con.Open();
            string Query = "SELECT * FROM tbl_calendar where date = @date";
            Command = Con.CreateCommand();
            Command.CommandText = Query;
            Command.Parameters.AddWithValue("@date", (Form1.static_year + "-" + Form1.static_month + "-" + UserControlDays.static_day));
            SqlDataReader reader = Command.ExecuteReader();
            Form1.instance.eventsHold.Controls.Clear();
            while (reader.Read())
            {
                Event events = new Event();
                string Name = reader["event"].ToString();
                string Time = "From: " + reader["StartingTime"].ToString() + "" + reader["AmOrPmTime"].ToString() + " \nTo: " + reader["EndingTime"].ToString();
                events.SetEventName(Name);
                events.SetEventTime(Time);
                Form1.instance.eventsHold.Controls.Add(events);
                int tempMonth = Form1.static_month;
                int tempDay = int.Parse(static_day);
                if(tempMonth < 10 && tempDay < 10)
                {
                    Form1.instance.eventselect.Text = ("0" + static_day + " : 0" + Form1.static_month + " : " + Form1.static_year).ToString();
                }
                else if(tempMonth < 10)
                {
                    Form1.instance.eventselect.Text = (static_day + " : 0" + Form1.static_month + " : " + Form1.static_year).ToString();
                }
                else if(tempDay < 10)
                {
                    Form1.instance.eventselect.Text = ("0" + static_day + " : " + Form1.static_month + " : " + Form1.static_year).ToString();
                }
                else
                {
                    Form1.instance.eventselect.Text = (static_day + " : " + Form1.static_month + " : " + Form1.static_year).ToString();
                }
                
            }
            reader.Dispose();
            reader.Close();
            Command.Dispose();
            Con.Close();
        }
        private void lblEvent_MouseHover(object sender, EventArgs e)
        {
            if(lblEvent.Text != "")
            {
                t1.Show("Show Events", lblEvent);
                lblEvent.ForeColor = Color.Teal;
                lblEvent.Font = new Font(lblEvent.Font.Name, lblEvent.Font.Size + 6);
            }
            else
            {
                t1.Show("Add Event", this);
                this.BackColor = Color.Gray;
                lbDays.ForeColor = Color.White;
            }
        }

        private void lblEvent_MouseLeave(object sender, EventArgs e)
        {
            if(lblEvent.Text != "")
            {
                lblEvent.ForeColor = Color.SeaGreen;
                lblEvent.BackColor = Color.Transparent;
                lblEvent.Font = new Font(lblEvent.Font.Name, 12);
            }
            else
            {
                this.BackColor = Color.LightGray;
                lbDays.ForeColor = Color.DimGray;
            }
            
        }
        
        private void UserControlDays_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Add Event", this);
            this.BackColor = Color.Gray;
            lbDays.ForeColor = Color.White;
            lblEvent.ForeColor = Color.Aqua;
        }

        private void UserControlDays_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            lbDays.ForeColor = Color.DimGray;
            lblEvent.ForeColor = Color.SeaGreen;
        }
        
        private void UserControlDays_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
