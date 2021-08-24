
namespace ULMClubManger.Forms
{
    partial class Form1
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
            this.ucLogin1 = new ULMClubManger.Forms.UserControls.UCLogin();
            this.ucLayout1 = new ULMClubManger.Forms.UserControls.UCLayout();
            this.SuspendLayout();
            // 
            // ucLogin1
            // 
            this.ucLogin1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucLogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this.ucLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLogin1.Location = new System.Drawing.Point(0, 0);
            this.ucLogin1.Margin = new System.Windows.Forms.Padding(2);
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(1384, 868);
            this.ucLogin1.TabIndex = 0;
            this.ucLogin1.Visible = false;
            // 
            // ucLayout1
            // 
            this.ucLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLayout1.Location = new System.Drawing.Point(0, 0);
            this.ucLayout1.Margin = new System.Windows.Forms.Padding(4);
            this.ucLayout1.Name = "ucLayout1";
            this.ucLayout1.Size = new System.Drawing.Size(1384, 868);
            this.ucLayout1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 868);
            this.Controls.Add(this.ucLogin1);
            this.Controls.Add(this.ucLayout1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1120, 907);
            this.Name = "Form1";
            this.Text = "ULM Club Manager Liège";
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.UCLogin ucLogin1;
        private UserControls.UCLayout ucLayout1;
    }
}