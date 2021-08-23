
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._cboxMemberTypes = new System.Windows.Forms.ComboBox();
            this._labelPickPILorSYM = new System.Windows.Forms.Label();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _labelSearchName
            // 
            this._labelSearchName.AutoSize = true;
            this._labelSearchName.Location = new System.Drawing.Point(6, 16);
            this._labelSearchName.Name = "_labelSearchName";
            this._labelSearchName.Size = new System.Drawing.Size(29, 13);
            this._labelSearchName.TabIndex = 6;
            this._labelSearchName.Text = "Nom";
            // 
            // _tboxSearchMember
            // 
            this._tboxSearchMember.Location = new System.Drawing.Point(41, 13);
            this._tboxSearchMember.Name = "_tboxSearchMember";
            this._tboxSearchMember.Size = new System.Drawing.Size(191, 20);
            this._tboxSearchMember.TabIndex = 5;
            this._tboxSearchMember.TextChanged += new System.EventHandler(this._tboxSearchMember_TextChanged);
            // 
            // _lbMembers
            // 
            this._lbMembers.FormattingEnabled = true;
            this._lbMembers.Location = new System.Drawing.Point(3, 73);
            this._lbMembers.Margin = new System.Windows.Forms.Padding(2);
            this._lbMembers.Name = "_lbMembers";
            this._lbMembers.Size = new System.Drawing.Size(229, 628);
            this._lbMembers.TabIndex = 4;
            this._lbMembers.SelectedIndexChanged += new System.EventHandler(this._lbMembers_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._cboxMemberTypes);
            this.panel1.Controls.Add(this._labelPickPILorSYM);
            this.panel1.Controls.Add(this._labelSearchName);
            this.panel1.Controls.Add(this._tboxSearchMember);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 68);
            this.panel1.TabIndex = 7;
            // 
            // _cboxMemberTypes
            // 
            this._cboxMemberTypes.FormattingEnabled = true;
            this._cboxMemberTypes.Location = new System.Drawing.Point(41, 40);
            this._cboxMemberTypes.Name = "_cboxMemberTypes";
            this._cboxMemberTypes.Size = new System.Drawing.Size(190, 21);
            this._cboxMemberTypes.TabIndex = 8;
            // 
            // _labelPickPILorSYM
            // 
            this._labelPickPILorSYM.AutoSize = true;
            this._labelPickPILorSYM.Location = new System.Drawing.Point(6, 43);
            this._labelPickPILorSYM.Name = "_labelPickPILorSYM";
            this._labelPickPILorSYM.Size = new System.Drawing.Size(31, 13);
            this._labelPickPILorSYM.TabIndex = 7;
            this._labelPickPILorSYM.Text = "Type";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(ULMClubManager.DTO.Member);
            // 
            // UCMemberPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._lbMembers);
            this.Name = "UCMemberPicker";
            this.Size = new System.Drawing.Size(234, 707);
            this.Load += new System.EventHandler(this.UCMemberPicker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _labelSearchName;
        private System.Windows.Forms.TextBox _tboxSearchMember;
        private System.Windows.Forms.ListBox _lbMembers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox _cboxMemberTypes;
        private System.Windows.Forms.Label _labelPickPILorSYM;
        private System.Windows.Forms.BindingSource memberBindingSource;
    }
}
