using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerF20210403
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }
        TimeSpan timeNow = new TimeSpan(0,0,0);
        TimeSpan addTime = new TimeSpan(0, 0, 1);


        private void timer1_Tick(object sender, EventArgs e)
        {
            timeNow += addTime;
            TimeView.Text = timeNow.ToString();


        }

        private void StartStop_Click(object sender, EventArgs e)
        {
            StartStop.Text = StartStop.Text.Equals("Start") ? "Stop" : "Start";
            timer1.Enabled = !timer1.Enabled;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timeNow = new TimeSpan(0, 0, 0);
            TimeView.Text = timeNow.ToString();
        }
    }
}
