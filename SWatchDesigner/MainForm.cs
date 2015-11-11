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

            // Add available app names to the ListView.
            String[] apps = { "GPS (Lat-Long)", "Compass", "Time", "Trail Tracker", "Signal", "Weather" };
            foreach (String app in apps)
            {
                appList.AddItem(app);
            }
        }


        private void nsTheme1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        // Method to allow moving of the window.
        private void nsTheme1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void nsTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the "New layout" tab was clicked.
            if (nsTabControl1.SelectedIndex == nsTabControl1.TabPages.Count-1)
            {
                // Display layout naming screen.
                // CODE GOES HERE
                nsTabControl1.TabPages.Add("New layout");
            }
        }

    }
}
