
namespace ULMClubManger.Forms.UserControls
{
    partial class UCMemberPicker
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
            this.components = new System.ComponentModel.Container();
            this._labelSearchName = new System.Windows.Forms.Label();
            this._tboxSearchMember = new System.Windows.Forms.TextBox();
            this._lbMembers = new System.Windows.Forms.ListBox();
            this._panelTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._labelPickPILorSYM = new System.Windows.Forms.Label();
            this._cboxMemberTypes = new System.Windows.Forms.ComboBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._panelFill = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._panelBottom = new System.Windows.Forms.Panel();
            this._panelTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this._panelFill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelSearchName
            // 
            this._labelSearchName.AutoSize = true;
            this._labelSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelSearchName.Location = new System.Drawing.Point(12, 39);
            this._labelSearchName.Name = "_labelSearchName";
            this._labelSearchName.Size = new System.Drawing.Size(32, 13);
            this._labelSearchName.TabIndex = 6;
            this._labelSearchName.Text = "Nom";
            // 
            // _tboxSearchMember
            // 
            this._tboxSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tboxSearchMember.Location = new System.Drawing.Point(62, 36);
            this._tboxSearchMember.Name = "_tboxSearchMember";
            this._tboxSearchMember.Size = new System.Drawing.Size(131, 20);
            this._tboxSearchMember.TabIndex = 5;
            this._tboxSearchMember.TextChanged += new System.EventHandler(this._tboxSearchMember_TextChanged);
            // 
            // _lbMembers
            // 
            this._lbMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbMembers.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbMembers.FormattingEnabled = true;
            this._lbMembers.ItemHeight = 17;
            this._lbMembers.Location = new System.Drawing.Point(0, 0);
            this._lbMembers.Margin = new System.Windows.Forms.Padding(2);
            this._lbMembers.Name = "_lbMembers";
            this._lbMembers.ScrollAlwaysVisible = true;
            this._lbMembers.Size = new System.Drawing.Size(224, 498);
            this._lbMembers.TabIndex = 4;
            this._lbMembers.SelectedIndexChanged += new System.EventHandler(this._lbMembers_SelectedIndexChanged);
            // 
            // _panelTop
            // 
            this._panelTop.Controls.Add(this.panel3);
            this._panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelTop.Location = new System.Drawing.Point(0, 0);
            this._panelTop.Name = "_panelTop";
            this._panelTop.Padding = new System.Windows.Forms.Padding(10);
            this._panelTop.Size = new System.Drawing.Size(234, 109);
            this._panelTop.TabIndex = 7;
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
            this.groupBox1.Controls.Add(this._tboxSearchMember);
            this.groupBox1.Controls.Add(this._labelSearchName);
            this.groupBox1.Controls.Add(this._labelPickPILorSYM);
            this.groupBox1.Controls.Add(this._cboxMemberTypes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 95);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECHERCHES";
            // 
            // _labelPickPILorSYM
            // 
            this._labelPickPILorSYM.AutoSize = true;
            this._labelPickPILorSYM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelPickPILorSYM.Location = new System.Drawing.Point(12, 65);
            this._labelPickPILorSYM.Name = "_labelPickPILorSYM";
            this._labelPickPILorSYM.Size = new System.Drawing.Size(35, 13);
            this._labelPickPILorSYM.TabIndex = 7;
            this._labelPickPILorSYM.Text = "Type";
            // 
            // _cboxMemberTypes
            // 
            this._cboxMemberTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboxMemberTypes.FormattingEnabled = true;
            this._cboxMemberTypes.Location = new System.Drawing.Point(62, 62);
            this._cboxMemberTypes.Name = "_cboxMemberTypes";
            this._cboxMemberTypes.Size = new System.Drawing.Size(131, 21);
            this._cboxMemberTypes.TabIndex = 8;
            this._cboxMemberTypes.SelectedIndexChanged += new System.EventHandler(this._cboxMemberTypes_SelectedIndexChanged);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(ULMClubManager.DTO.Member);
            // 
            // _panelFill
            // 
            this._panelFill.Controls.Add(this.panel2);
            this._panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelFill.Location = new System.Drawing.Point(0, 109);
            this._panelFill.Name = "_panelFill";
            this._panelFill.Size = new System.Drawing.Size(234, 598);
            this._panelFill.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this._lbMembers);
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 498);
            this.panel2.TabIndex = 5;
            // 
            // _panelBottom
            // 
            this._panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBottom.Location = new System.Drawing.Point(0, 613);
            this._panelBottom.Name = "_panelBottom";
            this._panelBottom.Size = new System.Drawing.Size(234, 94);
            this._panelBottom.TabIndex = 9;
            // 
            // UCMemberPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panelBottom);
            this.Controls.Add(this._panelFill);
            this.Controls.Add(this._panelTop);
            this.Name = "UCMemberPicker";
            this.Size = new System.Drawing.Size(234, 707);
            this.Load += new System.EventHandler(this.UCMemberPicker_Load);
            this._panelTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this._panelFill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _labelSearchName;
        private System.Windows.Forms.TextBox _tboxSearchMember;
        private System.Windows.Forms.ListBox _lbMembers;
        private System.Windows.Forms.Panel _panelTop;
        private System.Windows.Forms.ComboBox _cboxMemberTypes;
        private System.Windows.Forms.Label _labelPickPILorSYM;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel _panelFill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel _panelBottom;
    }
}
