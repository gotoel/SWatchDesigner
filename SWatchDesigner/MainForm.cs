using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWatchDesigner
{
    public partial class MainForm : Form
    {
        public Point mouseLocation;
        public MainForm()
        {
            InitializeComponent();
            String[] apps = { "GPS", "Compass", "Time", "Weight", "Tracker", "Signal", "Weather" };
            foreach (String app in apps)
            {
                nsListView1.AddItem(app);
                nsListView2.AddItem(app);
            }
        }

        private void nsTheme1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void nsTheme1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

    }
}
