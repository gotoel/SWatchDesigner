/*
 * Created by SharpDevelop.
 * User: es1480
 * Date: 11/11/2015
 * Time: 2:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SWatchDesigner
{
	partial class NewLayoutDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.nsTheme1 = new NSTheme();
            this.errorLabel = new MonoFlat.MonoFlat_Label();
            this.okBtn = new NSButton();
            this.LayoutNameTxt = new NSTextBox();
            this.nsLabel1 = new NSLabel();
            this.nsControlButton3 = new NSControlButton();
            this.nsControlButton2 = new NSControlButton();
            this.nsControlButton1 = new NSControlButton();
            this.nsTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.Controls.Add(this.errorLabel);
            this.nsTheme1.Controls.Add(this.okBtn);
            this.nsTheme1.Controls.Add(this.LayoutNameTxt);
            this.nsTheme1.Controls.Add(this.nsLabel1);
            this.nsTheme1.Controls.Add(this.nsControlButton3);
            this.nsTheme1.Controls.Add(this.nsControlButton2);
            this.nsTheme1.Controls.Add(this.nsControlButton1);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = true;
            this.nsTheme1.Size = new System.Drawing.Size(317, 123);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "New Layout";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(17, 88);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(143, 15);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "Please enter a valid name.";
            this.errorLabel.Visible = false;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(230, 85);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "     OK";
            this.okBtn.Click += new System.EventHandler(this.OkBtnClick);
            // 
            // LayoutNameTxt
            // 
            this.LayoutNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LayoutNameTxt.Location = new System.Drawing.Point(129, 49);
            this.LayoutNameTxt.MaxLength = 32767;
            this.LayoutNameTxt.Multiline = false;
            this.LayoutNameTxt.Name = "LayoutNameTxt";
            this.LayoutNameTxt.ReadOnly = false;
            this.LayoutNameTxt.Size = new System.Drawing.Size(176, 23);
            this.LayoutNameTxt.TabIndex = 8;
            this.LayoutNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LayoutNameTxt.UseSystemPasswordChar = false;
            // 
            // nsLabel1
            // 
            this.nsLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel1.Location = new System.Drawing.Point(19, 42);
            this.nsLabel1.Name = "nsLabel1";
            this.nsLabel1.Size = new System.Drawing.Size(104, 34);
            this.nsLabel1.TabIndex = 7;
            this.nsLabel1.Text = "nsLabel1";
            this.nsLabel1.Value1 = "Layout Name:";
            this.nsLabel1.Value2 = "";
            // 
            // nsControlButton3
            // 
            this.nsControlButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton3.ControlButton = NSControlButton.Button.Minimize;
            this.nsControlButton3.Location = new System.Drawing.Point(254, 9);
            this.nsControlButton3.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton3.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton3.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton3.Name = "nsControlButton3";
            this.nsControlButton3.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton3.TabIndex = 6;
            this.nsControlButton3.Text = "nsControlButton3";
            // 
            // nsControlButton2
            // 
            this.nsControlButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton2.ControlButton = NSControlButton.Button.MaximizeRestore;
            this.nsControlButton2.Enabled = false;
            this.nsControlButton2.Location = new System.Drawing.Point(272, 9);
            this.nsControlButton2.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton2.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton2.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton2.Name = "nsControlButton2";
            this.nsControlButton2.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton2.TabIndex = 5;
            this.nsControlButton2.Text = "nsControlButton2";
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.ControlButton = NSControlButton.Button.Close;
            this.nsControlButton1.Location = new System.Drawing.Point(290, 9);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 4;
            this.nsControlButton1.Text = "nsControlButton1";
            this.nsControlButton1.Click += new System.EventHandler(this.NsControlButton1Click);
            // 
            // NewLayoutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 123);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewLayoutDialog";
            this.Text = "NewLayoutDialog";
            this.nsTheme1.ResumeLayout(false);
            this.nsTheme1.PerformLayout();
            this.ResumeLayout(false);

		}
        private NSLabel nsLabel1;
		private NSButton okBtn;
		private NSControlButton nsControlButton1;
		private NSControlButton nsControlButton2;
		private NSControlButton nsControlButton3;
		private NSTheme nsTheme1;
        public NSTextBox LayoutNameTxt;
        private MonoFlat.MonoFlat_Label errorLabel;
	}
}
