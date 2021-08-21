
namespace ULMClubManger.Forms.UserControls
{
    partial class UCMemberCRUD
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
            this._labelLastName = new System.Windows.Forms.Label();
            this._labelFirstName = new System.Windows.Forms.Label();
            this._tboxLastName = new System.Windows.Forms.TextBox();
            this._tboxFirstName = new System.Windows.Forms.TextBox();
            this._labelID = new System.Windows.Forms.Label();
            this._tboxID = new System.Windows.Forms.TextBox();
            this._labelSex = new System.Windows.Forms.Label();
            this._cboxSex = new System.Windows.Forms.ComboBox();
            this._bsMember = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._bsMember)).BeginInit();
            this.SuspendLayout();
            // 
            // _labelLastName
            // 
            this._labelLastName.AutoSize = true;
            this._labelLastName.Location = new System.Drawing.Point(17, 58);
            this._labelLastName.Name = "_labelLastName";
            this._labelLastName.Size = new System.Drawing.Size(35, 13);
            this._labelLastName.TabIndex = 0;
            this._labelLastName.Text = "Nom :";
            // 
            // _labelFirstName
            // 
            this._labelFirstName.AutoSize = true;
            this._labelFirstName.Location = new System.Drawing.Point(17, 85);
            this._labelFirstName.Name = "_labelFirstName";
            this._labelFirstName.Size = new System.Drawing.Size(49, 13);
            this._labelFirstName.TabIndex = 1;
            this._labelFirstName.Text = "Prénom :";
            // 
            // _tboxLastName
            // 
            this._tboxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tboxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "LastName", true));
            this._tboxLastName.Location = new System.Drawing.Point(140, 55);
            this._tboxLastName.Name = "_tboxLastName";
            this._tboxLastName.Size = new System.Drawing.Size(346, 20);
            this._tboxLastName.TabIndex = 2;
            // 
            // _tboxFirstName
            // 
            this._tboxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tboxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "FirstName", true));
            this._tboxFirstName.Location = new System.Drawing.Point(140, 82);
            this._tboxFirstName.Name = "_tboxFirstName";
            this._tboxFirstName.Size = new System.Drawing.Size(346, 20);
            this._tboxFirstName.TabIndex = 3;
            // 
            // _labelID
            // 
            this._labelID.AutoSize = true;
            this._labelID.Location = new System.Drawing.Point(17, 29);
            this._labelID.Name = "_labelID";
            this._labelID.Size = new System.Drawing.Size(22, 13);
            this._labelID.TabIndex = 4;
            this._labelID.Text = "Id :";
            // 
            // _tboxID
            // 
            this._tboxID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tboxID.BackColor = System.Drawing.SystemColors.Control;
            this._tboxID.Location = new System.Drawing.Point(140, 26);
            this._tboxID.Name = "_tboxID";
            this._tboxID.ReadOnly = true;
            this._tboxID.Size = new System.Drawing.Size(75, 20);
            this._tboxID.TabIndex = 5;
            // 
            // _labelSex
            // 
            this._labelSex.AutoSize = true;
            this._labelSex.Location = new System.Drawing.Point(17, 113);
            this._labelSex.Name = "_labelSex";
            this._labelSex.Size = new System.Drawing.Size(37, 13);
            this._labelSex.TabIndex = 6;
            this._labelSex.Text = "Sexe :";
            // 
            // _cboxSex
            // 
            this._cboxSex.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._bsMember, "Sex", true));
            this._cboxSex.FormattingEnabled = true;
            this._cboxSex.Location = new System.Drawing.Point(140, 110);
            this._cboxSex.Name = "_cboxSex";
            this._cboxSex.Size = new System.Drawing.Size(75, 21);
            this._cboxSex.TabIndex = 7;
            // 
            // _bsMember
            // 
            this._bsMember.DataSource = typeof(ULMClubManager.DTO.Abstractions.IMember);
            // 
            // UCMemberCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this._cboxSex);
            this.Controls.Add(this._labelSex);
            this.Controls.Add(this._tboxID);
            this.Controls.Add(this._labelID);
            this.Controls.Add(this._tboxFirstName);
            this.Controls.Add(this._tboxLastName);
            this.Controls.Add(this._labelFirstName);
            this.Controls.Add(this._labelLastName);
            this.Name = "UCMemberCRUD";
            this.Size = new System.Drawing.Size(545, 600);
            ((System.ComponentModel.ISupportInitialize)(this._bsMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelLastName;
        private System.Windows.Forms.Label _labelFirstName;
        private System.Windows.Forms.TextBox _tboxLastName;
        private System.Windows.Forms.TextBox _tboxFirstName;
        private System.Windows.Forms.Label _labelID;
        private System.Windows.Forms.TextBox _tboxID;
        private System.Windows.Forms.Label _labelSex;
        private System.Windows.Forms.ComboBox _cboxSex;
        private System.Windows.Forms.BindingSource _bsMember;
    }
}
