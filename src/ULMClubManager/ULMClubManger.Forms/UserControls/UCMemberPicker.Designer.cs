
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
            this._labelSearchName = new System.Windows.Forms.Label();
            this._tboxSearchMember = new System.Windows.Forms.TextBox();
            this._lbMembers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _labelSearchName
            // 
            this._labelSearchName.AutoSize = true;
            this._labelSearchName.Location = new System.Drawing.Point(5, 5);
            this._labelSearchName.Name = "_labelSearchName";
            this._labelSearchName.Size = new System.Drawing.Size(29, 13);
            this._labelSearchName.TabIndex = 6;
            this._labelSearchName.Text = "Nom";
            // 
            // _tboxSearchMember
            // 
            this._tboxSearchMember.Location = new System.Drawing.Point(40, 2);
            this._tboxSearchMember.Name = "_tboxSearchMember";
            this._tboxSearchMember.Size = new System.Drawing.Size(191, 20);
            this._tboxSearchMember.TabIndex = 5;
            this._tboxSearchMember.TextChanged += new System.EventHandler(this._tboxSearchMember_TextChanged);
            // 
            // _lbMembers
            // 
            this._lbMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._lbMembers.FormattingEnabled = true;
            this._lbMembers.Location = new System.Drawing.Point(2, 28);
            this._lbMembers.Margin = new System.Windows.Forms.Padding(2);
            this._lbMembers.Name = "_lbMembers";
            this._lbMembers.Size = new System.Drawing.Size(229, 563);
            this._lbMembers.TabIndex = 4;
            this._lbMembers.SelectedIndexChanged += new System.EventHandler(this._lbMembers_SelectedIndexChanged);
            // 
            // UCMemberPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._labelSearchName);
            this.Controls.Add(this._tboxSearchMember);
            this.Controls.Add(this._lbMembers);
            this.Name = "UCMemberPicker";
            this.Size = new System.Drawing.Size(234, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelSearchName;
        private System.Windows.Forms.TextBox _tboxSearchMember;
        private System.Windows.Forms.ListBox _lbMembers;
    }
}
