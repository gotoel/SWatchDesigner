﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWatchDesigner
{
    class WeightApp : App
    {
        public const int MIN_WIDTH = 0;
        public const int MIN_HEIGHT = 0;
        public const string APP_NAME = "WEIGHT";
        private const string APP_DATA = "";
        public WeightApp(int x, int y, int height, int width, PictureBox p) : base(x, y, height, width, p, MIN_WIDTH, MIN_HEIGHT, APP_NAME, APP_DATA)
        {
            
        }
    }
}
