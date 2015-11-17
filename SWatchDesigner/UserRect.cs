using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SWatchDesigner
{
    public class UserRect 
    {
        private PictureBox panel;
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
        private App parentApp;

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

        public UserRect(Rectangle r)
        {
            rect = r;
            mIsClick = false;
        }

        public void Draw(Graphics g)
        {            
            if(parentApp.isSelected)
            {
                g.DrawRectangle(new Pen(Color.Red),rect);
            
                foreach (PosSizableRect pos in Enum.GetValues(typeof(PosSizableRect)))
                {
                    g.DrawRectangle(new Pen(Color.Red),GetRect(pos));
                }     
            }      
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            
            try
            {
                Draw(e.Graphics);
            }
            catch (Exception exp)
            {
                System.Console.WriteLine(exp.Message);
            }
            
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            mIsClick = true;

            nodeSelected = PosSizableRect.None;
            nodeSelected = GetNodeSelectable(e.Location);
                
            if (rect.Contains(new Point(e.X,e.Y)))
            {
                mMove = true;                            
            }
            oldX = e.X;
            oldY = e.Y;
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            mIsClick = false;
            mMove = false;            
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            ChangeCursor(e.Location);
            if (mIsClick == false)
            {
                return;
            }

            Rectangle backupRect = rect;
            int panelOffset = 1; 
            switch (nodeSelected)
            {
                case PosSizableRect.LeftUp:
                    rect.X += e.X - oldX;
                    if ((e.X - oldX) < panel.Width - panelOffset)
                        rect.Width -= e.X - oldX;                    
                    rect.Y += e.Y - oldY;
                    if ((e.Y - oldY) < panel.Height - panelOffset) 
                        rect.Height -= e.Y - oldY;
                    break;
                case PosSizableRect.LeftMiddle:
                    rect.X += e.X - oldX;
                    if ((e.X - oldX) < panel.Width - panelOffset)
                        rect.Width -= e.X - oldX;
                    break;
                case PosSizableRect.LeftBottom:
                    if ((e.X - oldX) < panel.Width - panelOffset)
                        rect.Width -= e.X - oldX;
                    rect.X += e.X - oldX;
                    if ((e.Y - oldY) < panel.Height - panelOffset) 
                        rect.Height += e.Y - oldY;
                    break;
                case PosSizableRect.BottomMiddle:
                    if ((e.Y - oldY) < panel.Height - panelOffset) 
                        rect.Height += e.Y - oldY;
                    break;
                case PosSizableRect.RightUp:
                    if ((e.X - oldX) < panel.Width - panelOffset)
                        rect.Width += e.X - oldX;
                    rect.Y += e.Y - oldY;
                    if ((e.Y - oldY) < panel.Height - panelOffset) 
                        rect.Height -= e.Y - oldY;
                    break;
                case PosSizableRect.RightBottom:
                    if ((e.X - oldX) < panel.Width - panelOffset)
                        rect.Width +=  e.X - oldX;
                    if ((e.Y - oldY) < panel.Height - panelOffset) 
                        rect.Height += e.Y - oldY;
                    break;
                case PosSizableRect.RightMiddle:
                    if ((e.X - oldX) < panel.Width - panelOffset)
                        rect.Width += e.X - oldX;
                    break;

                case PosSizableRect.UpMiddle:
                    rect.Y += e.Y - oldY;
                    rect.Height -= e.Y - oldY;
                    break;

                default:
                    if (mMove)
                    {
                        if ((rect.X + e.X - oldX) + rect.Width < panel.Width - panelOffset)
                            rect.X = rect.X + e.X - oldX;
                        if ((rect.Y + e.Y - oldY) + rect.Height < panel.Height - panelOffset)    
                            rect.Y = rect.Y + e.Y - oldY;
                    }
                    break;
            }
            oldX = e.X;
            oldY = e.Y;

            if (rect.Width < 5 || rect.Height < 5)
            {
                rect = backupRect;
            }
            
            //check intersecting
            foreach(App a in parentApp.getOtherApps())
            {
                if(rect.IntersectsWith(a.getRect()))
                    rect = backupRect;
            }

            TestIfRectInsideArea();

            panel.Invalidate();
        }

        private void TestIfRectInsideArea()
        {
            // Test if rectangle still inside the area.
            if (rect.X < 1) rect.X = 1;
            if (rect.Y < 1) rect.Y = 1;
            if (rect.Width <= 0) rect.Width = 1;
            if (rect.Height <= 0) rect.Height = 1;

            if (rect.X + rect.Width > panel.Width-1)
            {
                rect.Width = panel.Width - rect.X - 1; // -1 to be still show 
                if (allowDeformingDuringMovement == false)
                {
                    mIsClick = false;
                }
            }
            if (rect.Y + rect.Height > panel.Height-1)
            {
                rect.Height = panel.Height - rect.Y - 1;// -1 to be still show 
                if (allowDeformingDuringMovement == false)
                {
                    mIsClick = false;
                }
            }
        }        

        private Rectangle CreateRectSizableNode(int x, int y)
        {
            return new Rectangle(x - sizeNodeRect / 2, y - sizeNodeRect / 2, sizeNodeRect, sizeNodeRect);   
        }

        private Rectangle GetRect(PosSizableRect p)
        {
            switch (p)
            {
                case PosSizableRect.LeftUp:
                    return CreateRectSizableNode(rect.X, rect.Y);
                 
                case PosSizableRect.LeftMiddle:
                    return CreateRectSizableNode(rect.X, rect.Y + +rect.Height / 2);                    

                case PosSizableRect.LeftBottom:
                    return CreateRectSizableNode(rect.X, rect.Y +rect.Height);                                   

                case PosSizableRect.BottomMiddle:
                    return CreateRectSizableNode(rect.X  + rect.Width / 2,rect.Y + rect.Height);

                case PosSizableRect.RightUp:
                    return CreateRectSizableNode(rect.X + rect.Width,rect.Y );

                case PosSizableRect.RightBottom:
                    return CreateRectSizableNode(rect.X  + rect.Width,rect.Y  + rect.Height);

                case PosSizableRect.RightMiddle:
                    return CreateRectSizableNode(rect.X  + rect.Width, rect.Y  + rect.Height / 2);

                case PosSizableRect.UpMiddle:
                    return CreateRectSizableNode(rect.X + rect.Width/2, rect.Y);
                default :
                    return new Rectangle();
            }
        }

        private PosSizableRect GetNodeSelectable(Point p)
        {
           foreach (PosSizableRect r in Enum.GetValues(typeof(PosSizableRect)))
            {
                if (GetRect(r).Contains(p))
                {
                    return r;                    
                }
            }
            return PosSizableRect.None;
        }

        private void ChangeCursor(Point p)
        {
             panel.Cursor = GetCursor(GetNodeSelectable(p));
        }

        /// <summary>
        /// Get cursor for the handle
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private Cursor GetCursor(PosSizableRect p)
        {
            switch (p)
            {
                case PosSizableRect.LeftUp:
                    return Cursors.SizeNWSE;               

                case PosSizableRect.LeftMiddle:
                    return Cursors.SizeWE;

                case PosSizableRect.LeftBottom:
                    return Cursors.SizeNESW;

                case PosSizableRect.BottomMiddle:
                    return Cursors.SizeNS;

                case PosSizableRect.RightUp:
                    return Cursors.SizeNESW;

                case PosSizableRect.RightBottom:
                    return Cursors.SizeNWSE;

                case PosSizableRect.RightMiddle:
                    return Cursors.SizeWE;

                case PosSizableRect.UpMiddle:
                    return Cursors.SizeNS;
                default:
                    return Cursors.Default;
            }
        }
        public void SetPictureBox(PictureBox p)
        {
            this.panel = p;
            panel.MouseDown += new MouseEventHandler(panel_MouseDown);
            panel.MouseUp += new MouseEventHandler(panel_MouseUp);
            panel.MouseMove += new MouseEventHandler(panel_MouseMove);
            panel.Paint += new PaintEventHandler(panel_Paint);
        }

        public void SetApp(App a)
        {
            this.parentApp = a;
        }

        public Rectangle getRect()
        {
            return rect;
        }
    }
}
