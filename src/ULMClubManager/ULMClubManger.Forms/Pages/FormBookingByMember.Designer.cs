
namespace ULMClubManger.Forms.Pages
{
    partial class FormBookingByMember
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
            this._ucBookingPickerByPilot = new ULMClubManger.Forms.UserControls.UCBookingPickerByMember();
            this.ucBookingByMemberCRUD1 = new ULMClubManger.Forms.UserControls.UCBookingByMemberCRUD();
            this.SuspendLayout();
            // 
            // _ucBookingPickerByPilot
            // 
            this._ucBookingPickerByPilot.BackColor = System.Drawing.Color.WhiteSmoke;
            this._ucBookingPickerByPilot.Dock = System.Windows.Forms.DockStyle.Left;
            this._ucBookingPickerByPilot.Location = new System.Drawing.Point(0, 0);
            this._ucBookingPickerByPilot.Name = "_ucBookingPickerByPilot";
            this._ucBookingPickerByPilot.Size = new System.Drawing.Size(234, 739);
            this._ucBookingPickerByPilot.TabIndex = 0;
            this._ucBookingPickerByPilot.SelectPilot += new ULMClubManger.Forms.delSelect(this._ucBookingPickerByPilot_SelectPilot);
            // 
            // ucBookingByMemberCRUD1
            // 
            this.ucBookingByMemberCRUD1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucBookingByMemberCRUD1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBookingByMemberCRUD1.Location = new System.Drawing.Point(234, 0);
            this.ucBookingByMemberCRUD1.Name = "ucBookingByMemberCRUD1";
            this.ucBookingByMemberCRUD1.Size = new System.Drawing.Size(538, 739);
            this.ucBookingByMemberCRUD1.TabIndex = 1;
            // 
            // FormBookingByMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 739);
            this.Controls.Add(this.ucBookingByMemberCRUD1);
            this.Controls.Add(this._ucBookingPickerByPilot);
            this.Name = "FormBookingByMember";
            this.Text = "FormBookingByMember";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UCBookingPickerByMember _ucBookingPickerByPilot;
        private UserControls.UCBookingByMemberCRUD ucBookingByMemberCRUD1;
    }
}