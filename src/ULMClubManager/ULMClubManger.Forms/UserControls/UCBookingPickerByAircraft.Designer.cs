
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
            this._cboxSearchAircraftCategory = new System.Windows.Forms.ComboBox();
            this._labelSearchAircraftCategory = new System.Windows.Forms.Label();
            this._lbAircrafts = new System.Windows.Forms.ListBox();
            this._panelBottom = new System.Windows.Forms.Panel();
            this._panelFill = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._panelTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._panelFill.SuspendLayout();
            this.panel2.SuspendLayout();
            this._panelTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cboxSearchAircraftCategory
            // 
            this._cboxSearchAircraftCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._cboxSearchAircraftCategory.FormattingEnabled = true;
            this._cboxSearchAircraftCategory.Location = new System.Drawing.Point(68, 34);
            this._cboxSearchAircraftCategory.Name = "_cboxSearchAircraftCategory";
            this._cboxSearchAircraftCategory.Size = new System.Drawing.Size(131, 21);
            this._cboxSearchAircraftCategory.TabIndex = 9;
            this._cboxSearchAircraftCategory.SelectedIndexChanged += new System.EventHandler(this._cboxSearchAircraftType_SelectedIndexChanged);
            // 
            // _labelSearchAircraftCategory
            // 
            this._labelSearchAircraftCategory.AutoSize = true;
            this._labelSearchAircraftCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._labelSearchAircraftCategory.Location = new System.Drawing.Point(3, 37);
            this._labelSearchAircraftCategory.Name = "_labelSearchAircraftCategory";
            this._labelSearchAircraftCategory.Size = new System.Drawing.Size(61, 13);
            this._labelSearchAircraftCategory.TabIndex = 8;
            this._labelSearchAircraftCategory.Text = "Catégorie";
            // 
            // _lbAircrafts
            // 
            this._lbAircrafts.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbAircrafts.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this._lbAircrafts.FormattingEnabled = true;
            this._lbAircrafts.ItemHeight = 17;
            this._lbAircrafts.Location = new System.Drawing.Point(0, 0);
            this._lbAircrafts.Name = "_lbAircrafts";
            this._lbAircrafts.ScrollAlwaysVisible = true;
            this._lbAircrafts.Size = new System.Drawing.Size(224, 498);
            this._lbAircrafts.TabIndex = 2;
            this._lbAircrafts.SelectedIndexChanged += new System.EventHandler(this._lbAircraftID_SelectedIndexChanged);
            // 
            // _panelBottom
            // 
            this._panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBottom.Location = new System.Drawing.Point(0, 613);
            this._panelBottom.Name = "_panelBottom";
            this._panelBottom.Size = new System.Drawing.Size(234, 94);
            this._panelBottom.TabIndex = 10;
            // 
            // _panelFill
            // 
            this._panelFill.Controls.Add(this.panel2);
            this._panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelFill.Location = new System.Drawing.Point(0, 109);
            this._panelFill.Name = "_panelFill";
            this._panelFill.Size = new System.Drawing.Size(234, 598);
            this._panelFill.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this._lbAircrafts);
            this.panel2.Location = new System.Drawing.Point(7, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 498);
            this.panel2.TabIndex = 6;
            // 
            // _panelTop
            // 
            this._panelTop.Controls.Add(this.panel3);
            this._panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelTop.Location = new System.Drawing.Point(0, 0);
            this._panelTop.Name = "_panelTop";
            this._panelTop.Padding = new System.Windows.Forms.Padding(10);
            this._panelTop.Size = new System.Drawing.Size(234, 109);
            this._panelTop.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(10, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 95);
            this.panel3.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._cboxSearchAircraftCategory);
            this.groupBox1.Controls.Add(this._labelSearchAircraftCategory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 95);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECHERCHES";
            // 
            // UCBookingPickerByAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panelBottom);
            this.Controls.Add(this._panelFill);
            this.Controls.Add(this._panelTop);
            this.Name = "UCBookingPickerByAircraft";
            this.Size = new System.Drawing.Size(234, 707);
            this.Load += new System.EventHandler(this.UCBookingPickerByAircraft_Load);
            this._panelFill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this._panelTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label _labelSearchAircraftCategory;
        private System.Windows.Forms.ComboBox _cboxSearchAircraftCategory;
        public System.Windows.Forms.ListBox _lbAircrafts;
        private System.Windows.Forms.Panel _panelBottom;
        private System.Windows.Forms.Panel _panelFill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel _panelTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
