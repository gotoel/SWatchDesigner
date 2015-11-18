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
            this.nsGroupBox3 = new NSGroupBox();
            this.nsGroupBox2 = new NSGroupBox();
            this.renameLayoutBtn = new NSButton();
            this.deleteLayoutBtn = new NSButton();
            this.saveLayoutBtn = new NSButton();
            this.nsGroupBox1 = new NSGroupBox();
            this.monoFlat_Label5 = new MonoFlat.MonoFlat_Label();
            this.nsTextBox6 = new NSTextBox();
            this.monoFlat_Label4 = new MonoFlat.MonoFlat_Label();
            this.nsTextBox5 = new NSTextBox();
            this.monoFlat_Label3 = new MonoFlat.MonoFlat_Label();
            this.nsTextBox3 = new NSTextBox();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.nsTextBox2 = new NSTextBox();
            this.nsTextBox1 = new NSTextBox();
            this.nsGroupBox7 = new NSGroupBox();
            this.nsTabControl1 = new NSTabControl();
            this.panel10 = new System.Windows.Forms.PictureBox();
            this.nsGroupBox8 = new NSGroupBox();
            this.nsTextBox4 = new NSTextBox();
            this.custEmergencyLbl = new MonoFlat.MonoFlat_Label();
            this.nsOnOffBox3 = new NSOnOffBox();
            this.RFIDLbl = new MonoFlat.MonoFlat_Label();
            this.nsGroupBox9 = new NSGroupBox();
            this.appList = new NSListView();
            this.nsGroupBox10 = new NSGroupBox();
            this.nsButton1 = new NSButton();
            this.nsControlButton3 = new NSControlButton();
            this.nsControlButton2 = new NSControlButton();
            this.nsControlButton1 = new NSControlButton();
            this.nsLabel1 = new NSLabel();
            this.nsContextMenu1 = new NSContextMenu();
            this.nsContextMenu2 = new NSContextMenu();
            this.nsTheme1.SuspendLayout();
            this.nsGroupBox2.SuspendLayout();
            this.nsGroupBox1.SuspendLayout();
            this.nsGroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel10)).BeginInit();
            this.nsGroupBox8.SuspendLayout();
            this.nsGroupBox9.SuspendLayout();
            this.nsGroupBox10.SuspendLayout();
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
            this.nsTheme1.Controls.Add(this.nsGroupBox3);
            this.nsTheme1.Controls.Add(this.nsGroupBox2);
            this.nsTheme1.Controls.Add(this.nsGroupBox1);
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
            this.nsTheme1.Size = new System.Drawing.Size(645, 663);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 1;
            this.nsTheme1.Text = "nsTheme1";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            this.nsTheme1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            this.nsTheme1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsTheme1_MouseDown);
            this.nsTheme1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsTheme1_MouseMove);
            // 
            // nsGroupBox3
            // 
            this.nsGroupBox3.DrawSeperator = true;
            this.nsGroupBox3.Location = new System.Drawing.Point(516, 33);
            this.nsGroupBox3.Name = "nsGroupBox3";
            this.nsGroupBox3.Size = new System.Drawing.Size(121, 139);
            this.nsGroupBox3.SubTitle = "";
            this.nsGroupBox3.TabIndex = 9;
            this.nsGroupBox3.Text = "nsGroupBox3";
            this.nsGroupBox3.Title = "USB Status";
            // 
            // nsGroupBox2
            // 
            this.nsGroupBox2.Controls.Add(this.renameLayoutBtn);
            this.nsGroupBox2.Controls.Add(this.deleteLayoutBtn);
            this.nsGroupBox2.Controls.Add(this.saveLayoutBtn);
            this.nsGroupBox2.DrawSeperator = true;
            this.nsGroupBox2.Location = new System.Drawing.Point(7, 34);
            this.nsGroupBox2.Name = "nsGroupBox2";
            this.nsGroupBox2.Size = new System.Drawing.Size(190, 138);
            this.nsGroupBox2.SubTitle = "Settings/controls for current layout.";
            this.nsGroupBox2.TabIndex = 8;
            this.nsGroupBox2.Text = "nsGroupBox2";
            this.nsGroupBox2.Title = "Layout settings";
            // 
            // renameLayoutBtn
            // 
            this.renameLayoutBtn.Location = new System.Drawing.Point(4, 100);
            this.renameLayoutBtn.Name = "renameLayoutBtn";
            this.renameLayoutBtn.Size = new System.Drawing.Size(101, 23);
            this.renameLayoutBtn.TabIndex = 2;
            this.renameLayoutBtn.Text = "Rename layout";
            // 
            // deleteLayoutBtn
            // 
            this.deleteLayoutBtn.Location = new System.Drawing.Point(5, 71);
            this.deleteLayoutBtn.Name = "deleteLayoutBtn";
            this.deleteLayoutBtn.Size = new System.Drawing.Size(95, 23);
            this.deleteLayoutBtn.TabIndex = 1;
            this.deleteLayoutBtn.Text = "Delete layout";
            this.deleteLayoutBtn.Click += new System.EventHandler(this.deleteLayoutBtn_Click);
            // 
            // saveLayoutBtn
            // 
            this.saveLayoutBtn.Location = new System.Drawing.Point(5, 42);
            this.saveLayoutBtn.Name = "saveLayoutBtn";
            this.saveLayoutBtn.Size = new System.Drawing.Size(95, 23);
            this.saveLayoutBtn.TabIndex = 0;
            this.saveLayoutBtn.Text = "Save layout";
            this.saveLayoutBtn.Click += new System.EventHandler(this.saveLayoutBtn_Click);
            // 
            // nsGroupBox1
            // 
            this.nsGroupBox1.Controls.Add(this.monoFlat_Label5);
            this.nsGroupBox1.Controls.Add(this.nsTextBox6);
            this.nsGroupBox1.Controls.Add(this.monoFlat_Label4);
            this.nsGroupBox1.Controls.Add(this.nsTextBox5);
            this.nsGroupBox1.Controls.Add(this.monoFlat_Label3);
            this.nsGroupBox1.Controls.Add(this.nsTextBox3);
            this.nsGroupBox1.Controls.Add(this.monoFlat_Label2);
            this.nsGroupBox1.Controls.Add(this.monoFlat_Label1);
            this.nsGroupBox1.Controls.Add(this.nsTextBox2);
            this.nsGroupBox1.Controls.Add(this.nsTextBox1);
            this.nsGroupBox1.DrawSeperator = true;
            this.nsGroupBox1.Location = new System.Drawing.Point(203, 34);
            this.nsGroupBox1.Name = "nsGroupBox1";
            this.nsGroupBox1.Size = new System.Drawing.Size(307, 138);
            this.nsGroupBox1.SubTitle = "";
            this.nsGroupBox1.TabIndex = 7;
            this.nsGroupBox1.Text = "nsGroupBox1";
            this.nsGroupBox1.Title = "Watch info";
            // 
            // monoFlat_Label5
            // 
            this.monoFlat_Label5.AutoSize = true;
            this.monoFlat_Label5.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.monoFlat_Label5.Location = new System.Drawing.Point(147, 47);
            this.monoFlat_Label5.Name = "monoFlat_Label5";
            this.monoFlat_Label5.Size = new System.Drawing.Size(70, 14);
            this.monoFlat_Label5.TabIndex = 11;
            this.monoFlat_Label5.Text = "Satellites:";
            // 
            // nsTextBox6
            // 
            this.nsTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsTextBox6.Enabled = false;
            this.nsTextBox6.Location = new System.Drawing.Point(218, 42);
            this.nsTextBox6.MaxLength = 32767;
            this.nsTextBox6.Multiline = false;
            this.nsTextBox6.Name = "nsTextBox6";
            this.nsTextBox6.ReadOnly = false;
            this.nsTextBox6.Size = new System.Drawing.Size(81, 23);
            this.nsTextBox6.TabIndex = 10;
            this.nsTextBox6.Text = "3/12";
            this.nsTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nsTextBox6.UseSystemPasswordChar = false;
            // 
            // monoFlat_Label4
            // 
            this.monoFlat_Label4.AutoSize = true;
            this.monoFlat_Label4.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.monoFlat_Label4.Location = new System.Drawing.Point(29, 115);
            this.monoFlat_Label4.Name = "monoFlat_Label4";
            this.monoFlat_Label4.Size = new System.Drawing.Size(35, 14);
            this.monoFlat_Label4.TabIndex = 9;
            this.monoFlat_Label4.Text = "SIM:";
            // 
            // nsTextBox5
            // 
            this.nsTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsTextBox5.Enabled = false;
            this.nsTextBox5.Location = new System.Drawing.Point(66, 111);
            this.nsTextBox5.MaxLength = 32767;
            this.nsTextBox5.Multiline = false;
            this.nsTextBox5.Name = "nsTextBox5";
            this.nsTextBox5.ReadOnly = false;
            this.nsTextBox5.Size = new System.Drawing.Size(81, 23);
            this.nsTextBox5.TabIndex = 8;
            this.nsTextBox5.Text = "AT&T";
            this.nsTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nsTextBox5.UseSystemPasswordChar = false;
            // 
            // monoFlat_Label3
            // 
            this.monoFlat_Label3.AutoSize = true;
            this.monoFlat_Label3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.monoFlat_Label3.Location = new System.Drawing.Point(2, 92);
            this.monoFlat_Label3.Name = "monoFlat_Label3";
            this.monoFlat_Label3.Size = new System.Drawing.Size(63, 14);
            this.monoFlat_Label3.TabIndex = 7;
            this.monoFlat_Label3.Text = "SD Card:";
            // 
            // nsTextBox3
            // 
            this.nsTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsTextBox3.Enabled = false;
            this.nsTextBox3.Location = new System.Drawing.Point(66, 88);
            this.nsTextBox3.MaxLength = 32767;
            this.nsTextBox3.Multiline = false;
            this.nsTextBox3.Name = "nsTextBox3";
            this.nsTextBox3.ReadOnly = false;
            this.nsTextBox3.Size = new System.Drawing.Size(81, 23);
            this.nsTextBox3.TabIndex = 6;
            this.nsTextBox3.Text = "0.7GB / 2GB";
            this.nsTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nsTextBox3.UseSystemPasswordChar = false;
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.monoFlat_Label2.Location = new System.Drawing.Point(6, 69);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(59, 14);
            this.monoFlat_Label2.TabIndex = 5;
            this.monoFlat_Label2.Text = "Version:";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(16, 47);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(49, 14);
            this.monoFlat_Label1.TabIndex = 4;
            this.monoFlat_Label1.Text = "Model:";
            // 
            // nsTextBox2
            // 
            this.nsTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsTextBox2.Enabled = false;
            this.nsTextBox2.Location = new System.Drawing.Point(66, 65);
            this.nsTextBox2.MaxLength = 32767;
            this.nsTextBox2.Multiline = false;
            this.nsTextBox2.Name = "nsTextBox2";
            this.nsTextBox2.ReadOnly = false;
            this.nsTextBox2.Size = new System.Drawing.Size(81, 23);
            this.nsTextBox2.TabIndex = 3;
            this.nsTextBox2.Text = "1.0013";
            this.nsTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nsTextBox2.UseSystemPasswordChar = false;
            // 
            // nsTextBox1
            // 
            this.nsTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsTextBox1.Enabled = false;
            this.nsTextBox1.Location = new System.Drawing.Point(66, 42);
            this.nsTextBox1.MaxLength = 32767;
            this.nsTextBox1.Multiline = false;
            this.nsTextBox1.Name = "nsTextBox1";
            this.nsTextBox1.ReadOnly = false;
            this.nsTextBox1.Size = new System.Drawing.Size(81, 23);
            this.nsTextBox1.TabIndex = 1;
            this.nsTextBox1.Text = "SWatch-One";
            this.nsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nsTextBox1.UseSystemPasswordChar = false;
            // 
            // nsGroupBox7
            // 
            this.nsGroupBox7.Controls.Add(this.nsTabControl1);
            this.nsGroupBox7.Controls.Add(this.panel10);
            this.nsGroupBox7.Controls.Add(this.nsGroupBox8);
            this.nsGroupBox7.Controls.Add(this.nsGroupBox9);
            this.nsGroupBox7.Controls.Add(this.nsGroupBox10);
            this.nsGroupBox7.DrawSeperator = false;
            this.nsGroupBox7.Location = new System.Drawing.Point(7, 178);
            this.nsGroupBox7.Name = "nsGroupBox7";
            this.nsGroupBox7.Size = new System.Drawing.Size(630, 480);
            this.nsGroupBox7.SubTitle = "";
            this.nsGroupBox7.TabIndex = 6;
            this.nsGroupBox7.Text = "nsGroupBox7";
            this.nsGroupBox7.Title = "";
            // 
            // nsTabControl1
            // 
            this.nsTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.nsTabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nsTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.nsTabControl1.ItemSize = new System.Drawing.Size(28, 115);
            this.nsTabControl1.Location = new System.Drawing.Point(5, 13);
            this.nsTabControl1.Multiline = true;
            this.nsTabControl1.Name = "nsTabControl1";
            this.nsTabControl1.SelectedIndex = 0;
            this.nsTabControl1.Size = new System.Drawing.Size(121, 457);
            this.nsTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.nsTabControl1.TabIndex = 26;
            this.nsTabControl1.SelectedIndexChanged += new System.EventHandler(this.nsTabControl1_SelectedIndexChanged);
            this.nsTabControl1.TabIndexChanged += new System.EventHandler(this.nsTabControl1_SelectedIndexChanged);
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(136, 13);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(302, 302);
            this.panel10.TabIndex = 25;
            this.panel10.TabStop = false;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel10_MouseDown);
            this.panel10.MouseHover += new System.EventHandler(this.panel10_MouseHover);
            this.panel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel10_MouseMove);
            this.panel10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel10_MouseUp);
            // 
            // nsGroupBox8
            // 
            this.nsGroupBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nsGroupBox8.Controls.Add(this.nsTextBox4);
            this.nsGroupBox8.Controls.Add(this.custEmergencyLbl);
            this.nsGroupBox8.Controls.Add(this.nsOnOffBox3);
            this.nsGroupBox8.Controls.Add(this.RFIDLbl);
            this.nsGroupBox8.DrawSeperator = true;
            this.nsGroupBox8.Location = new System.Drawing.Point(136, 324);
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
            this.nsGroupBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nsGroupBox9.Controls.Add(this.appList);
            this.nsGroupBox9.DrawSeperator = true;
            this.nsGroupBox9.Location = new System.Drawing.Point(447, 13);
            this.nsGroupBox9.Name = "nsGroupBox9";
            this.nsGroupBox9.Size = new System.Drawing.Size(174, 301);
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
            this.appList.Size = new System.Drawing.Size(168, 256);
            this.appList.TabIndex = 0;
            this.appList.Text = "nsListView1";
            // 
            // nsGroupBox10
            // 
            this.nsGroupBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nsGroupBox10.Controls.Add(this.nsButton1);
            this.nsGroupBox10.DrawSeperator = true;
            this.nsGroupBox10.Location = new System.Drawing.Point(447, 324);
            this.nsGroupBox10.Name = "nsGroupBox10";
            this.nsGroupBox10.Size = new System.Drawing.Size(174, 146);
            this.nsGroupBox10.SubTitle = "View and change the selected app.";
            this.nsGroupBox10.TabIndex = 22;
            this.nsGroupBox10.Text = "nsGroupBox1";
            this.nsGroupBox10.Title = "Selection controls";
            // 
            // nsButton1
            // 
            this.nsButton1.Location = new System.Drawing.Point(3, 44);
            this.nsButton1.Name = "nsButton1";
            this.nsButton1.Size = new System.Drawing.Size(75, 23);
            this.nsButton1.TabIndex = 0;
            this.nsButton1.Text = "Delete";
            this.nsButton1.Click += new System.EventHandler(this.nsButton1_Click);
            // 
            // nsControlButton3
            // 
            this.nsControlButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton3.ControlButton = NSControlButton.Button.Minimize;
            this.nsControlButton3.Location = new System.Drawing.Point(577, 6);
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
            this.nsControlButton2.Location = new System.Drawing.Point(595, 6);
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
            this.nsControlButton1.Location = new System.Drawing.Point(613, 6);
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
            // nsContextMenu1
            // 
            this.nsContextMenu1.ForeColor = System.Drawing.Color.White;
            this.nsContextMenu1.Name = "nsContextMenu1";
            this.nsContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // nsContextMenu2
            // 
            this.nsContextMenu2.ForeColor = System.Drawing.Color.White;
            this.nsContextMenu2.Name = "nsContextMenu2";
            this.nsContextMenu2.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 663);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.nsTheme1.ResumeLayout(false);
            this.nsGroupBox2.ResumeLayout(false);
            this.nsGroupBox1.ResumeLayout(false);
            this.nsGroupBox1.PerformLayout();
            this.nsGroupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel10)).EndInit();
            this.nsGroupBox8.ResumeLayout(false);
            this.nsGroupBox8.PerformLayout();
            this.nsGroupBox9.ResumeLayout(false);
            this.nsGroupBox10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme1;
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
        private NSGroupBox nsGroupBox2;
        private NSGroupBox nsGroupBox1;
        private NSButton renameLayoutBtn;
        private NSButton deleteLayoutBtn;
        private NSButton saveLayoutBtn;
        private NSTextBox nsTextBox2;
        private NSTextBox nsTextBox1;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_Label monoFlat_Label3;
        private NSTextBox nsTextBox3;
        private MonoFlat.MonoFlat_Label monoFlat_Label4;
        private NSTextBox nsTextBox5;
        private NSButton nsButton1;
        private MonoFlat.MonoFlat_Label monoFlat_Label5;
        private NSTextBox nsTextBox6;
        private NSContextMenu nsContextMenu1;
        private NSContextMenu nsContextMenu2;
        private NSGroupBox nsGroupBox3;
        private NSTabControl nsTabControl1;
    }
}