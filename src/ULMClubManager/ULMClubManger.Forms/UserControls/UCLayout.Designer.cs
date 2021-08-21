
namespace ULMClubManger.Forms.UserControls
{
    partial class UCLayout
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
            this.ucSideBar1 = new ULMClubManger.Forms.UserControls.UCSideBar();
            this._panelChildForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ucSideBar1
            // 
            this.ucSideBar1.AutoScroll = true;
            this.ucSideBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.ucSideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucSideBar1.Location = new System.Drawing.Point(0, 0);
            this.ucSideBar1.MinimumSize = new System.Drawing.Size(225, 600);
            this.ucSideBar1.Name = "ucSideBar1";
            this.ucSideBar1.Size = new System.Drawing.Size(225, 700);
            this.ucSideBar1.TabIndex = 5;
            // 
            // _panelChildForm
            // 
            this._panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelChildForm.BackColor = System.Drawing.Color.Gray;
            this._panelChildForm.Location = new System.Drawing.Point(225, 0);
            this._panelChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._panelChildForm.Name = "_panelChildForm";
            this._panelChildForm.Size = new System.Drawing.Size(663, 700);
            this._panelChildForm.TabIndex = 6;
            // 
            // UCLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panelChildForm);
            this.Controls.Add(this.ucSideBar1);
            this.Name = "UCLayout";
            this.Size = new System.Drawing.Size(888, 700);
            this.ResumeLayout(false);

        }

        #endregion
        private UCSideBar ucSideBar1;
        private System.Windows.Forms.Panel _panelChildForm;
    }
}
