
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
            this._ucBookingByMemberDetailsForm = new ULMClubManger.Forms.UserControls.UCBookingByMemberDetailsForm();
            this._ucBookingByMemberCRUD = new ULMClubManger.Forms.UserControls.UCBookingByMemberCRUD();
            this._ucBookingByMemberPicker = new ULMClubManger.Forms.UserControls.UCBookingPickerByMember();
            this.SuspendLayout();
            // 
            // _ucBookingByMemberDetailsForm
            // 
            this._ucBookingByMemberDetailsForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._ucBookingByMemberDetailsForm.Location = new System.Drawing.Point(0, 549);
            this._ucBookingByMemberDetailsForm.Name = "_ucBookingByMemberDetailsForm";
            this._ucBookingByMemberDetailsForm.SelectedBooking = null;
            this._ucBookingByMemberDetailsForm.SelectedPilotID = 0;
            this._ucBookingByMemberDetailsForm.Size = new System.Drawing.Size(857, 320);
            this._ucBookingByMemberDetailsForm.TabIndex = 2;
            this._ucBookingByMemberDetailsForm.BookingForMemberCreating += new ULMClubManger.Forms.delBookingForMemberCreating(this._ucBookingDetailsForm_BookingForMemberCreating);
            this._ucBookingByMemberDetailsForm.BookingForMemberUpdating += new ULMClubManger.Forms.delBookingForMemberUpdating(this._ucBookingDetailsForm_BookingForMemberUpdating);
            this._ucBookingByMemberDetailsForm.BookingForMemberCanceling += new ULMClubManger.Forms.delBookingForMemberCanceling(this._ucBookingDetailsForm_BookingForMemberCanceling);
            this._ucBookingByMemberDetailsForm.BookingForMemberCreated += new ULMClubManger.Forms.delBookingForMemberCreated(this._ucBookingDetailsForm_BookingForMemberCreated);
            this._ucBookingByMemberDetailsForm.BookingForMemberUpdated += new ULMClubManger.Forms.delBookingForMemberUpdated(this._ucBookingDetailsForm_BookingForMemberUpdated);
            this._ucBookingByMemberDetailsForm.BookingForMemberCanceled += new ULMClubManger.Forms.delBookingForMemberCanceled(this._ucBookingDetailsForm_BookingForMemberCanceled);
            // 
            // _ucBookingByMemberCRUD
            // 
            this._ucBookingByMemberCRUD.BackColor = System.Drawing.Color.WhiteSmoke;
            this._ucBookingByMemberCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucBookingByMemberCRUD.Location = new System.Drawing.Point(0, 0);
            this._ucBookingByMemberCRUD.Name = "_ucBookingByMemberCRUD";
            this._ucBookingByMemberCRUD.Size = new System.Drawing.Size(857, 869);
            this._ucBookingByMemberCRUD.TabIndex = 1;
            this._ucBookingByMemberCRUD.SelectBooking += new ULMClubManger.Forms.delSelectBooking(this._ucBookingByMemberCRUD_SelectBooking);
            // 
            // _ucBookingByMemberPicker
            // 
            this._ucBookingByMemberPicker.BackColor = System.Drawing.Color.WhiteSmoke;
            this._ucBookingByMemberPicker.Dock = System.Windows.Forms.DockStyle.Right;
            this._ucBookingByMemberPicker.Location = new System.Drawing.Point(857, 0);
            this._ucBookingByMemberPicker.Name = "_ucBookingByMemberPicker";
            this._ucBookingByMemberPicker.Size = new System.Drawing.Size(234, 869);
            this._ucBookingByMemberPicker.TabIndex = 0;
            this._ucBookingByMemberPicker.SelectPilot += new ULMClubManger.Forms.delSelectMember(this._ucBookingPickerByPilot_SelectPilot);
            // 
            // FormBookingByMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1091, 869);
            this.Controls.Add(this._ucBookingByMemberDetailsForm);
            this.Controls.Add(this._ucBookingByMemberCRUD);
            this.Controls.Add(this._ucBookingByMemberPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBookingByMember";
            this.Text = "FormBookingByMember";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UCBookingPickerByMember _ucBookingByMemberPicker;
        private UserControls.UCBookingByMemberCRUD _ucBookingByMemberCRUD;
        private UserControls.UCBookingByMemberDetailsForm _ucBookingByMemberDetailsForm;
    }
}