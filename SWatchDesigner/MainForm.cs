using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SWatchDesigner
{
    public partial class MainForm : Form
    {
        System.Drawing.Graphics formGraphics;
        public Point mouseLocation;
        private List<App> apps = new List<App>();

        bool isDown = false;
        int initialX;
        int initialY;
        int curX, curY;

        //RESIZING CODE
        private Rectangle areaRect;
        private Rectangle oldRect;
        private int dragHandle = 0;
        private Point dragPoint;

        int selectedAppIndex = -1;
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
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

            //ResizeRedraw = true;
            backgroundWorker1.RunWorkerAsync();
    
        }

        private void nsTheme1_Paint(object sender, PaintEventArgs e)
        {
            this.Refresh();
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
            formGraphics = e.Graphics;
            if (isDown == true)
            {
  


                Pen pen = new System.Drawing.Pen(System.Drawing.Color.Tomato);
                SolidBrush brush = new System.Drawing.SolidBrush(Color.Blue);

                Font font = new Font(new FontFamily("Consolas"), 9.0f);
                formGraphics.DrawString("X: " + curX + ", Y: " + curY, font, brush, curX, curY);

                //this.Refresh();
                Pen drwaPen = new Pen(Color.Navy, 1);
                int width = curX - initialX, height = curY - initialY;
                //if (Math.Sign (width) == -1) width = width 
                //Rectangle rect = new Rectangle(initialPt.X, initialPt.Y, Cursor.Position.X - initialPt.X, Cursor.Position.Y - initialPt.Y);
                Console.WriteLine((int)Math.Min(curX, initialX) + "   " + (int)Math.Min(curY, initialY) + "   " + (int)Math.Abs(curX - initialX) + "   " + (int)Math.Abs(curY - initialY));
                Console.WriteLine(this.ToString());
                Rectangle app = new Rectangle((int)Math.Min(curX, initialX), (int)Math.Min(curY, initialY), (int)Math.Abs(curX - initialX), (int)Math.Abs(curY - initialY));
                Rectangle appBorder = new Rectangle((int)Math.Min(curX, initialX)-1, (int)Math.Min(curY, initialY)-1, (int)Math.Abs(curX - initialX)+1, (int)Math.Abs(curY - initialY)+1);
                
                formGraphics.DrawRectangle(pen, appBorder);
                formGraphics.FillRectangle(brush, app);

            }
            foreach (App a in apps)
            {
                Pen pen = new System.Drawing.Pen(System.Drawing.Color.Tomato);
                SolidBrush brush = new System.Drawing.SolidBrush(Color.Blue);
                SolidBrush strBrush = new System.Drawing.SolidBrush(Color.Red);
                Rectangle app = a.getRect();
                Rectangle appBorder = new Rectangle(a.getX() - 1, a.getY() - 1, a.getWidth() + 1, a.getHeight() + 1);

                Font font = new Font(new FontFamily("Consolas"), 9.0f);
                formGraphics.DrawRectangle(pen, appBorder);
                formGraphics.FillRectangle(brush, app);

                Size proposedSize = new Size(int.MaxValue, int.MaxValue);
                String info = "X: " + a.getX() + ", Y: " + a.getY() + ", Width: " + a.getWidth() + ", Height: " + a.getHeight();
                formGraphics.DrawString(info, font, strBrush, a.Center().X - TextRenderer.MeasureText(info,font, proposedSize).Width/2, a.Center().Y);
            }

            e.Graphics.DrawRectangle(Pens.Red, areaRect);
            for (int i = 1; i < 9; i++)
            {
                e.Graphics.FillRectangle(Brushes.DarkRed, GetHandleRect(i));
            }
           
        }



        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;

            Point point = panel10.PointToClient(Cursor.Position);
            Boolean clickedOnRect = false;
            foreach (App app in apps)
            {
                if (app.getRect().Contains(point))
                {
                    clickedOnRect = true;
                    areaRect = app.getRect();
                    selectedAppIndex = apps.IndexOf(app);
                }
            }
            if (!clickedOnRect)
            {
                if (appList.SelectedItems.Count() > 0)
                {
                    if (point.X >= 1 && point.X <= panel10.Width - 1)
                    {
                        initialX = point.X;
                    }
                    if (point.Y >= 1 && point.Y <= panel10.Height - 1)
                    {
                        initialY = point.Y;
                    }
                }
            }
            else
            {
                //RESIZE CODE
                for (int i = 1; i < 9; i++)
                {
                    if (GetHandleRect(i).Contains(point))
                    {
                        dragHandle = i;
                        oldRect = areaRect;
                        dragPoint = GetHandlePoint(i);
                    }
                }
            }
        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown == true)
            {

                Point point = panel10.PointToClient(Cursor.Position);

                Boolean clickedOnRect = false;
                foreach (App app in apps)
                {
                    if (app.getRect().Contains(point))
                        clickedOnRect = true;
                }
                if (!clickedOnRect)
                {
                    if (appList.SelectedItems.Count() > 0)
                    {
                        if (point.X >= 1 && point.X <= panel10.Width - 1)
                        {
                            curX = point.X;
                        }
                        if (point.Y >= 1 && point.Y <= panel10.Height - 1)
                        {
                            curY = point.Y;
                        }
                        this.Refresh();
                    }
                }
                else
                {
                    // Where I started - where I stopped
                    int x_diff = dragPoint.X - point.X;
                    int y_diff = dragPoint.Y - point.Y;

                    // Minimum values
                    int small_offset = 5;
                    int left = small_offset;
                    int top = small_offset;
                    int width = small_offset;
                    int height = small_offset;

                    // Max values
                    int max_width = panel10.Width-1;
                    int max_height = panel10.Height-1;

                    if (dragHandle == 1)
                    {
                        left = Math.Max(oldRect.Left - x_diff, left);
                        top = Math.Max(oldRect.Top - y_diff, top);
                        width = Math.Min(Math.Max(oldRect.Width + x_diff, width), max_width - left - small_offset);
                        height = Math.Min(Math.Max(oldRect.Height + y_diff, height), max_height - top - small_offset);
                    }
                    else if (dragHandle == 2)
                    {
                        left = Math.Max(oldRect.Left - x_diff, left);
                        top = oldRect.Top;
                        width = Math.Min(Math.Max(oldRect.Width + x_diff, width), max_width - left - small_offset);
                        height = oldRect.Height;
                    }
                    else if (dragHandle == 3)
                    {
                        left = Math.Max(oldRect.Left - x_diff, left);
                        top = oldRect.Top;
                        width = Math.Min(Math.Max(oldRect.Width + x_diff, width), max_width - left - small_offset);
                        height = Math.Min(Math.Max(oldRect.Height - y_diff, height), max_height - top - small_offset);
                    }
                    else if (dragHandle == 4)
                    {
                        left = oldRect.Left;
                        top = Math.Max(oldRect.Top - y_diff, top);
                        width = oldRect.Width;
                        height = Math.Min(Math.Max(oldRect.Height + y_diff, height), max_height - top - small_offset);
                    }
                    else if (dragHandle == 5)
                    {
                        left = oldRect.Left;
                        top = oldRect.Top;
                        width = oldRect.Width;
                        height = Math.Min(Math.Max(oldRect.Height - y_diff, height), max_height - top - small_offset);
                    }
                    else if (dragHandle == 6)
                    {
                        left = oldRect.Left;
                        top = Math.Max(oldRect.Top - y_diff, top);
                        width = Math.Min(Math.Max(oldRect.Width - x_diff, width), max_width - left - small_offset);
                        height = Math.Min(Math.Max(oldRect.Height + y_diff, height), max_height - top - small_offset);
                    }
                    else if (dragHandle == 7)
                    {
                        left = oldRect.Left;
                        top = oldRect.Top;
                        width = Math.Min(Math.Max(oldRect.Width - x_diff, width), max_width - left - small_offset);
                        height = oldRect.Height;

                    }
                    else if (dragHandle == 8)
                    {
                        left = oldRect.Left;
                        top = oldRect.Top;
                        width = Math.Min(Math.Max(oldRect.Width - x_diff, width), max_width - left - small_offset);
                        height = Math.Min(Math.Max(oldRect.Height - y_diff, height), max_height - top - small_offset);
                    }


                    if (dragHandle > 0)
                    {
                        areaRect = new Rectangle(left, top, width, height);
                        apps[selectedAppIndex].reset(left, top, width, height);
                        this.Refresh();
                    }
                }
            }
        }

        private void panel10_MouseUp(object sender, MouseEventArgs e)
        {
            if ((int)Math.Min(curX, initialX) >= 1 && (int)Math.Abs(curX - initialX) <= panel10.Width - 1 && (int)Math.Abs(curX - initialX) > 30 &&
                (int)Math.Min(curY, initialY) >= 1 && (int)Math.Abs(curY - initialY) <= panel10.Height - 1 && (int)Math.Abs(curY - initialY) > 30)
            {
                Rectangle newRect = new Rectangle((int)Math.Min(curX, initialX), (int)Math.Min(curY, initialY), (int)Math.Abs(curX - initialX), (int)Math.Abs(curY - initialY));
                Boolean intersects = false;
                foreach(App app in apps)
                {
                    if(newRect.IntersectsWith(app.getRect()))
                        intersects = true;
                }
                if(!intersects) {
                    App newApp = new App((int)Math.Min(curX, initialX), (int)Math.Min(curY, initialY), (int)Math.Abs(curX - initialX), (int)Math.Abs(curY - initialY));
                    apps.Add(newApp);
                }
            }
            selectedAppIndex++;
            isDown = false;
            this.Refresh();

            appList.ClearSelected();
            dragHandle = 0;
        }

        private void nsTheme1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("KEY PRESSED: " + e.KeyChar);
            if (e.KeyChar == 'z')
            {
                Console.WriteLine("Z PRESSED");
                apps.RemoveAt(apps.Count - 1);
                this.Refresh();
            }

        }
        //RESIZING CODE
        private Point GetHandlePoint(int value)
        {
            Point result = Point.Empty;

            if (value == 1)
                result = new Point(areaRect.Left, areaRect.Top);
            else if (value == 2)
                result = new Point(areaRect.Left, areaRect.Top + (areaRect.Height / 2));
            else if (value == 3)
                result = new Point(areaRect.Left, areaRect.Bottom);
            else if (value == 4)
                result = new Point(areaRect.Left + (areaRect.Width / 2), areaRect.Top);
            else if (value == 5)
                result = new Point(areaRect.Left + (areaRect.Width / 2), areaRect.Bottom);
            else if (value == 6)
                result = new Point(areaRect.Right, areaRect.Top);
            else if (value == 7)
                result = new Point(areaRect.Right, areaRect.Top + (areaRect.Height / 2));
            else if (value == 8)
                result = new Point(areaRect.Right, areaRect.Bottom);

            return result;
        }

        private Rectangle GetHandleRect(int value)
        {
            Point p = GetHandlePoint(value);
            p.Offset(-3, -3);
            return new Rectangle(p, new Size(5, 5));
        }
    }
}
