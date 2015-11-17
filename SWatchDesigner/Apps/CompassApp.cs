using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWatchDesigner.Apps
{
    class CompassApp : App
    {
        public const int minWidth = 0;
        public const int minHeight = 0;
        public CompassApp(int x, int y, int height, int width, PictureBox p) : base(x, y, height, width, p, minWidth, minHeight)
        {
            
        }
    }
}
