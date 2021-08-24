
namespace ULMClubManger.Forms.Pages
{
    partial class FormBookingByRunway
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
            this._ucBookingPickerByPist = new ULMClubManger.Forms.UserControls.UCBookingPickerByRunway();
            this.ucBookingByRunwayReadOnly1 = new ULMClubManger.Forms.UserControls.UCBookingByRunwayReadOnly();
            this.SuspendLayout();
            // 
            // _ucBookingPickerByPist
            // 
            this._ucBookingPickerByPist.BackColor = System.Drawing.Color.WhiteSmoke;
            this._ucBookingPickerByPist.Dock = System.Windows.Forms.DockStyle.Left;
            this._ucBookingPickerByPist.Location = new System.Drawing.Point(0, 0);
            this._ucBookingPickerByPist.Name = "_ucBookingPickerByPist";
            this._ucBookingPickerByPist.Size = new System.Drawing.Size(234, 739);
            this._ucBookingPickerByPist.TabIndex = 0;
            this._ucBookingPickerByPist.SelectRunwayID += new ULMClubManger.Forms.delSelect(this._ucBookingPickerByPist_SelectRunwayID);
            // 
            // ucBookingByRunwayReadOnly1
            // 
            this.ucBookingByRunwayReadOnly1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucBookingByRunwayReadOnly1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBookingByRunwayReadOnly1.Location = new System.Drawing.Point(234, 0);
            this.ucBookingByRunwayReadOnly1.Name = "ucBookingByRunwayReadOnly1";
            this.ucBookingByRunwayReadOnly1.Size = new System.Drawing.Size(538, 739);
            this.ucBookingByRunwayReadOnly1.TabIndex = 1;
            // 
            // FormBookingByRunway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 739);
            this.Controls.Add(this.ucBookingByRunwayReadOnly1);
            this.Controls.Add(this._ucBookingPickerByPist);
            this.Name = "FormBookingByRunway";
            this.Text = "FormBookingByPist";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UCBookingPickerByRunway _ucBookingPickerByPist;
        private UserControls.UCBookingByRunwayReadOnly ucBookingByRunwayReadOnly1;
    }
}