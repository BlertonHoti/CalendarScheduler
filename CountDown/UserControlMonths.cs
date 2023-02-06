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
    }
}
