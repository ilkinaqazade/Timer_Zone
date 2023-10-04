using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Task
{
    public partial class Form1 : Form
    {
        Timer timerBaku = new Timer();
        Timer timerLondon = new Timer();
        TimeZoneInfo londonTm = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        public Form1()
        {
            InitializeComponent();
        }

        private void BakuBtr_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ShowBakuTime();
                this.BackgroundImage = Properties.Resources.Baku;
            }
            else
            {
                MessageBox.Show("Click left !");
            }
        }

        private void LondonBtr_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowLondonTime();
                this.BackgroundImage = Properties.Resources.London;
            }
            else
            {
                MessageBox.Show("Click left !");
            }
        }
        private void ShowLondonTime()
        {
            timerBaku.Stop();
            DateTime londonTime = TimeZoneInfo.ConvertTime(DateTime.Now, londonTm);
            label1.Text = londonTime.ToLongTimeString();
            timerLondon.Interval = 1000;
            timerLondon.Tick += TimerLondon_Tick;
            timerLondon.Start();
        }

        private void ShowBakuTime()
        {
            timerLondon.Stop();
            timerBaku.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void TimerLondon_Tick(object sender, EventArgs e)
        {
            ShowLondonTime();
        }
    }
}
