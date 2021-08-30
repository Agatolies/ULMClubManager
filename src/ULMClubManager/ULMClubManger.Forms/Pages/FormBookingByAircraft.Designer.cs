
namespace ULMClubManger.Forms.Pages
{
    partial class FormBookingByAircraft
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
            this._ucBookingByAircraftDetailsForm = new ULMClubManger.Forms.UserControls.UCBookingByAircraftDetailsForm();
            this._ucBookingByAircraftCRUD = new ULMClubManger.Forms.UserControls.UCBookingByAircraftCRUD();
            this._ucBookingByAircraftPicker = new ULMClubManger.Forms.UserControls.UCBookingPickerByAircraft();
            this.SuspendLayout();
            // 
            // _ucBookingByAircraftDetailsForm
            // 
            this._ucBookingByAircraftDetailsForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this._ucBookingByAircraftDetailsForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._ucBookingByAircraftDetailsForm.Location = new System.Drawing.Point(0, 549);
            this._ucBookingByAircraftDetailsForm.Name = "_ucBookingByAircraftDetailsForm";
            this._ucBookingByAircraftDetailsForm.SelectedBooking = null;
            this._ucBookingByAircraftDetailsForm.SelectedPilotID = 0;
            this._ucBookingByAircraftDetailsForm.Size = new System.Drawing.Size(857, 320);
            this._ucBookingByAircraftDetailsForm.TabIndex = 2;
            this._ucBookingByAircraftDetailsForm.BookingForAircraftCreating += new ULMClubManger.Forms.delBookingForAircraftCreated(this._ucBookingDetailsForm_BookingForAircraftCreating);
            this._ucBookingByAircraftDetailsForm.BookingForAircraftUpdating += new ULMClubManger.Forms.delBookingForAircraftUpdated(this._ucBookingDetailsForm_BookingForAircraftUpdating);
            this._ucBookingByAircraftDetailsForm.BookingForAircraftCanceling += new ULMClubManger.Forms.delBookingForAircraftCanceled(this._ucBookingDetailsForm_BookingForAircraftCanceling);
            this._ucBookingByAircraftDetailsForm.BookingForAircraftCreated += new ULMClubManger.Forms.delBookingForAircraftCreated(this._ucBookingDetailsForm_BookingForAircraftCreated);
            this._ucBookingByAircraftDetailsForm.BookingForAircraftUpdated += new ULMClubManger.Forms.delBookingForAircraftUpdated(this._ucBookingDetailsForm_BookingForAircraftUpdated);
            this._ucBookingByAircraftDetailsForm.BookingForAircraftCanceled += new ULMClubManger.Forms.delBookingForAircraftCanceled(this._ucBookingDetailsForm_BookingForAircraftCanceled);
            // 
            // _ucBookingByAircraftCRUD
            // 
            this._ucBookingByAircraftCRUD.BackColor = System.Drawing.Color.WhiteSmoke;
            this._ucBookingByAircraftCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ucBookingByAircraftCRUD.Location = new System.Drawing.Point(0, 0);
            this._ucBookingByAircraftCRUD.Name = "_ucBookingByAircraftCRUD";
            this._ucBookingByAircraftCRUD.Size = new System.Drawing.Size(857, 869);
            this._ucBookingByAircraftCRUD.TabIndex = 1;
            this._ucBookingByAircraftCRUD.SelectAircraft += new ULMClubManger.Forms.delSelectAircraft(this._ucBookingByAircraftCRUD_SelectAircraft);
            // 
            // _ucBookingByAircraftPicker
            // 
            this._ucBookingByAircraftPicker.BackColor = System.Drawing.Color.WhiteSmoke;
            this._ucBookingByAircraftPicker.Dock = System.Windows.Forms.DockStyle.Right;
            this._ucBookingByAircraftPicker.Location = new System.Drawing.Point(857, 0);
            this._ucBookingByAircraftPicker.Name = "_ucBookingByAircraftPicker";
            this._ucBookingByAircraftPicker.Size = new System.Drawing.Size(234, 869);
            this._ucBookingByAircraftPicker.TabIndex = 0;
            this._ucBookingByAircraftPicker.SelectAircraftCategoryID += new ULMClubManger.Forms.delSelectMember(this._ucBookingPickerByAircraft_SelectAircraftID);
            // 
            // FormBookingByAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1091, 869);
            this.Controls.Add(this._ucBookingByAircraftDetailsForm);
            this.Controls.Add(this._ucBookingByAircraftCRUD);
            this.Controls.Add(this._ucBookingByAircraftPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBookingByAircraft";
            this.Text = "FormBookingByAircraft";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UCBookingPickerByAircraft _ucBookingByAircraftPicker;
        private UserControls.UCBookingByAircraftCRUD _ucBookingByAircraftCRUD;
        private UserControls.UCBookingByAircraftDetailsForm _ucBookingByAircraftDetailsForm;
    }
}