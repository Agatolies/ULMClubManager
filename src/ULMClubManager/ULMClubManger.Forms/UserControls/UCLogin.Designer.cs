
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
            this._labelUserName = new System.Windows.Forms.Label();
            this._labelPassword = new System.Windows.Forms.Label();
            this._tboxUserName = new System.Windows.Forms.TextBox();
            this._tboxPassword = new System.Windows.Forms.TextBox();
            this._btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelUserName
            // 
            this._labelUserName.AutoSize = true;
            this._labelUserName.Location = new System.Drawing.Point(38, 35);
            this._labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelUserName.Name = "_labelUserName";
            this._labelUserName.Size = new System.Drawing.Size(84, 13);
            this._labelUserName.TabIndex = 0;
            this._labelUserName.Text = "Nom d\'utilisateur";
            // 
            // _labelPassword
            // 
            this._labelPassword.AutoSize = true;
            this._labelPassword.Location = new System.Drawing.Point(38, 74);
            this._labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelPassword.Name = "_labelPassword";
            this._labelPassword.Size = new System.Drawing.Size(71, 13);
            this._labelPassword.TabIndex = 1;
            this._labelPassword.Text = "Mot de passe";
            // 
            // _tboxUserName
            // 
            this._tboxUserName.Location = new System.Drawing.Point(136, 32);
            this._tboxUserName.Margin = new System.Windows.Forms.Padding(2);
            this._tboxUserName.Name = "_tboxUserName";
            this._tboxUserName.Size = new System.Drawing.Size(138, 20);
            this._tboxUserName.TabIndex = 2;
            // 
            // _tboxPassword
            // 
            this._tboxPassword.Location = new System.Drawing.Point(136, 72);
            this._tboxPassword.Margin = new System.Windows.Forms.Padding(2);
            this._tboxPassword.Name = "_tboxPassword";
            this._tboxPassword.PasswordChar = '*';
            this._tboxPassword.Size = new System.Drawing.Size(138, 20);
            this._tboxPassword.TabIndex = 3;
            // 
            // _btnLogin
            // 
            this._btnLogin.Location = new System.Drawing.Point(136, 109);
            this._btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(136, 19);
            this._btnLogin.TabIndex = 4;
            this._btnLogin.Text = "Se connecter";
            this._btnLogin.UseVisualStyleBackColor = true;
            this._btnLogin.Click += new System.EventHandler(this._btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this._labelUserName);
            this.panel1.Controls.Add(this._labelPassword);
            this.panel1.Controls.Add(this._tboxUserName);
            this.panel1.Controls.Add(this._tboxPassword);
            this.panel1.Controls.Add(this._btnLogin);
            this.panel1.Location = new System.Drawing.Point(76, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 162);
            this.panel1.TabIndex = 5;
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(450, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _labelUserName;
        private System.Windows.Forms.Label _labelPassword;
        private System.Windows.Forms.TextBox _tboxUserName;
        private System.Windows.Forms.TextBox _tboxPassword;
        private System.Windows.Forms.Button _btnLogin;
        private System.Windows.Forms.Panel panel1;
    }
}
