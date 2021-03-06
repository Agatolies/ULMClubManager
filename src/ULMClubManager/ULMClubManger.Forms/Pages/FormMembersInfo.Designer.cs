
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
            this._ucMemberCRUD = new ULMClubManger.Forms.UserControls.UCMemberCRUD();
            this._ucMemberPicker = new ULMClubManger.Forms.UserControls.UCMemberPicker();
            this.SuspendLayout();
            // 
            // _ucMemberCRUD
            // 
            this._ucMemberCRUD.BackColor = System.Drawing.Color.WhiteSmoke;
            this._ucMemberCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucMemberCRUD.Location = new System.Drawing.Point(0, 0);
            this._ucMemberCRUD.Name = "_ucMemberCRUD";
            this._ucMemberCRUD.Size = new System.Drawing.Size(927, 778);
            this._ucMemberCRUD.TabIndex = 1;
            this._ucMemberCRUD.MemberCreating += new ULMClubManger.Forms.delMemberCreating(this._ucMemberCRUD_MemberCreating);
            this._ucMemberCRUD.MemberUpdating += new ULMClubManger.Forms.delMemberUpdating(this._ucMemberCRUD_MemberUpdating);
            this._ucMemberCRUD.MemberCanceling += new ULMClubManger.Forms.delMemberCanceling(this._ucMemberCRUD_MemberCanceling);
            this._ucMemberCRUD.MemberCreated += new ULMClubManger.Forms.delMemberCreated(this._ucMemberCRUD_MemberCreated);
            this._ucMemberCRUD.MemberUpdated += new ULMClubManger.Forms.delMemberUpdated(this._ucMemberCRUD_MemberUpdated);
            this._ucMemberCRUD.MemberCanceled += new ULMClubManger.Forms.delMemberCanceled(this._ucMemberCRUD_MemberCanceled);
            // 
            // _ucMemberPicker
            // 
            this._ucMemberPicker.BackColor = System.Drawing.Color.WhiteSmoke;
            this._ucMemberPicker.Dock = System.Windows.Forms.DockStyle.Right;
            this._ucMemberPicker.Location = new System.Drawing.Point(927, 0);
            this._ucMemberPicker.Name = "_ucMemberPicker";
            this._ucMemberPicker.Size = new System.Drawing.Size(234, 778);
            this._ucMemberPicker.TabIndex = 0;
            this._ucMemberPicker.SelectMember += new ULMClubManger.Forms.delSelectMember(this._ucMemberPicker_SelectMember);
            // 
            // FormMembersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1161, 778);
            this.Controls.Add(this._ucMemberCRUD);
            this.Controls.Add(this._ucMemberPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMembersInfo";
            this.Text = "FormMembersInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UCMemberPicker _ucMemberPicker;
        private UserControls.UCMemberCRUD _ucMemberCRUD;
    }
}