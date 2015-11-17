namespace SWatchDesigner
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nsTheme1 = new NSTheme();
            this.nsTabControl1 = new NSTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.nsGroupBox7 = new NSGroupBox();
            this.panel10 = new System.Windows.Forms.PictureBox();
            this.nsGroupBox8 = new NSGroupBox();
            this.nsTextBox4 = new NSTextBox();
            this.custEmergencyLbl = new MonoFlat.MonoFlat_Label();
            this.nsOnOffBox3 = new NSOnOffBox();
            this.RFIDLbl = new MonoFlat.MonoFlat_Label();
            this.nsGroupBox9 = new NSGroupBox();
            this.appList = new NSListView();
            this.nsGroupBox10 = new NSGroupBox();
            this.nsControlButton3 = new NSControlButton();
            this.nsControlButton2 = new NSControlButton();
            this.nsControlButton1 = new NSControlButton();
            this.nsLabel1 = new NSLabel();
            this.nsTheme1.SuspendLayout();
            this.nsTabControl1.SuspendLayout();
            this.nsGroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel10)).BeginInit();
            this.nsGroupBox8.SuspendLayout();
            this.nsGroupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.Controls.Add(this.nsTabControl1);
            this.nsTheme1.Controls.Add(this.nsGroupBox7);
            this.nsTheme1.Controls.Add(this.nsControlButton3);
            this.nsTheme1.Controls.Add(this.nsControlButton2);
            this.nsTheme1.Controls.Add(this.nsControlButton1);
            this.nsTheme1.Controls.Add(this.nsLabel1);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = false;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = false;
            this.nsTheme1.Size = new System.Drawing.Size(713, 517);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 1;
            this.nsTheme1.Text = "nsTheme1";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            this.nsTheme1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            this.nsTheme1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nsTheme1_KeyPress);
            this.nsTheme1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsTheme1_MouseDown);
            this.nsTheme1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsTheme1_MouseMove);
            // 
            // nsTabControl1
            // 
            this.nsTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.nsTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsTabControl1.Controls.Add(this.tabPage1);
            this.nsTabControl1.Controls.Add(this.tabPage2);
            this.nsTabControl1.Controls.Add(this.tabPage3);
            this.nsTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.nsTabControl1.ItemSize = new System.Drawing.Size(28, 115);
            this.nsTabControl1.Location = new System.Drawing.Point(12, 42);
            this.nsTabControl1.Multiline = true;
            this.nsTabControl1.Name = "nsTabControl1";
            this.nsTabControl1.SelectedIndex = 0;
            this.nsTabControl1.Size = new System.Drawing.Size(116, 463);
            this.nsTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.nsTabControl1.TabIndex = 5;
            this.nsTabControl1.SelectedIndexChanged += new System.EventHandler(this.nsTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Location = new System.Drawing.Point(119, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Survival";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage2.Location = new System.Drawing.Point(119, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Casual";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage3.Location = new System.Drawing.Point(119, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(0, 455);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "New layout";
            // 
            // nsGroupBox7
            // 
            this.nsGroupBox7.Controls.Add(this.panel10);
            this.nsGroupBox7.Controls.Add(this.nsGroupBox8);
            this.nsGroupBox7.Controls.Add(this.nsGroupBox9);
            this.nsGroupBox7.Controls.Add(this.nsGroupBox10);
            this.nsGroupBox7.DrawSeperator = false;
            this.nsGroupBox7.Location = new System.Drawing.Point(126, 29);
            this.nsGroupBox7.Name = "nsGroupBox7";
            this.nsGroupBox7.Size = new System.Drawing.Size(623, 476);
            this.nsGroupBox7.SubTitle = "";
            this.nsGroupBox7.TabIndex = 6;
            this.nsGroupBox7.Text = "nsGroupBox7";
            this.nsGroupBox7.Title = "";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(23, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(302, 302);
            this.panel10.TabIndex = 25;
            this.panel10.TabStop = false;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel10_MouseDown);
            this.panel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel10_MouseMove);
            this.panel10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel10_MouseUp);
            // 
            // nsGroupBox8
            // 
            this.nsGroupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsGroupBox8.Controls.Add(this.nsTextBox4);
            this.nsGroupBox8.Controls.Add(this.custEmergencyLbl);
            this.nsGroupBox8.Controls.Add(this.nsOnOffBox3);
            this.nsGroupBox8.Controls.Add(this.RFIDLbl);
            this.nsGroupBox8.DrawSeperator = true;
            this.nsGroupBox8.Location = new System.Drawing.Point(23, 317);
            this.nsGroupBox8.Name = "nsGroupBox8";
            this.nsGroupBox8.Size = new System.Drawing.Size(302, 146);
            this.nsGroupBox8.SubTitle = "Miscellaneous settings.";
            this.nsGroupBox8.TabIndex = 24;
            this.nsGroupBox8.Text = "nsGroupBox3";
            this.nsGroupBox8.Title = "Misc.";
            // 
            // nsTextBox4
            // 
            this.nsTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsTextBox4.Location = new System.Drawing.Point(7, 95);
            this.nsTextBox4.MaxLength = 32767;
            this.nsTextBox4.Multiline = false;
            this.nsTextBox4.Name = "nsTextBox4";
            this.nsTextBox4.ReadOnly = false;
            this.nsTextBox4.Size = new System.Drawing.Size(290, 42);
            this.nsTextBox4.TabIndex = 3;
            this.nsTextBox4.Text = "I need rescue at $.GPSCoord.";
            this.nsTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nsTextBox4.UseSystemPasswordChar = false;
            // 
            // custEmergencyLbl
            // 
            this.custEmergencyLbl.AutoSize = true;
            this.custEmergencyLbl.BackColor = System.Drawing.Color.Transparent;
            this.custEmergencyLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.custEmergencyLbl.ForeColor = System.Drawing.Color.White;
            this.custEmergencyLbl.Location = new System.Drawing.Point(4, 76);
            this.custEmergencyLbl.Name = "custEmergencyLbl";
            this.custEmergencyLbl.Size = new System.Drawing.Size(136, 15);
            this.custEmergencyLbl.TabIndex = 2;
            this.custEmergencyLbl.Text = "Custom emergency text:";
            // 
            // nsOnOffBox3
            // 
            this.nsOnOffBox3.Checked = true;
            this.nsOnOffBox3.Location = new System.Drawing.Point(78, 46);
            this.nsOnOffBox3.MaximumSize = new System.Drawing.Size(56, 24);
            this.nsOnOffBox3.MinimumSize = new System.Drawing.Size(56, 24);
            this.nsOnOffBox3.Name = "nsOnOffBox3";
            this.nsOnOffBox3.Size = new System.Drawing.Size(56, 24);
            this.nsOnOffBox3.TabIndex = 1;
            this.nsOnOffBox3.Text = "nsOnOffBox1";
            // 
            // RFIDLbl
            // 
            this.RFIDLbl.AutoSize = true;
            this.RFIDLbl.BackColor = System.Drawing.Color.Transparent;
            this.RFIDLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RFIDLbl.ForeColor = System.Drawing.Color.White;
            this.RFIDLbl.Location = new System.Drawing.Point(4, 49);
            this.RFIDLbl.Name = "RFIDLbl";
            this.RFIDLbl.Size = new System.Drawing.Size(71, 15);
            this.RFIDLbl.TabIndex = 0;
            this.RFIDLbl.Text = "RFID toggle:";
            // 
            // nsGroupBox9
            // 
            this.nsGroupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsGroupBox9.Controls.Add(this.appList);
            this.nsGroupBox9.DrawSeperator = true;
            this.nsGroupBox9.Location = new System.Drawing.Point(338, 13);
            this.nsGroupBox9.Name = "nsGroupBox9";
            this.nsGroupBox9.Size = new System.Drawing.Size(227, 301);
            this.nsGroupBox9.SubTitle = "Select an app to add.";
            this.nsGroupBox9.TabIndex = 23;
            this.nsGroupBox9.Text = "nsGroupBox2";
            this.nsGroupBox9.Title = "App selection";
            // 
            // appList
            // 
            this.appList.Columns = new NSListView.NSListViewColumnHeader[0];
            this.appList.Items = new NSListView.NSListViewItem[0];
            this.appList.Location = new System.Drawing.Point(3, 42);
            this.appList.MultiSelect = false;
            this.appList.Name = "appList";
            this.appList.Size = new System.Drawing.Size(213, 256);
            this.appList.TabIndex = 0;
            this.appList.Text = "nsListView1";
            // 
            // nsGroupBox10
            // 
            this.nsGroupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nsGroupBox10.DrawSeperator = true;
            this.nsGroupBox10.Location = new System.Drawing.Point(338, 317);
            this.nsGroupBox10.Name = "nsGroupBox10";
            this.nsGroupBox10.Size = new System.Drawing.Size(227, 146);
            this.nsGroupBox10.SubTitle = "View and change the selected app.";
            this.nsGroupBox10.TabIndex = 22;
            this.nsGroupBox10.Text = "nsGroupBox1";
            this.nsGroupBox10.Title = "Selection controls";
            // 
            // nsControlButton3
            // 
            this.nsControlButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton3.ControlButton = NSControlButton.Button.Minimize;
            this.nsControlButton3.Location = new System.Drawing.Point(645, 6);
            this.nsControlButton3.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton3.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton3.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton3.Name = "nsControlButton3";
            this.nsControlButton3.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton3.TabIndex = 3;
            this.nsControlButton3.Text = "nsControlButton3";
            // 
            // nsControlButton2
            // 
            this.nsControlButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton2.ControlButton = NSControlButton.Button.MaximizeRestore;
            this.nsControlButton2.Enabled = false;
            this.nsControlButton2.Location = new System.Drawing.Point(663, 6);
            this.nsControlButton2.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton2.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton2.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton2.Name = "nsControlButton2";
            this.nsControlButton2.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton2.TabIndex = 2;
            this.nsControlButton2.Text = "nsControlButton2";
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.ControlButton = NSControlButton.Button.Close;
            this.nsControlButton1.Location = new System.Drawing.Point(681, 6);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 1;
            this.nsControlButton1.Text = "nsControlButton1";
            // 
            // nsLabel1
            // 
            this.nsLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel1.Location = new System.Drawing.Point(7, 3);
            this.nsLabel1.Name = "nsLabel1";
            this.nsLabel1.Size = new System.Drawing.Size(67, 23);
            this.nsLabel1.TabIndex = 0;
            this.nsLabel1.Text = "yest";
            this.nsLabel1.Value1 = "S";
            this.nsLabel1.Value2 = "Watch";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 517);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nsTheme1_KeyPress);
            this.nsTheme1.ResumeLayout(false);
            this.nsTabControl1.ResumeLayout(false);
            this.nsGroupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel10)).EndInit();
            this.nsGroupBox8.ResumeLayout(false);
            this.nsGroupBox8.PerformLayout();
            this.nsGroupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme1;
        private NSTabControl nsTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private NSControlButton nsControlButton3;
        private NSControlButton nsControlButton2;
        private NSControlButton nsControlButton1;
        private NSLabel nsLabel1;
        private NSGroupBox nsGroupBox7;
        private NSGroupBox nsGroupBox8;
        private NSTextBox nsTextBox4;
        private MonoFlat.MonoFlat_Label custEmergencyLbl;
        private NSOnOffBox nsOnOffBox3;
        private MonoFlat.MonoFlat_Label RFIDLbl;
        private NSGroupBox nsGroupBox9;
        private NSListView appList;
        private NSGroupBox nsGroupBox10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox panel10;
    }
}