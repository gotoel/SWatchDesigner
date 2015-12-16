using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWatchDesigner
{
    public partial class Splash : Form
    {
        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        int mState = 0;
        public Splash()
        {
            InitializeComponent();
            this.Opacity = 0.10;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 200;
            //timer1.Enabled = true;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 15;
            fade();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            
        }

        private async Task fade()
        {
            mState = 1;
            timer2.Enabled = true;
            await loadSleep();
            mState = -1;
            timer2.Enabled = true;
            await loadSleepTwo();
            MainForm newForm = new MainForm();
            newForm.Show();
            this.Hide();
        }

        void timer2_Tick(object sender, EventArgs e)
        {
            // Adjust opacity until end-value is reached
            double op = this.Opacity + mState * 0.01;
            timer2.Enabled = false;
            if (op >= 100) op = 100;
            else if (op < 0.10) op = 0.10;
            else timer2.Enabled = true;
            this.Opacity = op;
            if (!timer2.Enabled) mState = 0;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            Point pos = Control.MousePosition;
            bool inForm = pos.X >= Left && pos.Y >= Top && pos.X < Right && pos.Y < Bottom;
            if (inForm && mState <= 0)
            {
                // Fade in
                timer2.Enabled = true;
                mState = 1;
            }
            if (!inForm && mState >= 0)
            {
                // Fade out
                timer2.Enabled = true;
                mState = -1;
            }
        }

        public async Task loadSleep()
        {
            await Task.Delay(6000);
        }

        public async Task loadSleepTwo()
        {
            await Task.Delay(2000);
        }
    }
}
