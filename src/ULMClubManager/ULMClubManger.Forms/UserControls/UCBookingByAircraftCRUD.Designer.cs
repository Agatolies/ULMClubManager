
namespace ULMClubManger.Forms.UserControls
{
    partial class UCBookingByAircraftCRUD
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
            this._panelBookingByAircraft_CRUD_Title = new System.Windows.Forms.Panel();
            this._labelBookingByAircraft_CRUD_Title = new System.Windows.Forms.Label();
            this._panelBookingByAircraftCRUD = new System.Windows.Forms.Panel();
            this._dgvBookingByAircraftCRUD = new System.Windows.Forms.DataGridView();
            this.aircraftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runwayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._panelBookingByAircraft_CRUD_Title.SuspendLayout();
            this._panelBookingByAircraftCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookingByAircraftCRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runwayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _panelBookingByAircraft_CRUD_Title
            // 
            this._panelBookingByAircraft_CRUD_Title.BackColor = System.Drawing.Color.WhiteSmoke;
            this._panelBookingByAircraft_CRUD_Title.Controls.Add(this._labelBookingByAircraft_CRUD_Title);
            this._panelBookingByAircraft_CRUD_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelBookingByAircraft_CRUD_Title.Location = new System.Drawing.Point(0, 0);
            this._panelBookingByAircraft_CRUD_Title.Name = "_panelBookingByAircraft_CRUD_Title";
            this._panelBookingByAircraft_CRUD_Title.Size = new System.Drawing.Size(925, 54);
            this._panelBookingByAircraft_CRUD_Title.TabIndex = 33;
            // 
            // _labelBookingByAircraft_CRUD_Title
            // 
            this._labelBookingByAircraft_CRUD_Title.AutoSize = true;
            this._labelBookingByAircraft_CRUD_Title.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByAircraft_CRUD_Title.Location = new System.Drawing.Point(14, 5);
            this._labelBookingByAircraft_CRUD_Title.Name = "_labelBookingByAircraft_CRUD_Title";
            this._labelBookingByAircraft_CRUD_Title.Size = new System.Drawing.Size(605, 36);
            this._labelBookingByAircraft_CRUD_Title.TabIndex = 29;
            this._labelBookingByAircraft_CRUD_Title.Text = "LISTE DES RESERVATIONS PAR ULM";
            // 
            // _panelBookingByAircraftCRUD
            // 
            this._panelBookingByAircraftCRUD.BackColor = System.Drawing.Color.WhiteSmoke;
            this._panelBookingByAircraftCRUD.Controls.Add(this._dgvBookingByAircraftCRUD);
            this._panelBookingByAircraftCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelBookingByAircraftCRUD.Location = new System.Drawing.Point(0, 54);
            this._panelBookingByAircraftCRUD.Name = "_panelBookingByAircraftCRUD";
            this._panelBookingByAircraftCRUD.Size = new System.Drawing.Size(925, 991);
            this._panelBookingByAircraftCRUD.TabIndex = 34;
            // 
            // _dgvBookingByAircraftCRUD
            // 
            this._dgvBookingByAircraftCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvBookingByAircraftCRUD.AutoGenerateColumns = false;
            this._dgvBookingByAircraftCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvBookingByAircraftCRUD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.Date,
            this.StartHour,
            this.EndHour,
            this.ID,
            this.LastName,
            this.FirstName,
            this.Column1});
            this._dgvBookingByAircraftCRUD.DataSource = this.runwayBindingSource;
            this._dgvBookingByAircraftCRUD.Location = new System.Drawing.Point(20, 17);
            this._dgvBookingByAircraftCRUD.Name = "_dgvBookingByAircraftCRUD";
            this._dgvBookingByAircraftCRUD.Size = new System.Drawing.Size(853, 755);
            this._dgvBookingByAircraftCRUD.TabIndex = 0;
            // 
            // aircraftBindingSource
            // 
            this.aircraftBindingSource.DataSource = typeof(ULMClubManager.DTO.Aircraft);
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(ULMClubManager.DTO.Booking);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(ULMClubManager.DTO.Member);
            // 
            // runwayBindingSource
            // 
            this.runwayBindingSource.DataSource = typeof(ULMClubManager.DTO.Runway);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "Réservation ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // StartHour
            // 
            this.StartHour.DataPropertyName = "Heure de début";
            this.StartHour.HeaderText = "StartHour";
            this.StartHour.Name = "StartHour";
            // 
            // EndHour
            // 
            this.EndHour.DataPropertyName = "Heure de fin";
            this.EndHour.HeaderText = "EndHour";
            this.EndHour.Name = "EndHour";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Pilote ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "Nom";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "Prénom";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Piste";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // UCBookingByAircraftCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this._panelBookingByAircraftCRUD);
            this.Controls.Add(this._panelBookingByAircraft_CRUD_Title);
            this.Name = "UCBookingByAircraftCRUD";
            this.Size = new System.Drawing.Size(925, 1045);
            this._panelBookingByAircraft_CRUD_Title.ResumeLayout(false);
            this._panelBookingByAircraft_CRUD_Title.PerformLayout();
            this._panelBookingByAircraftCRUD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookingByAircraftCRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runwayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelBookingByAircraft_CRUD_Title;
        private System.Windows.Forms.Label _labelBookingByAircraft_CRUD_Title;
        private System.Windows.Forms.Panel _panelBookingByAircraftCRUD;
        private System.Windows.Forms.DataGridView _dgvBookingByAircraftCRUD;
        private System.Windows.Forms.BindingSource aircraftBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.BindingSource runwayBindingSource;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.BindingSource memberBindingSource;
    }
}
