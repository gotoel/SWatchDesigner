using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SWatchDesigner
{
    public class App
    {
        private int x, y, minWidth, minHeight;
        private int height, width;
        private int mode;
        private UserRect rect;
        private PictureBox parentPanel;
        public Boolean isSelected;

        public App(int x, int y, int width, int height, PictureBox p)
        {
            this.isSelected = false;
            this.rect = new UserRect(new Rectangle(x, y, width, height));
            this.rect.SetPictureBox(p);
            this.rect.SetApp(this);
            this.parentPanel = p;
        }

        public App(int x, int y, int width, int height, PictureBox p, int minWidth, int minHeight)
        {
            this.isSelected = false;
            this.rect = new UserRect(new Rectangle(x, y, width, height));
            this.rect.SetPictureBox(p);
            this.rect.SetApp(this);
            this.parentPanel = p;
            this.minWidth = minWidth;
            this.minHeight = minHeight;
        }

        public void setX(int x) { this.x = x; }
        public void setY(int y) { this.y = y; }
        public void setWidth(int width) { this.width = width; }
        public void setHeight(int height) { this.height = height; }

        public int getX() { return rect.getRect().X; }
        public int getY() { return rect.getRect().Y; }
        public int getWidth() { return rect.getRect().Width; }
        public int getHeight() { return rect.getRect().Height; }
        public int getMinWidth() { return minWidth; }
        public int getMinHeight() { return minHeight; }
        public Rectangle getRect() { return rect.getRect();  }

        public void reset(int x, int y, int width, int height)
        {
            this.x = x; this.y = y; this.height = height; this.width = width;
        }

        //public void setRect(Rectangle rect) { this.rect = rect; }

        public Point Center()
        {
            return new Point(getRect().Left + getRect().Width / 2,
                             getRect().Top + getRect().Height / 2);
        }

        public List<App> getOtherApps()
        {
            List<App> otherApps = new List<App>();
            foreach(App a in ((MainForm)parentPanel.FindForm()).getApps()){
                if (a != this)
                    otherApps.Add(a);
            }
            return otherApps;
        }

        public void delete()
        {
            rect.delete();
            rect = null;
        }
    }
}
