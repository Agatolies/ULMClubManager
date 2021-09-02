
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSideBar));
            this._panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._btnMembers = new System.Windows.Forms.Button();
            this._panelMembersSubmenu = new System.Windows.Forms.Panel();
            this._btnMembersInfo = new System.Windows.Forms.Button();
            this._btnBookings = new System.Windows.Forms.Button();
            this._panelBookingsSubmenu = new System.Windows.Forms.Panel();
            this._btnBookingAircraft = new System.Windows.Forms.Button();
            this._btnBookingMember = new System.Windows.Forms.Button();
            this._btnClubManagement = new System.Windows.Forms.Button();
            this._panelClubManagementSubmenu = new System.Windows.Forms.Panel();
            this._btnFutureBookings = new System.Windows.Forms.Button();
            this._panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this._panelMembersSubmenu.SuspendLayout();
            this._panelBookingsSubmenu.SuspendLayout();
            this._panelClubManagementSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelLogo
            // 
            this._panelLogo.BackColor = System.Drawing.Color.DarkSalmon;
            this._panelLogo.Controls.Add(this.pictureBox1);
            this._panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelLogo.Location = new System.Drawing.Point(0, 0);
            this._panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this._panelLogo.Name = "_panelLogo";
            this._panelLogo.Size = new System.Drawing.Size(225, 130);
            this._panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _btnMembers
            // 
            this._btnMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnMembers.FlatAppearance.BorderSize = 0;
            this._btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMembers.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnMembers.Location = new System.Drawing.Point(0, 130);
            this._btnMembers.Margin = new System.Windows.Forms.Padding(0);
            this._btnMembers.Name = "_btnMembers";
            this._btnMembers.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this._btnMembers.Size = new System.Drawing.Size(225, 41);
            this._btnMembers.TabIndex = 1;
            this._btnMembers.Text = "Membres";
            this._btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnMembers.UseVisualStyleBackColor = false;
            this._btnMembers.Click += new System.EventHandler(this._btnMembers_Click);
            // 
            // _panelMembersSubmenu
            // 
            this._panelMembersSubmenu.Controls.Add(this._btnMembersInfo);
            this._panelMembersSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelMembersSubmenu.Location = new System.Drawing.Point(0, 171);
            this._panelMembersSubmenu.Margin = new System.Windows.Forms.Padding(2);
            this._panelMembersSubmenu.Name = "_panelMembersSubmenu";
            this._panelMembersSubmenu.Size = new System.Drawing.Size(225, 37);
            this._panelMembersSubmenu.TabIndex = 2;
            // 
            // _btnMembersInfo
            // 
            this._btnMembersInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnMembersInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnMembersInfo.FlatAppearance.BorderSize = 0;
            this._btnMembersInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMembersInfo.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMembersInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnMembersInfo.Location = new System.Drawing.Point(0, 0);
            this._btnMembersInfo.Margin = new System.Windows.Forms.Padding(2);
            this._btnMembersInfo.Name = "_btnMembersInfo";
            this._btnMembersInfo.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this._btnMembersInfo.Size = new System.Drawing.Size(225, 37);
            this._btnMembersInfo.TabIndex = 0;
            this._btnMembersInfo.Text = "Données Signalétiques";
            this._btnMembersInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnMembersInfo.UseVisualStyleBackColor = false;
            this._btnMembersInfo.Click += new System.EventHandler(this._btnMembersInfo_Click);
            // 
            // _btnBookings
            // 
            this._btnBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._btnBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnBookings.FlatAppearance.BorderSize = 0;
            this._btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBookings.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnBookings.Location = new System.Drawing.Point(0, 208);
            this._btnBookings.Margin = new System.Windows.Forms.Padding(0);
            this._btnBookings.Name = "_btnBookings";
            this._btnBookings.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this._btnBookings.Size = new System.Drawing.Size(225, 41);
            this._btnBookings.TabIndex = 3;
            this._btnBookings.Text = "Réservations";
            this._btnBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnBookings.UseVisualStyleBackColor = false;
            this._btnBookings.Click += new System.EventHandler(this._btnBookings_Click);
            // 
            // _panelBookingsSubmenu
            // 
            this._panelBookingsSubmenu.Controls.Add(this._btnBookingAircraft);
            this._panelBookingsSubmenu.Controls.Add(this._btnBookingMember);
            this._panelBookingsSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelBookingsSubmenu.Location = new System.Drawing.Point(0, 249);
            this._panelBookingsSubmenu.Margin = new System.Windows.Forms.Padding(2);
            this._panelBookingsSubmenu.Name = "_panelBookingsSubmenu";
            this._panelBookingsSubmenu.Size = new System.Drawing.Size(225, 74);
            this._panelBookingsSubmenu.TabIndex = 4;
            // 
            // _btnBookingAircraft
            // 
            this._btnBookingAircraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnBookingAircraft.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnBookingAircraft.FlatAppearance.BorderSize = 0;
            this._btnBookingAircraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBookingAircraft.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBookingAircraft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnBookingAircraft.Location = new System.Drawing.Point(0, 37);
            this._btnBookingAircraft.Margin = new System.Windows.Forms.Padding(2);
            this._btnBookingAircraft.Name = "_btnBookingAircraft";
            this._btnBookingAircraft.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this._btnBookingAircraft.Size = new System.Drawing.Size(225, 37);
            this._btnBookingAircraft.TabIndex = 1;
            this._btnBookingAircraft.Text = "Par ULM";
            this._btnBookingAircraft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnBookingAircraft.UseVisualStyleBackColor = false;
            this._btnBookingAircraft.Click += new System.EventHandler(this._btnBookingAircraft_Click);
            // 
            // _btnBookingMember
            // 
            this._btnBookingMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnBookingMember.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnBookingMember.FlatAppearance.BorderSize = 0;
            this._btnBookingMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBookingMember.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBookingMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnBookingMember.Location = new System.Drawing.Point(0, 0);
            this._btnBookingMember.Margin = new System.Windows.Forms.Padding(2);
            this._btnBookingMember.Name = "_btnBookingMember";
            this._btnBookingMember.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this._btnBookingMember.Size = new System.Drawing.Size(225, 37);
            this._btnBookingMember.TabIndex = 0;
            this._btnBookingMember.Text = "Par pilote";
            this._btnBookingMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnBookingMember.UseVisualStyleBackColor = false;
            this._btnBookingMember.Click += new System.EventHandler(this._btnBookingMember_Click);
            // 
            // _btnClubManagement
            // 
            this._btnClubManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._btnClubManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnClubManagement.FlatAppearance.BorderSize = 0;
            this._btnClubManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnClubManagement.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnClubManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnClubManagement.Location = new System.Drawing.Point(0, 323);
            this._btnClubManagement.Margin = new System.Windows.Forms.Padding(0);
            this._btnClubManagement.Name = "_btnClubManagement";
            this._btnClubManagement.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this._btnClubManagement.Size = new System.Drawing.Size(225, 41);
            this._btnClubManagement.TabIndex = 7;
            this._btnClubManagement.Text = "Consultations";
            this._btnClubManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnClubManagement.UseVisualStyleBackColor = false;
            this._btnClubManagement.Click += new System.EventHandler(this._btnClubManagement_Click);
            // 
            // _panelClubManagementSubmenu
            // 
            this._panelClubManagementSubmenu.Controls.Add(this._btnFutureBookings);
            this._panelClubManagementSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelClubManagementSubmenu.Location = new System.Drawing.Point(0, 364);
            this._panelClubManagementSubmenu.Margin = new System.Windows.Forms.Padding(2);
            this._panelClubManagementSubmenu.Name = "_panelClubManagementSubmenu";
            this._panelClubManagementSubmenu.Size = new System.Drawing.Size(225, 37);
            this._panelClubManagementSubmenu.TabIndex = 8;
            // 
            // _btnFutureBookings
            // 
            this._btnFutureBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnFutureBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnFutureBookings.FlatAppearance.BorderSize = 0;
            this._btnFutureBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnFutureBookings.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFutureBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnFutureBookings.Location = new System.Drawing.Point(0, 0);
            this._btnFutureBookings.Margin = new System.Windows.Forms.Padding(2);
            this._btnFutureBookings.Name = "_btnFutureBookings";
            this._btnFutureBookings.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this._btnFutureBookings.Size = new System.Drawing.Size(225, 37);
            this._btnFutureBookings.TabIndex = 0;
            this._btnFutureBookings.Text = "Réservations à venir";
            this._btnFutureBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnFutureBookings.UseVisualStyleBackColor = false;
            this._btnFutureBookings.Click += new System.EventHandler(this._btnFutureBookings_Click);
            // 
            // UCSideBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.Controls.Add(this._panelClubManagementSubmenu);
            this.Controls.Add(this._btnClubManagement);
            this.Controls.Add(this._panelBookingsSubmenu);
            this.Controls.Add(this._btnBookings);
            this.Controls.Add(this._panelMembersSubmenu);
            this.Controls.Add(this._btnMembers);
            this.Controls.Add(this._panelLogo);
            this.Name = "UCSideBar";
            this.Size = new System.Drawing.Size(225, 500);
            this._panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this._panelMembersSubmenu.ResumeLayout(false);
            this._panelBookingsSubmenu.ResumeLayout(false);
            this._panelClubManagementSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelLogo;
        private System.Windows.Forms.Button _btnMembers;
        private System.Windows.Forms.Panel _panelMembersSubmenu;
        private System.Windows.Forms.Button _btnMembersInfo;
        private System.Windows.Forms.Button _btnBookings;
        private System.Windows.Forms.Panel _panelBookingsSubmenu;
        private System.Windows.Forms.Button _btnBookingAircraft;
        private System.Windows.Forms.Button _btnBookingMember;
        private System.Windows.Forms.Button _btnClubManagement;
        private System.Windows.Forms.Panel _panelClubManagementSubmenu;
        private System.Windows.Forms.Button _btnFutureBookings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
