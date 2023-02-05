using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        }
    }
}
