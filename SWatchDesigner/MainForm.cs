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
            String[] apps = { "GPS", "Compass", "Time", "Weight", "Tracker", "Signal", "Weather" };
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
                NewLayoutDialog newLayoutDialog = new NewLayoutDialog();

   				// Show testDialog as a modal dialog and determine if DialogResult = OK.
   				if (newLayoutDialog.ShowDialog(this) == DialogResult.OK)
   				{
      				// Read the contents of testDialog's TextBox.
      				//this.txtResult.Text = newLayoutDialog.LayoutNameTxt.Text;
      				Console.WriteLine("OK");
   				}
   				else
   				{
      				//this.txtResult.Text = "Cancelled";
      				Console.WriteLine("Cancelled");
   				}
   				newLayoutDialog.Dispose();
   				Console.WriteLine("Continue");
                nsTabControl1.TabPages.Add("New layout");
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

            ResizeRedraw = true;
            backgroundWorker1.RunWorkerAsync();
            this.DoubleBuffered = true;
            
        }

        private void nsTheme1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Invalidate();
                System.Threading.Thread.Sleep(100);
            }
           
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("draw");
            Pen pen = new System.Drawing.Pen(System.Drawing.Color.Tomato);
            SolidBrush brush = new System.Drawing.SolidBrush(Color.Blue);
            Graphics g = e.Graphics;
            Rectangle app = new Rectangle(0, 0, 200, 200);
            g.DrawRectangle(pen, app);
            g.FillRectangle(brush, app);
        }


    }
}
