using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWatchDesigner
{
    public class GPSApp : App
    {
        private const int MIN_WIDTH = 0;
        private const int MIN_HEIGHT = 0;
        private const string APP_NAME = "GPS";
        private const string APP_DATA = "Latitude:\n" +
                                        "N257°26'44.82\n" +
                                        "Longitude:\n" +
                                        "W159°41'27.48\n" +
                                        "Alt: 141 ft\n" +
                                        "Sat: 6/12";
        public GPSApp(int x, int y, int height, int width, PictureBox p) : base(x, y, height, width, p, MIN_WIDTH, MIN_HEIGHT, APP_NAME, APP_DATA)
        {
            
        }
    }
}
