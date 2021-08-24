
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
            this._ucBookingPickerByAircraft = new ULMClubManger.Forms.UserControls.UCBookingPickerByAircraft();
            this.ucBookingByAircraftCRUD1 = new ULMClubManger.Forms.UserControls.UCBookingByAircraftCRUD();
            this.SuspendLayout();
            // 
            // _ucBookingPickerByAircraft
            // 
            this._ucBookingPickerByAircraft.BackColor = System.Drawing.Color.WhiteSmoke;
            this._ucBookingPickerByAircraft.Dock = System.Windows.Forms.DockStyle.Left;
            this._ucBookingPickerByAircraft.Location = new System.Drawing.Point(0, 0);
            this._ucBookingPickerByAircraft.Name = "_ucBookingPickerByAircraft";
            this._ucBookingPickerByAircraft.Size = new System.Drawing.Size(234, 739);
            this._ucBookingPickerByAircraft.TabIndex = 0;
            this._ucBookingPickerByAircraft.SelectAircraftCategoryID += new ULMClubManger.Forms.delSelect(this._ucBookingPickerByAircraft_SelectAircraftID);
            // 
            // ucBookingByAircraftCRUD1
            // 
            this.ucBookingByAircraftCRUD1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucBookingByAircraftCRUD1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBookingByAircraftCRUD1.Location = new System.Drawing.Point(234, 0);
            this.ucBookingByAircraftCRUD1.Name = "ucBookingByAircraftCRUD1";
            this.ucBookingByAircraftCRUD1.Size = new System.Drawing.Size(538, 739);
            this.ucBookingByAircraftCRUD1.TabIndex = 1;
            // 
            // FormBookingByAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 739);
            this.Controls.Add(this.ucBookingByAircraftCRUD1);
            this.Controls.Add(this._ucBookingPickerByAircraft);
            this.Name = "FormBookingByAircraft";
            this.Text = "FormBookingByAircraft";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UCBookingPickerByAircraft _ucBookingPickerByAircraft;
        private UserControls.UCBookingByAircraftCRUD ucBookingByAircraftCRUD1;
    }
}