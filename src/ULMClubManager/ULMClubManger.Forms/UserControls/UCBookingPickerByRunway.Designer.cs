
namespace ULMClubManger.Forms.UserControls
{
    partial class UCBookingPickerByRunway
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this._lbRunwayID = new System.Windows.Forms.ListBox();
            this._panelBookingByPist = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _lbRunwayID
            // 
            this._lbRunwayID.FormattingEnabled = true;
            this._lbRunwayID.Location = new System.Drawing.Point(3, 73);
            this._lbRunwayID.Name = "_lbRunwayID";
            this._lbRunwayID.Size = new System.Drawing.Size(229, 628);
            this._lbRunwayID.TabIndex = 3;
            this._lbRunwayID.SelectedIndexChanged += new System.EventHandler(this._lbRunwayID_SelectedIndexChanged);
            // 
            // _panelBookingByPist
            // 
            this._panelBookingByPist.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelBookingByPist.Location = new System.Drawing.Point(0, 0);
            this._panelBookingByPist.Name = "_panelBookingByPist";
            this._panelBookingByPist.Size = new System.Drawing.Size(234, 67);
            this._panelBookingByPist.TabIndex = 4;
            // 
            // UCBookingPickerByRunway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panelBookingByPist);
            this.Controls.Add(this._lbRunwayID);
            this.Name = "UCBookingPickerByRunway";
            this.Size = new System.Drawing.Size(234, 707);
            this.Load += new System.EventHandler(this.UCBookingPickerByPist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox _lbRunwayID;
        private System.Windows.Forms.Panel _panelBookingByPist;
    }
}
