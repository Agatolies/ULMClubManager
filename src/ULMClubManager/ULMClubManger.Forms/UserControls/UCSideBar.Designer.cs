
namespace ULMClubManger.Forms.UserControls
{
    partial class UCSideBar
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
            this._panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnMembers = new System.Windows.Forms.Button();
            this._panelMembersSubmenu = new System.Windows.Forms.Panel();
            this._btnMembersInfo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._btnBookings = new System.Windows.Forms.Button();
            this._panelBookingsSubmenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this._panelLogo.SuspendLayout();
            this._panelMembersSubmenu.SuspendLayout();
            this._panelBookingsSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelLogo
            // 
            this._panelLogo.BackColor = System.Drawing.Color.DarkSalmon;
            this._panelLogo.Controls.Add(this.panel1);
            this._panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelLogo.Location = new System.Drawing.Point(0, 0);
            this._panelLogo.Name = "_panelLogo";
            this._panelLogo.Size = new System.Drawing.Size(300, 100);
            this._panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 100);
            this.panel1.TabIndex = 1;
            // 
            // _btnMembers
            // 
            this._btnMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnMembers.FlatAppearance.BorderSize = 0;
            this._btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnMembers.Location = new System.Drawing.Point(0, 100);
            this._btnMembers.Margin = new System.Windows.Forms.Padding(0);
            this._btnMembers.Name = "_btnMembers";
            this._btnMembers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._btnMembers.Size = new System.Drawing.Size(300, 50);
            this._btnMembers.TabIndex = 1;
            this._btnMembers.Text = "Membres";
            this._btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnMembers.UseVisualStyleBackColor = false;
            this._btnMembers.Click += new System.EventHandler(this._btnMembers_Click);
            // 
            // _panelMembersSubmenu
            // 
            this._panelMembersSubmenu.Controls.Add(this.button2);
            this._panelMembersSubmenu.Controls.Add(this._btnMembersInfo);
            this._panelMembersSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelMembersSubmenu.Location = new System.Drawing.Point(0, 150);
            this._panelMembersSubmenu.Name = "_panelMembersSubmenu";
            this._panelMembersSubmenu.Size = new System.Drawing.Size(300, 90);
            this._panelMembersSubmenu.TabIndex = 2;
            // 
            // _btnMembersInfo
            // 
            this._btnMembersInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnMembersInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnMembersInfo.FlatAppearance.BorderSize = 0;
            this._btnMembersInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMembersInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnMembersInfo.Location = new System.Drawing.Point(0, 0);
            this._btnMembersInfo.Name = "_btnMembersInfo";
            this._btnMembersInfo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this._btnMembersInfo.Size = new System.Drawing.Size(300, 45);
            this._btnMembersInfo.TabIndex = 0;
            this._btnMembersInfo.Text = "Données Signalétiques";
            this._btnMembersInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnMembersInfo.UseVisualStyleBackColor = false;
            this._btnMembersInfo.Click += new System.EventHandler(this._btnMembersInfo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.button2.Location = new System.Drawing.Point(0, 45);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(300, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // _btnBookings
            // 
            this._btnBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._btnBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnBookings.FlatAppearance.BorderSize = 0;
            this._btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnBookings.Location = new System.Drawing.Point(0, 240);
            this._btnBookings.Margin = new System.Windows.Forms.Padding(0);
            this._btnBookings.Name = "_btnBookings";
            this._btnBookings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._btnBookings.Size = new System.Drawing.Size(300, 50);
            this._btnBookings.TabIndex = 3;
            this._btnBookings.Text = "Réservations";
            this._btnBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnBookings.UseVisualStyleBackColor = false;
            this._btnBookings.Click += new System.EventHandler(this._btnBookings_Click);
            // 
            // _panelBookingsSubmenu
            // 
            this._panelBookingsSubmenu.Controls.Add(this.button4);
            this._panelBookingsSubmenu.Controls.Add(this.button5);
            this._panelBookingsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelBookingsSubmenu.Location = new System.Drawing.Point(0, 290);
            this._panelBookingsSubmenu.Name = "_panelBookingsSubmenu";
            this._panelBookingsSubmenu.Size = new System.Drawing.Size(300, 90);
            this._panelBookingsSubmenu.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.button4.Location = new System.Drawing.Point(0, 45);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(300, 45);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(300, 45);
            this.button5.TabIndex = 0;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // UCSideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.Controls.Add(this._panelBookingsSubmenu);
            this.Controls.Add(this._btnBookings);
            this.Controls.Add(this._panelMembersSubmenu);
            this.Controls.Add(this._btnMembers);
            this.Controls.Add(this._panelLogo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCSideBar";
            this.Size = new System.Drawing.Size(300, 615);
            this._panelLogo.ResumeLayout(false);
            this._panelMembersSubmenu.ResumeLayout(false);
            this._panelBookingsSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnMembers;
        private System.Windows.Forms.Panel _panelMembersSubmenu;
        private System.Windows.Forms.Button _btnMembersInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button _btnBookings;
        private System.Windows.Forms.Panel _panelBookingsSubmenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
