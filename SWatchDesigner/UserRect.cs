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
        private PosSizableRect nodeSelected = PosSizableRect.None;
        private App parentApp;

        int FontSizeDefault = 80;
        int FontSizeMinimum = 4;
        Font DefaultFont;
        SolidBrush StringBrush = new SolidBrush(Color.Black);


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
            DefaultFont = new Font("Tahoma", FontSizeDefault, FontStyle.Regular);
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

            Font AdjustedFont = GetAdjustedFont(g, parentApp.getData(),
               DefaultFont, rect.Width, FontSizeDefault, FontSizeMinimum, true);

            SizeF AdjustedSizeNew = g.MeasureString(parentApp.getData(), AdjustedFont);
            g.DrawString(parentApp.getData(), AdjustedFont, StringBrush, parentApp.Center().X - AdjustedSizeNew.Width / 2, parentApp.Center().Y - AdjustedSizeNew.Height / 2);
          
        }

        public Font GetAdjustedFont(Graphics GraphicRef, string GraphicString, Font OriginalFont, int ContainerWidth, int MaxFontSize, int MinFontSize, bool SmallestOnFail)
        {
            // We utilize MeasureString which we get via a control instance           
            for (int AdjustedSize = MaxFontSize; AdjustedSize >= MinFontSize; AdjustedSize--)
            {
                Font TestFont = new Font(OriginalFont.Name, AdjustedSize, OriginalFont.Style);

                // Test the string with the new size
                SizeF AdjustedSizeNew = GraphicRef.MeasureString(GraphicString, TestFont);

                if (ContainerWidth > Convert.ToInt32(AdjustedSizeNew.Width))
                {
                    for (; AdjustedSize >= MinFontSize; AdjustedSize--)
                    {
                        TestFont = new Font(OriginalFont.Name, AdjustedSize, OriginalFont.Style);

                        // Test the string with the new size
                        AdjustedSizeNew = GraphicRef.MeasureString(GraphicString, TestFont);
                        if (rect.Height > Convert.ToInt32(AdjustedSizeNew.Height))
                            return TestFont;

                    }
                    // Good font, return it
                    //return TestFont;
                }
            }

            // If you get here there was no fontsize that worked
            // return MinimumSize or Original?
            if (SmallestOnFail)
            {
                return new Font(OriginalFont.Name, MinFontSize, OriginalFont.Style);
            }
            else
            {
                return OriginalFont;
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

            if (parentApp == null)
                ((IDisposable)this).Dispose();
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
            int panelOffset = 2;
            int panelMin = 1;
            int minWidth = parentApp.getMinWidth();
            int minHeight = rect.Width;
            switch (nodeSelected)
            {
                case PosSizableRect.LeftUp:
                    if ((rect.X + (e.X - oldX)) > panelMin)
                        rect.X += e.X - oldX;
                    if ((e.X - oldX) < panel.Width - panelOffset)
                        rect.Width -= e.X - oldX;                    
                    rect.Y += e.Y - oldY;
                    if ((e.Y - oldY) < panel.Height - panelOffset) 
                        rect.Height -= e.Y - oldY;
                    break;
                case PosSizableRect.LeftMiddle:
                    if ((rect.X + (e.X - oldX)) > panelMin)
                        rect.X += e.X - oldX;
                    if ((e.X - oldX) < panel.Width - panelOffset)
                        rect.Width -= e.X - oldX;
                    break;
                case PosSizableRect.LeftBottom:
                    if ((e.X - oldX) < panel.Width - panelOffset)
                        rect.Width -= e.X - oldX;
                    if ((rect.X + (e.X - oldX)) > panelMin)
                        rect.X += e.X - oldX;
                    if (rect.Y + rect.Height + (e.Y - oldY) < panel.Height - panelOffset) 
                        rect.Height += e.Y - oldY;
                    break;
                case PosSizableRect.BottomMiddle:
                    if (rect.Y + rect.Height + (e.Y - oldY) < panel.Height - panelOffset) 
                        rect.Height += e.Y - oldY;
                    break;
                case PosSizableRect.RightUp:
                    if (rect.X + rect.Width + (e.X - oldX) < panel.Width - panelOffset)
                        rect.Width += e.X - oldX;
                    rect.Y += e.Y - oldY;
                    if (rect.Height - (e.Y - oldY) < panel.Height - panelOffset) 
                        rect.Height -= e.Y - oldY;
                    break;
                case PosSizableRect.RightBottom:
                    if (rect.X + rect.Width + (e.X - oldX) < panel.Width - panelOffset)
                        rect.Width +=  e.X - oldX;
                    if (rect.Y + rect.Height + (e.Y - oldY) < panel.Height - panelOffset) 
                        rect.Height += e.Y - oldY;
                    break;
                case PosSizableRect.RightMiddle:
                    if (rect.X + rect.Width + (e.X - oldX) < panel.Width - panelOffset)
                        rect.Width += e.X - oldX;
                    break;

                case PosSizableRect.UpMiddle:
                    if (rect.Y + (e.Y - oldY) < panel.Height - panelOffset) 
                        rect.Y += e.Y - oldY;
                    if (rect.Height-(e.Y - oldY) < panel.Height - panelOffset)
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

        public void delete()
        {
            panel.MouseDown -= new MouseEventHandler(panel_MouseDown);
            panel.MouseUp -= new MouseEventHandler(panel_MouseUp);
            panel.MouseMove -= new MouseEventHandler(panel_MouseMove);
            panel.Paint -= new PaintEventHandler(panel_Paint);
        }
    }
}
