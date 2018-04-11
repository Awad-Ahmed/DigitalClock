using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace Digital_Clock
{
    public partial class Clock : Form
    {
        int RedValue,GreenValue,BlueValue;
        int Hrs, Mins, Secs;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int HoursFirstDigit, HoursSecondDigit, MinutesFirstDigit, MinutesSecodDigit, SecondsFirstDigit, SecondsSecondDigit;

        private void Bslider_Scroll(object sender, EventArgs e)
        {
            BlueValue = Bslider.Value;
        }

        private void Gslider_Scroll(object sender, EventArgs e)
        {
            GreenValue = Gslider.Value;
        }

        private void Rslider_Scroll(object sender, EventArgs e)
        {
            RedValue = Rslider.Value;
        }

        public void MapNumber(int num, DigitalFigure a)
        {
            switch (num)
            {
                case 0:
                    a.PanelTop = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopRigt = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopLeft = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottoRight = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottom = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelMid = Color.FromArgb(255, 64, 64, 64);
                    a.PanelBottomLeft = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    break;
                case 1:
                    a.PanelTopRigt = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottoRight = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTop = Color.FromArgb(255, 64, 64, 64);
                    a.PanelTopLeft = Color.FromArgb(255, 64, 64, 64);
                    a.PanelMid = Color.FromArgb(255, 64, 64, 64);
                    a.PanelBottom = Color.FromArgb(255, 64, 64, 64);
                    a.PanelBottomLeft = Color.FromArgb(255, 64, 64, 64);
                    break;
                case 2:
                    a.PanelTop = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopRigt = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelMid = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottomLeft = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottom = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopLeft = Color.FromArgb(255, 64, 64, 64);
                    a.PanelBottoRight = Color.FromArgb(255, 64, 64, 64);
                    break;
                case 3:
                    a.PanelTop = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopRigt = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopLeft = Color.FromArgb(255, 64, 64, 64);
                    a.PanelBottoRight = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottomLeft = Color.FromArgb(255, 64, 64, 64);
                    a.PanelMid = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottom = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    break;
                case 4:
                    a.PanelTopRigt = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopLeft = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottoRight = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelMid = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTop = Color.FromArgb(255, 64, 64, 64);
                    a.PanelBottom = Color.FromArgb(255, 64, 64, 64);
                    a.PanelBottomLeft = Color.FromArgb(255, 64, 64, 64);
                    break;
                case 5:
                    a.PanelBottomLeft = Color.FromArgb(255, 64, 64, 64);
                    a.PanelTopRigt = Color.FromArgb(255, 64, 64, 64);
                    a.PanelTop = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopLeft = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottoRight = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelMid = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottom = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    break;
                case 6:
                    a.PanelTopRigt = Color.FromArgb(255, 64, 64, 64);
                    a.PanelTop = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopLeft = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottoRight = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelMid = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottom = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottomLeft = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    break;
                case 7:
                    a.PanelBottomLeft = Color.FromArgb(255, 64, 64, 64);
                    a.PanelTop = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopRigt = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottoRight = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopLeft = Color.FromArgb(255, 64, 64, 64);
                    a.PanelMid = Color.FromArgb(255, 64, 64, 64);
                    a.PanelBottom = Color.FromArgb(255, 64, 64, 64);
                    break;
                case 8:
                    a.PanelTop = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopRigt = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopLeft = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottoRight = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelMid = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottom = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottomLeft = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    break;
                case 9:
                    a.PanelTop = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopRigt = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelTopLeft = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottoRight = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelMid = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottom = Color.FromArgb(255, RedValue, GreenValue, BlueValue);
                    a.PanelBottomLeft = Color.FromArgb(255, 64, 64, 64);
                    break;

            }
        }
        public Clock()
        {
           
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
           

            Hrs = Math.Abs(DateTime.Now.Hour - 12);
            Mins = DateTime.Now.Minute;
            Secs = DateTime.Now.Second;
            //Calculating first digits of each time
            HoursFirstDigit = (int)(Hrs.ToString()[0]) - 48;
            MinutesFirstDigit = (int)(Mins.ToString()[0]) - 48;
            SecondsFirstDigit = (int)(Secs.ToString()[0]) - 48;
            // checking if hrs and minutes and secs are larger than 10
            // because if it is a single Digit Time , the (Hrs.ToString()[1]) fails to read the second array element
            // causes a null exception 
            if (Hrs >= 10)
            {
                HoursSecondDigit = (int)(Hrs.ToString()[1]) - 48;
                MapNumber(HoursSecondDigit, Hours2);
                MapNumber(HoursFirstDigit, Hours1);
            }
            else
            {
                HoursSecondDigit = HoursFirstDigit;
                MapNumber(HoursSecondDigit, Hours2);
                MapNumber(0, Hours1);
            }           
            if (Mins >= 10)
            {
                MinutesSecodDigit = (int)(Mins.ToString()[1]) - 48;
                MapNumber(MinutesSecodDigit, Mins2);
                MapNumber(MinutesFirstDigit, Mins1);
            }
            else {
                MinutesSecodDigit =MinutesFirstDigit ;
                MapNumber(MinutesSecodDigit, Mins2);
                MapNumber(0, Mins1);
            }
            if (Secs >=10)
            {
                SecondsSecondDigit = (int)(Secs.ToString()[1]) - 48;
                MapNumber(SecondsSecondDigit, Secs2);
                MapNumber(SecondsFirstDigit, Secs1);
            }
            else {
                   SecondsSecondDigit = SecondsFirstDigit;
                   MapNumber(MinutesSecodDigit, Secs2);
                   MapNumber(0, Secs1);
                 }
            Debug.WriteLine("TIME" + Hrs + ":" + Mins + ":" + Secs);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Debug.WriteLine( DateTime.Now.ToString("H:MM:ss"));
            
            timer.Interval = (1*1000); // 1secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();         
        }
    }
}
