/*
 * Created by SharpDevelop.
 * User: es1480
 * Date: 11/11/2015
 * Time: 2:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SWatchDesigner
{
	/// <summary>
	/// Description of NewLayoutDialog.
	/// </summary>
	public partial class NewLayoutDialog : Form
	{
		public NewLayoutDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void OkBtnClick(object sender, EventArgs e)
		{
            if (!string.IsNullOrWhiteSpace(LayoutNameTxt.Text.Trim()))
            {
                LayoutNameTxt.Text = LayoutNameTxt.Text.Replace(" ","");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                errorLabel.Visible = true;
            }
		}
		
		void NsControlButton1Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

        private void LayoutNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(LayoutNameTxt.Text.Trim()))
                {
                    LayoutNameTxt.Text = LayoutNameTxt.Text.Replace(" ", "");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    errorLabel.Visible = true;
                }
            }
        }
	}
}
