﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWatchDesigner
{
    class WeatherAltitudeApp : App
    {
        private const int MIN_WIDTH = 0;
        private const int MIN_HEIGHT = 0;
        private const string APP_NAME = "WEATHERALTITUDE";
        private const string APP_DATA = "";
        public WeatherAltitudeApp(int x, int y, int height, int width, PictureBox p) : base(x, y, height, width, p, MIN_WIDTH, MIN_HEIGHT, APP_NAME, APP_DATA)
        {
            
        }
    }
}
