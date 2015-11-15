using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SWatchDesigner
{
    class App
    {
        private int x, y;
        private int height, width;
        private int mode;
        public App(int x, int y, int width, int height)
        {
            this.x = x; this.y = y; this.height = height; this.width = width;
        }

        public void setX(int x) { this.x = x; }
        public void setY(int y) { this.y = y; }
        public void setWidth(int width) { this.width = width; }
        public void setHeight(int height) { this.height = height; }

        public int getX() { return x; }
        public int getY() { return y; }
        public int getWidth() { return width; }
        public int getHeight() { return height; }
        public Rectangle getRect() { return new Rectangle(getX(), getY(), getWidth(), getHeight());  }

        public void reset(int x, int y, int width, int height)
        {
            this.x = x; this.y = y; this.height = height; this.width = width;
        }

        public Point Center()
        {
            return new Point(getRect().Left + getRect().Width / 2,
                             getRect().Top + getRect().Height / 2);
        }
    }
}
