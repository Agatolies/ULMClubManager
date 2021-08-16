
namespace ULMClubManger.Forms.UserControls
{
    partial class UCLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._tboxUserName = new System.Windows.Forms.TextBox();
            this._tboxPassword = new System.Windows.Forms.TextBox();
            this._btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // _tboxUserName
            // 
            this._tboxUserName.Location = new System.Drawing.Point(210, 44);
            this._tboxUserName.Name = "_tboxUserName";
            this._tboxUserName.Size = new System.Drawing.Size(182, 22);
            this._tboxUserName.TabIndex = 2;
            // 
            // _tboxPassword
            // 
            this._tboxPassword.Location = new System.Drawing.Point(210, 92);
            this._tboxPassword.Name = "_tboxPassword";
            this._tboxPassword.PasswordChar = '*';
            this._tboxPassword.Size = new System.Drawing.Size(182, 22);
            this._tboxPassword.TabIndex = 3;
            // 
            // _btnLogin
            // 
            this._btnLogin.Location = new System.Drawing.Point(228, 145);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(141, 23);
            this._btnLogin.TabIndex = 4;
            this._btnLogin.Text = "Se connecter";
            this._btnLogin.UseVisualStyleBackColor = true;
            this._btnLogin.Click += new System.EventHandler(this._btnLogin_Click);
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnLogin);
            this.Controls.Add(this._tboxPassword);
            this.Controls.Add(this._tboxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(555, 255);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tboxUserName;
        private System.Windows.Forms.TextBox _tboxPassword;
        private System.Windows.Forms.Button _btnLogin;
    }
}
