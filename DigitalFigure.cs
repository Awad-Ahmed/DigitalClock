using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class DigitalFigure : UserControl
    {
       
        public DigitalFigure()
        {
            InitializeComponent();
        }
        public Color PanelTop
        {
            get { return TopA.BackColor; }
            set { TopA.BackColor = value; }
        }
        public Color PanelBottom
        {
            get { return BOTTOM.BackColor; }
            set { BOTTOM.BackColor = value; }
        }
        public Color PanelTopLeft
        {
            get { return TOPLEFT.BackColor; }
            set { TOPLEFT.BackColor = value; }
        }
        public Color PanelTopRigt
        {
            get { return TOPRIGHT.BackColor; }
            set { TOPRIGHT.BackColor = value; }
        }
        public Color PanelBottomLeft
        {
            get { return BOTTOMLEFT.BackColor; }
            set { BOTTOMLEFT.BackColor = value; }
        }
        public Color PanelBottoRight
        {
            get { return BOTTOMRIGHT.BackColor; }
            set { BOTTOMRIGHT.BackColor = value; }
        }
        public Color PanelMid
        {
            get { return MID.BackColor; }
            set { MID.BackColor = value; }
        }

    }
}
