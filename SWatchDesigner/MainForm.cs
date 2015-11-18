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
using System.IO;

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
        public Rectangle rect;
        public bool allowDeformingDuringMovement=false ;
        private bool mIsClick=false;
        private bool mMove=false;        
        private int oldX;
        private int oldY;
        private int sizeNodeRect= 5;
        private Bitmap mBmp=null;
        private PosSizableRect nodeSelected = PosSizableRect.None;
        private int angle = 30;

        //tooltips
        private bool watchScreenTT = false;

        private bool unsavedChanges = false;

        int selectedAppIndex = -1;
        int selectedLayoutIndex = 0;

        String appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        private enum PosSizableRect
        {            
            UpMiddle,
            LeftMiddle,
            LeftBottom,
            LeftUp,
            RightUp,
            RightMiddle,
            RightBottom,
            BottomMiddle,
            None

        };

        public MainForm()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            nsTheme1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.DoubleBuffered = true;

            if(!Directory.Exists(appdata + "\\.SWatch\\Templates\\"))
                Directory.CreateDirectory(appdata + "\\.SWatch\\Templates\\");
            foreach (string file in Directory.GetFiles(appdata + "\\.SWatch\\Templates", "*.txt"))
                nsTabControl1.TabPages.Add(Path.GetFileNameWithoutExtension(file));
            loadLayout(nsTabControl1.SelectedTab.Text);
            nsTabControl1.TabPages.Add("New layout");
            // Add available app names to the ListView.
            String[] apps = { "GPS", "Compass", "Time", "Weight", "Tracker", "Signal", "Weather", "Calendar", "WeatherAltitude" };
            Array.Sort(apps);
            foreach (String app in apps)
            {
                appList.AddItem(app);
            }

            //loadLayout("testTemplate");
        }

        private void loadLayout(String layoutName)
        {
            try
            {
                foreach (App a in apps)
                    a.delete();
                apps.Clear();
                StreamReader reader = File.OpenText(appdata + "\\.SWatch\\Templates\\" + layoutName + ".txt");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] items = line.Split('|');
                    // Now let's find the path.
                    foreach (string appSplit in items)
                    {
                        if (!String.IsNullOrWhiteSpace(appSplit))
                        {
                            Console.WriteLine("APPSPLIT: " + appSplit);
                            string[] data = appSplit.Split(',');
                            int x = Int32.Parse(data[0]); int y = Int32.Parse(data[1]);
                            int width = Int32.Parse(data[2]); int height = Int32.Parse(data[3]);
                            switch (data[4].Replace("\"", ""))
                            {
                                case "GPS":
                                    apps.Add(new GPSApp(x, y, width, height, panel10));
                                    break;
                                case "COMPASS":
                                    apps.Add(new CompassApp(x, y, width, height, panel10));
                                    break;
                                case "TIME":
                                    apps.Add(new TimeApp(x, y, width, height, panel10));
                                    break;
                                case "WEIGHT":
                                    apps.Add(new WeightApp(x, y, width, height, panel10));
                                    break;
                                case "TRACKER":
                                    apps.Add(new TrackerApp(x, y, width, height, panel10));
                                    break;
                                case "SIGNAL":
                                    apps.Add(new SignalApp(x, y, width, height, panel10));
                                    break;
                                case "WEATHER":
                                    apps.Add(new WeatherApp(x, y, width, height, panel10));
                                    break;
                                case "CALENDAR":
                                    apps.Add(new CalendarApp(x, y, width, height, panel10));
                                    break;
                                case "WEATHERALTITUDE":
                                    apps.Add(new WeatherAltitudeApp(x, y, width, height, panel10));
                                    break;
                                default:
                                    Console.WriteLine("Default case");
                                    break;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch { }
            finally
            {
                this.Refresh();
            }
        }

        private void saveLayout(String layoutName)
        {
            string data = "";
            foreach (App a in apps)
                data += a.getX() + "," + a.getY() + "," + a.getWidth() + "," + a.getHeight() + ",\"" + a.getName() + "\"|";
            File.WriteAllText(appdata + "\\.SWatch\\Templates\\" + layoutName + ".txt",data);
        }

        private void deleteLayout(String layoutName)
        {
            File.Delete(appdata + "\\.SWatch\\Templates\\" + layoutName + ".txt");
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
            if (unsavedChanges)
            {
                SaveDialog saveDialog = new SaveDialog();

                // Show testDialog as a modal dialog and determine if DialogResult = OK.
                if (saveDialog.ShowDialog(this) == DialogResult.OK)
                    saveLayout(nsTabControl1.TabPages[selectedLayoutIndex].Text);
                saveDialog.Dispose();
                unsavedChanges = false;
            }
            if (nsTabControl1.SelectedIndex == nsTabControl1.TabPages.Count-1)
            {
                // Display layout naming screen.
                NewLayoutDialog newLayoutDialog = new NewLayoutDialog();

   				// Show testDialog as a modal dialog and determine if DialogResult = OK.
   				if (newLayoutDialog.ShowDialog(this) == DialogResult.OK)
   				{
      				// Read the contents of testDialog's TextBox.
      				//this.txtResult.Text = newLayoutDialog.LayoutNameTxt.Text;
                    Console.WriteLine("OK, Layout name: " + newLayoutDialog.LayoutNameTxt.Text);
                    foreach (App a in apps)
                        a.delete();
                    apps.Clear();
                    saveLayout(newLayoutDialog.LayoutNameTxt.Text);
                    nsTabControl1.SelectedTab.Text = newLayoutDialog.LayoutNameTxt.Text;
                    nsTabControl1.TabPages.Add("New layout");
   				}
   				else
   				{
      				//this.txtResult.Text = "Cancelled";
      				Console.WriteLine("Cancelled");
                    nsTabControl1.SelectedIndex = nsTabControl1.SelectedIndex - 1;
                    //load previous tab/keep tab loaded
   				}
   				newLayoutDialog.Dispose();
   				Console.WriteLine("Continue");
            }
            else
            {
                loadLayout(nsTabControl1.SelectedTab.Text);

            }
            selectedLayoutIndex = nsTabControl1.SelectedIndex;
            Console.WriteLine("SELECTED LAYOUT INDEX: " + selectedLayoutIndex);
            this.Refresh();
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
            SolidBrush brush = new System.Drawing.SolidBrush(Color.FromArgb(128, 205, 150, 0)); //alpa, red, green, blue
            SolidBrush strBrush = new System.Drawing.SolidBrush(Color.Red);
            Pen pen = new System.Drawing.Pen(System.Drawing.Color.Tomato);
            Font font = new Font(new FontFamily("Consolas"), 9.0f);

            // draw grid
            int numOfCells = 20;
            int cellSize = 15;
            Pen p = new Pen(Color.Black);

            for (int y = 0; y < numOfCells; ++y)
            {
                formGraphics.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                formGraphics.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }

            if (isDown == true)
            {
                formGraphics.DrawString("X: " + curX + ", Y: " + curY, font, brush, curX, curY);
                Pen drwaPen = new Pen(Color.Navy, 1);
                int width = curX - initialX, height = curY - initialY;
                Rectangle app = new Rectangle((int)Math.Min(curX, initialX), (int)Math.Min(curY, initialY), (int)Math.Abs(curX - initialX), (int)Math.Abs(curY - initialY));
                Rectangle appBorder = new Rectangle((int)Math.Min(curX, initialX)-1, (int)Math.Min(curY, initialY)-1, (int)Math.Abs(curX - initialX)+1, (int)Math.Abs(curY - initialY)+1);
                
                formGraphics.DrawRectangle(pen, appBorder);
                formGraphics.FillRectangle(brush, app);
            }
            foreach (App a in apps)
            {
                Rectangle app = a.getRect();
                Rectangle appBorder = new Rectangle(a.getX() - 1, a.getY() - 1, a.getWidth() + 1, a.getHeight() + 1);

                formGraphics.DrawRectangle(pen, appBorder);
                formGraphics.FillRectangle(brush, app);

                Size proposedSize = new Size(int.MaxValue, int.MaxValue);
                String info = "X: " + a.getX() + ", Y: " + a.getY() + ", Width: " + a.getWidth() + ", Height: " + a.getHeight();
                //formGraphics.DrawString(info, font, strBrush, a.Center().X - TextRenderer.MeasureText(info,font, proposedSize).Width/2, a.Center().Y);
            }

            //formGraphics.DrawRectangle(new Pen(Color.Red),rect);
            //Console.WriteLine("APP INDEX: " + selectedAppIndex);
       
           
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
                    rect = app.getRect();
                    mIsClick = false;
                    selectedAppIndex = apps.IndexOf(app);
                    unsavedChanges = true;
                    app.isSelected = true;
                }
                else
                    app.isSelected = false;
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

                    this.Refresh();
                }
            }
        }

        private void panel10_MouseUp(object sender, MouseEventArgs e)
        {
            if ((int)Math.Min(curX, initialX) >= 1 && (int)Math.Abs(curX - initialX) <= panel10.Width - 1  &&
                (int)Math.Min(curY, initialY) >= 1 && (int)Math.Abs(curY - initialY) <= panel10.Height - 1)
            {
                Rectangle newRect = new Rectangle((int)Math.Min(curX, initialX), (int)Math.Min(curY, initialY), (int)Math.Abs(curX - initialX), (int)Math.Abs(curY - initialY));
                Boolean intersects = false;
                foreach(App app in apps)
                {
                    if(newRect.IntersectsWith(app.getRect()))
                        intersects = true;
                }
                if(!intersects) {
                    int x = (int)Math.Min(curX, initialX); int y = (int)Math.Min(curY, initialY);
                    int width = (int)Math.Abs(curX - initialX); int height = (int)Math.Abs(curY - initialY);
                    switch (appList.SelectedItems[0].Text.ToLower())
                    {
                        case "gps":
                            Console.WriteLine("NEW GPS APP!!!");
                            apps.Add(new GPSApp(x, y, width, height, panel10));
                            break;
                        case "compass":
                            apps.Add(new CompassApp(x, y, width, height, panel10));
                            break;
                        case "time":
                            apps.Add(new TimeApp(x, y, width, height, panel10));
                            break;
                        case "weight":
                            apps.Add(new WeightApp(x, y, width, height, panel10));
                            break;
                        case "tracker":
                            apps.Add(new TrackerApp(x, y, width, height, panel10));
                            break;
                        case "signal":
                            apps.Add(new SignalApp(x, y, width, height, panel10));
                            break;
                        case "weather":
                            apps.Add(new WeatherApp(x, y, width, height, panel10));
                            break;
                        case "calendar":
                            apps.Add(new CalendarApp(x, y, width, height, panel10));
                            break;
                        case "weatheraltitude":
                            apps.Add(new WeatherAltitudeApp(x, y, width, height, panel10));
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }
                    curX = 0; curY = 0; initialX = 0; initialY = 0;
                    selectedAppIndex++;
                    appList.ClearSelected();
                    if (!unsavedChanges)
                        unsavedChanges = true;
                }
            }
            isDown = false;
            this.Refresh();
        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("KEY PRESSED: " + e.KeyCode);
            if (e.KeyCode == Keys.Z)
            {
                Console.WriteLine("Z PRESSED");
                apps.RemoveAt(apps.Count - 1);
                this.Refresh();
            }
        }
        //RESIZING CODE


        public List<App> getApps() { return apps; }

        private void nsButton1_Click(object sender, EventArgs e)
        {
            if (selectedAppIndex > -1 && apps.Count() > 0)
            {
                apps[selectedAppIndex].delete();
                apps[selectedAppIndex] = null;
                apps.RemoveAt(selectedAppIndex);
                selectedAppIndex = -1;
                this.Refresh();
            }
        }

        private void panel10_MouseHover(object sender, EventArgs e)
        {
            if (!watchScreenTT)
            {
                ToolTip tip = new ToolTip();
                //tip.ShowAlways = true;
                tip.Show("This is the watch window!\nClick and drag to create an app space.", panel10, panel10.Location, 3000);
                watchScreenTT = true;
            }
        }

        private void saveLayoutBtn_Click(object sender, EventArgs e)
        {
            saveLayout(nsTabControl1.SelectedTab.Text);
            unsavedChanges = false;
        }

        private void deleteLayoutBtn_Click(object sender, EventArgs e)
        {
            DeleteDialog deleteDialog = new DeleteDialog();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (deleteDialog.ShowDialog(this) == DialogResult.OK)
            {
                deleteLayout(nsTabControl1.SelectedTab.Text);
                nsTabControl1.TabPages.RemoveAt(nsTabControl1.SelectedIndex);
                //nsTabControl1.DeselectTab(nsTabControl1.SelectedTab.Text);
                
            }
            else
            {
                Console.WriteLine("Cancelled");
            }
            deleteDialog.Dispose();
        }
    }
}
