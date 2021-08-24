
namespace ULMClubManger.Forms.UserControls
{
    partial class UCBookingByRunwayReadOnly
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
            this._labelBookingByRunwayReadOnly_Title1 = new System.Windows.Forms.Label();
            this._labelBookingByRunwayReadOnly_Title2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _labelBookingByRunwayReadOnly_Title1
            // 
            this._labelBookingByRunwayReadOnly_Title1.AutoSize = true;
            this._labelBookingByRunwayReadOnly_Title1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByRunwayReadOnly_Title1.Location = new System.Drawing.Point(20, 14);
            this._labelBookingByRunwayReadOnly_Title1.Name = "_labelBookingByRunwayReadOnly_Title1";
            this._labelBookingByRunwayReadOnly_Title1.Size = new System.Drawing.Size(442, 36);
            this._labelBookingByRunwayReadOnly_Title1.TabIndex = 30;
            this._labelBookingByRunwayReadOnly_Title1.Text = "LISTE DES RESERVATIONS";
            // 
            // _labelBookingByRunwayReadOnly_Title2
            // 
            this._labelBookingByRunwayReadOnly_Title2.AutoSize = true;
            this._labelBookingByRunwayReadOnly_Title2.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByRunwayReadOnly_Title2.Location = new System.Drawing.Point(20, 60);
            this._labelBookingByRunwayReadOnly_Title2.Name = "_labelBookingByRunwayReadOnly_Title2";
            this._labelBookingByRunwayReadOnly_Title2.Size = new System.Drawing.Size(187, 36);
            this._labelBookingByRunwayReadOnly_Title2.TabIndex = 31;
            this._labelBookingByRunwayReadOnly_Title2.Text = "PAR PISTE";
            // 
            // UCBookingByRunwayReadOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this._labelBookingByRunwayReadOnly_Title2);
            this.Controls.Add(this._labelBookingByRunwayReadOnly_Title1);
            this.Name = "UCBookingByRunwayReadOnly";
            this.Size = new System.Drawing.Size(545, 1045);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelBookingByRunwayReadOnly_Title1;
        private System.Windows.Forms.Label _labelBookingByRunwayReadOnly_Title2;
    }
}
