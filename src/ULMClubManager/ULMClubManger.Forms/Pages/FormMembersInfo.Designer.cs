
namespace ULMClubManger.Forms.Pages
{
    partial class FormMembersInfo
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
            this._lbMembers = new System.Windows.Forms.ListBox();
            this._tboxSearchMember = new System.Windows.Forms.TextBox();
            this._labelSearchName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lbMembers
            // 
            this._lbMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._lbMembers.FormattingEnabled = true;
            this._lbMembers.Location = new System.Drawing.Point(9, 38);
            this._lbMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._lbMembers.Name = "_lbMembers";
            this._lbMembers.Size = new System.Drawing.Size(229, 550);
            this._lbMembers.TabIndex = 0;
            // 
            // _tboxSearchMember
            // 
            this._tboxSearchMember.Location = new System.Drawing.Point(47, 12);
            this._tboxSearchMember.Name = "_tboxSearchMember";
            this._tboxSearchMember.Size = new System.Drawing.Size(191, 20);
            this._tboxSearchMember.TabIndex = 2;
            this._tboxSearchMember.TextChanged += new System.EventHandler(this._tboxSearchMember_TextChanged);
            // 
            // _labelSearchName
            // 
            this._labelSearchName.AutoSize = true;
            this._labelSearchName.Location = new System.Drawing.Point(12, 15);
            this._labelSearchName.Name = "_labelSearchName";
            this._labelSearchName.Size = new System.Drawing.Size(29, 13);
            this._labelSearchName.TabIndex = 3;
            this._labelSearchName.Text = "Nom";
            // 
            // FormMembersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(788, 600);
            this.Controls.Add(this._labelSearchName);
            this.Controls.Add(this._tboxSearchMember);
            this.Controls.Add(this._lbMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMembersInfo";
            this.Text = "FormMembersInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _lbMembers;
        private System.Windows.Forms.TextBox _tboxSearchMember;
        private System.Windows.Forms.Label _labelSearchName;
    }
}