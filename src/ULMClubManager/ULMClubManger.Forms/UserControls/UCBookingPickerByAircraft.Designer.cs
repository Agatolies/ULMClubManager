
namespace ULMClubManger.Forms.UserControls
{
    partial class UCBookingPickerByAircraft
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
            this._panelBookingByAircraft = new System.Windows.Forms.Panel();
            this._cboxSearchAircraftCategory = new System.Windows.Forms.ComboBox();
            this._labelSearchAircraftCategory = new System.Windows.Forms.Label();
            this._lbAircraftID = new System.Windows.Forms.ListBox();
            this._panelBookingByAircraft.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelBookingByAircraft
            // 
            this._panelBookingByAircraft.Controls.Add(this._cboxSearchAircraftCategory);
            this._panelBookingByAircraft.Controls.Add(this._labelSearchAircraftCategory);
            this._panelBookingByAircraft.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelBookingByAircraft.Location = new System.Drawing.Point(0, 0);
            this._panelBookingByAircraft.Name = "_panelBookingByAircraft";
            this._panelBookingByAircraft.Size = new System.Drawing.Size(234, 68);
            this._panelBookingByAircraft.TabIndex = 1;
            // 
            // _cboxSearchAircraftCategory
            // 
            this._cboxSearchAircraftCategory.FormattingEnabled = true;
            this._cboxSearchAircraftCategory.Location = new System.Drawing.Point(61, 40);
            this._cboxSearchAircraftCategory.Name = "_cboxSearchAircraftCategory";
            this._cboxSearchAircraftCategory.Size = new System.Drawing.Size(170, 21);
            this._cboxSearchAircraftCategory.TabIndex = 9;
            this._cboxSearchAircraftCategory.SelectedIndexChanged += new System.EventHandler(this._cboxSearchAircraftType_SelectedIndexChanged);
            // 
            // _labelSearchAircraftCategory
            // 
            this._labelSearchAircraftCategory.AutoSize = true;
            this._labelSearchAircraftCategory.Location = new System.Drawing.Point(3, 43);
            this._labelSearchAircraftCategory.Name = "_labelSearchAircraftCategory";
            this._labelSearchAircraftCategory.Size = new System.Drawing.Size(52, 13);
            this._labelSearchAircraftCategory.TabIndex = 8;
            this._labelSearchAircraftCategory.Text = "Catégorie";
            // 
            // _lbAircraftID
            // 
            this._lbAircraftID.FormattingEnabled = true;
            this._lbAircraftID.Location = new System.Drawing.Point(3, 73);
            this._lbAircraftID.Name = "_lbAircraftID";
            this._lbAircraftID.Size = new System.Drawing.Size(229, 628);
            this._lbAircraftID.TabIndex = 2;
            this._lbAircraftID.SelectedIndexChanged += new System.EventHandler(this._lbAircraftID_SelectedIndexChanged);
            // 
            // UCBookingPickerByAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lbAircraftID);
            this.Controls.Add(this._panelBookingByAircraft);
            this.Name = "UCBookingPickerByAircraft";
            this.Size = new System.Drawing.Size(234, 707);
            this.Load += new System.EventHandler(this.UCBookingPickerByAircraft_Load);
            this._panelBookingByAircraft.ResumeLayout(false);
            this._panelBookingByAircraft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelBookingByAircraft;
        private System.Windows.Forms.Label _labelSearchAircraftCategory;
        private System.Windows.Forms.ListBox _lbAircraftID;
        private System.Windows.Forms.ComboBox _cboxSearchAircraftCategory;
    }
}
