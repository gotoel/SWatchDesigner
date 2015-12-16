﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWatchDesigner
{
    class TimeApp : App
    {
        private const int MIN_WIDTH = 0;
        private const int MIN_HEIGHT = 0;
        private const string APP_NAME = "TIME";
        private const string APP_DATA = "00:00 PM";
        public TimeApp(int x, int y, int height, int width, PictureBox p) : base(x, y, height, width, p, MIN_WIDTH, MIN_HEIGHT, APP_NAME, APP_DATA)
        {
            
        }
    }
}
