
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLayout));
            this._panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._ucSideBar = new ULMClubManger.Forms.UserControls.UCSideBar();
            this._panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _panelChildForm
            // 
            this._panelChildForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this._panelChildForm.Controls.Add(this.pictureBox1);
            this._panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelChildForm.Location = new System.Drawing.Point(225, 0);
            this._panelChildForm.Margin = new System.Windows.Forms.Padding(2);
            this._panelChildForm.Name = "_panelChildForm";
            this._panelChildForm.Size = new System.Drawing.Size(663, 700);
            this._panelChildForm.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 700);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _ucSideBar
            // 
            this._ucSideBar.AutoScroll = true;
            this._ucSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._ucSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this._ucSideBar.Location = new System.Drawing.Point(0, 0);
            this._ucSideBar.MinimumSize = new System.Drawing.Size(225, 600);
            this._ucSideBar.Name = "_ucSideBar";
            this._ucSideBar.Size = new System.Drawing.Size(225, 700);
            this._ucSideBar.TabIndex = 5;
            // 
            // UCLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panelChildForm);
            this.Controls.Add(this._ucSideBar);
            this.Name = "UCLayout";
            this.Size = new System.Drawing.Size(888, 700);
            this._panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UCSideBar _ucSideBar;
        private System.Windows.Forms.Panel _panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
