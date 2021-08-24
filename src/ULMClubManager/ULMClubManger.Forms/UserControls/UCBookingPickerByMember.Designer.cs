
namespace ULMClubManger.Forms.UserControls
{
    partial class UCBookingPickerByMember
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
            this._panelBookingByMember = new System.Windows.Forms.Panel();
            this._labelSearchName = new System.Windows.Forms.Label();
            this._tboxSearchPilot = new System.Windows.Forms.TextBox();
            this._lbPilots = new System.Windows.Forms.ListBox();
            this._panelBookingByMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelBookingByMember
            // 
            this._panelBookingByMember.Controls.Add(this._labelSearchName);
            this._panelBookingByMember.Controls.Add(this._tboxSearchPilot);
            this._panelBookingByMember.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelBookingByMember.Location = new System.Drawing.Point(0, 0);
            this._panelBookingByMember.Name = "_panelBookingByMember";
            this._panelBookingByMember.Size = new System.Drawing.Size(234, 68);
            this._panelBookingByMember.TabIndex = 0;
            // 
            // _labelSearchName
            // 
            this._labelSearchName.AutoSize = true;
            this._labelSearchName.Location = new System.Drawing.Point(6, 16);
            this._labelSearchName.Name = "_labelSearchName";
            this._labelSearchName.Size = new System.Drawing.Size(29, 13);
            this._labelSearchName.TabIndex = 8;
            this._labelSearchName.Text = "Nom";
            // 
            // _tboxSearchPilot
            // 
            this._tboxSearchPilot.Location = new System.Drawing.Point(41, 13);
            this._tboxSearchPilot.Name = "_tboxSearchPilot";
            this._tboxSearchPilot.Size = new System.Drawing.Size(191, 20);
            this._tboxSearchPilot.TabIndex = 7;
            this._tboxSearchPilot.TextChanged += new System.EventHandler(this._tboxSearchPilot_TextChanged);
            // 
            // _lbPilots
            // 
            this._lbPilots.FormattingEnabled = true;
            this._lbPilots.Location = new System.Drawing.Point(3, 73);
            this._lbPilots.Margin = new System.Windows.Forms.Padding(2);
            this._lbPilots.Name = "_lbPilots";
            this._lbPilots.Size = new System.Drawing.Size(229, 628);
            this._lbPilots.TabIndex = 5;
            this._lbPilots.SelectedIndexChanged += new System.EventHandler(this._lbPilots_SelectedIndexChanged);
            // 
            // UCBookingPickerByMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lbPilots);
            this.Controls.Add(this._panelBookingByMember);
            this.Name = "UCBookingPickerByMember";
            this.Size = new System.Drawing.Size(234, 707);
            this.Load += new System.EventHandler(this.UCBookingPickerByMember_Load);
            this._panelBookingByMember.ResumeLayout(false);
            this._panelBookingByMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelBookingByMember;
        private System.Windows.Forms.Label _labelSearchName;
        private System.Windows.Forms.TextBox _tboxSearchPilot;
        private System.Windows.Forms.ListBox _lbPilots;
    }
}
