
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
            this._labelSearchName = new System.Windows.Forms.Label();
            this._tboxSearchPilot = new System.Windows.Forms.TextBox();
            this._lbPilots = new System.Windows.Forms.ListBox();
            this._panelBottom = new System.Windows.Forms.Panel();
            this._panelTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._panelFill = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._panelTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this._panelFill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelSearchName
            // 
            this._labelSearchName.AutoSize = true;
            this._labelSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._labelSearchName.Location = new System.Drawing.Point(9, 41);
            this._labelSearchName.Name = "_labelSearchName";
            this._labelSearchName.Size = new System.Drawing.Size(32, 13);
            this._labelSearchName.TabIndex = 8;
            this._labelSearchName.Text = "Nom";
            // 
            // _tboxSearchPilot
            // 
            this._tboxSearchPilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._tboxSearchPilot.Location = new System.Drawing.Point(68, 38);
            this._tboxSearchPilot.Name = "_tboxSearchPilot";
            this._tboxSearchPilot.Size = new System.Drawing.Size(131, 20);
            this._tboxSearchPilot.TabIndex = 7;
            this._tboxSearchPilot.TextChanged += new System.EventHandler(this._tboxSearchPilot_TextChanged);
            // 
            // _lbPilots
            // 
            this._lbPilots.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbPilots.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this._lbPilots.FormattingEnabled = true;
            this._lbPilots.ItemHeight = 17;
            this._lbPilots.Location = new System.Drawing.Point(0, 0);
            this._lbPilots.Margin = new System.Windows.Forms.Padding(2);
            this._lbPilots.Name = "_lbPilots";
            this._lbPilots.ScrollAlwaysVisible = true;
            this._lbPilots.Size = new System.Drawing.Size(224, 498);
            this._lbPilots.TabIndex = 5;
            this._lbPilots.SelectedIndexChanged += new System.EventHandler(this._lbPilots_SelectedIndexChanged);
            // 
            // _panelBottom
            // 
            this._panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBottom.Location = new System.Drawing.Point(0, 613);
            this._panelBottom.Name = "_panelBottom";
            this._panelBottom.Size = new System.Drawing.Size(234, 94);
            this._panelBottom.TabIndex = 11;
            // 
            // _panelTop
            // 
            this._panelTop.Controls.Add(this.panel3);
            this._panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelTop.Location = new System.Drawing.Point(0, 0);
            this._panelTop.Name = "_panelTop";
            this._panelTop.Padding = new System.Windows.Forms.Padding(10);
            this._panelTop.Size = new System.Drawing.Size(234, 109);
            this._panelTop.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(10, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 95);
            this.panel3.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._labelSearchName);
            this.groupBox2.Controls.Add(this._tboxSearchPilot);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RECHERCHES";
            // 
            // _panelFill
            // 
            this._panelFill.Controls.Add(this.panel2);
            this._panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelFill.Location = new System.Drawing.Point(0, 109);
            this._panelFill.Name = "_panelFill";
            this._panelFill.Size = new System.Drawing.Size(234, 598);
            this._panelFill.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this._lbPilots);
            this.panel2.Location = new System.Drawing.Point(7, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 498);
            this.panel2.TabIndex = 6;
            // 
            // UCBookingPickerByMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panelBottom);
            this.Controls.Add(this._panelFill);
            this.Controls.Add(this._panelTop);
            this.Name = "UCBookingPickerByMember";
            this.Size = new System.Drawing.Size(234, 707);
            this.Load += new System.EventHandler(this.UCBookingPickerByMember_Load);
            this._panelTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this._panelFill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label _labelSearchName;
        private System.Windows.Forms.TextBox _tboxSearchPilot;
        public System.Windows.Forms.ListBox _lbPilots;
        private System.Windows.Forms.Panel _panelBottom;
        private System.Windows.Forms.Panel _panelTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel _panelFill;
        private System.Windows.Forms.Panel panel2;
    }
}
