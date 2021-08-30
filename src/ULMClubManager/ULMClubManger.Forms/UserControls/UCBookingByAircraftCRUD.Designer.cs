
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this._panelBookingByAircraft_CRUD_Title = new System.Windows.Forms.Panel();
            this._labelBookingByAircraft_CRUD_Title = new System.Windows.Forms.Label();
            this._panelBookingByAircraftCRUD = new System.Windows.Forms.Panel();
            this._labelBookingByAircraft_CancellationTitle = new System.Windows.Forms.Label();
            this._dgvCancellationByAircraft = new System.Windows.Forms.DataGridView();
            this._bsCancellations = new System.Windows.Forms.BindingSource(this.components);
            this._dgvBookingByAircraftCRUD = new System.Windows.Forms.DataGridView();
            this._bsBookings = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AircraftRegistration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftCategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunwayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AircraftCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancellationReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._panelBookingByAircraft_CRUD_Title.SuspendLayout();
            this._panelBookingByAircraftCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvCancellationByAircraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsCancellations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookingByAircraftCRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsBookings)).BeginInit();
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
            this._panelBookingByAircraftCRUD.Controls.Add(this._labelBookingByAircraft_CancellationTitle);
            this._panelBookingByAircraftCRUD.Controls.Add(this._dgvCancellationByAircraft);
            this._panelBookingByAircraftCRUD.Controls.Add(this._dgvBookingByAircraftCRUD);
            this._panelBookingByAircraftCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelBookingByAircraftCRUD.Location = new System.Drawing.Point(0, 54);
            this._panelBookingByAircraftCRUD.Name = "_panelBookingByAircraftCRUD";
            this._panelBookingByAircraftCRUD.Size = new System.Drawing.Size(925, 510);
            this._panelBookingByAircraftCRUD.TabIndex = 34;
            // 
            // _labelBookingByAircraft_CancellationTitle
            // 
            this._labelBookingByAircraft_CancellationTitle.AutoSize = true;
            this._labelBookingByAircraft_CancellationTitle.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold);
            this._labelBookingByAircraft_CancellationTitle.Location = new System.Drawing.Point(15, 261);
            this._labelBookingByAircraft_CancellationTitle.Name = "_labelBookingByAircraft_CancellationTitle";
            this._labelBookingByAircraft_CancellationTitle.Size = new System.Drawing.Size(340, 27);
            this._labelBookingByAircraft_CancellationTitle.TabIndex = 38;
            this._labelBookingByAircraft_CancellationTitle.Text = "RESERVATIONS ANNULEES";
            // 
            // _dgvCancellationByAircraft
            // 
            this._dgvCancellationByAircraft.AllowUserToAddRows = false;
            this._dgvCancellationByAircraft.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this._dgvCancellationByAircraft.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dgvCancellationByAircraft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvCancellationByAircraft.AutoGenerateColumns = false;
            this._dgvCancellationByAircraft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvCancellationByAircraft.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvCancellationByAircraft.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dgvCancellationByAircraft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvCancellationByAircraft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn5,
            this.AircraftCategoryID,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn7,
            this.cancellationReasonDataGridViewTextBoxColumn});
            this._dgvCancellationByAircraft.DataSource = this._bsCancellations;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgvCancellationByAircraft.DefaultCellStyle = dataGridViewCellStyle3;
            this._dgvCancellationByAircraft.Enabled = false;
            this._dgvCancellationByAircraft.GridColor = System.Drawing.Color.Gainsboro;
            this._dgvCancellationByAircraft.Location = new System.Drawing.Point(20, 300);
            this._dgvCancellationByAircraft.Name = "_dgvCancellationByAircraft";
            this._dgvCancellationByAircraft.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvCancellationByAircraft.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._dgvCancellationByAircraft.RowHeadersVisible = false;
            this._dgvCancellationByAircraft.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgvCancellationByAircraft.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dgvCancellationByAircraft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvCancellationByAircraft.ShowEditingIcon = false;
            this._dgvCancellationByAircraft.Size = new System.Drawing.Size(877, 168);
            this._dgvCancellationByAircraft.TabIndex = 37;
            // 
            // _bsCancellations
            // 
            this._bsCancellations.DataSource = typeof(ULMClubManager.DTO.DetailedBooking);
            // 
            // _dgvBookingByAircraftCRUD
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this._dgvBookingByAircraftCRUD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this._dgvBookingByAircraftCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvBookingByAircraftCRUD.AutoGenerateColumns = false;
            this._dgvBookingByAircraftCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvBookingByAircraftCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvBookingByAircraftCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._dgvBookingByAircraftCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvBookingByAircraftCRUD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.AircraftRegistration,
            this.aircraftCategoryIDDataGridViewTextBoxColumn,
            this.MemberFullName,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.RunwayID});
            this._dgvBookingByAircraftCRUD.DataSource = this._bsBookings;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgvBookingByAircraftCRUD.DefaultCellStyle = dataGridViewCellStyle7;
            this._dgvBookingByAircraftCRUD.GridColor = System.Drawing.Color.Gainsboro;
            this._dgvBookingByAircraftCRUD.Location = new System.Drawing.Point(20, 19);
            this._dgvBookingByAircraftCRUD.Name = "_dgvBookingByAircraftCRUD";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvBookingByAircraftCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this._dgvBookingByAircraftCRUD.RowHeadersVisible = false;
            this._dgvBookingByAircraftCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgvBookingByAircraftCRUD.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dgvBookingByAircraftCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvBookingByAircraftCRUD.Size = new System.Drawing.Size(877, 227);
            this._dgvBookingByAircraftCRUD.TabIndex = 34;
            this._dgvBookingByAircraftCRUD.SelectionChanged += new System.EventHandler(this._dgvBookingByAircraftCRUD_SelectionChanged);
            // 
            // _bsBookings
            // 
            this._bsBookings.DataSource = typeof(ULMClubManager.DTO.DetailedBooking);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Num RES";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // AircraftRegistration
            // 
            this.AircraftRegistration.DataPropertyName = "AircraftRegistration";
            this.AircraftRegistration.HeaderText = "ULM";
            this.AircraftRegistration.Name = "AircraftRegistration";
            this.AircraftRegistration.ReadOnly = true;
            this.AircraftRegistration.Width = 80;
            // 
            // aircraftCategoryIDDataGridViewTextBoxColumn
            // 
            this.aircraftCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "AircraftCategoryID";
            this.aircraftCategoryIDDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.aircraftCategoryIDDataGridViewTextBoxColumn.Name = "aircraftCategoryIDDataGridViewTextBoxColumn";
            this.aircraftCategoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aircraftCategoryIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // MemberFullName
            // 
            this.MemberFullName.DataPropertyName = "MemberFullName";
            this.MemberFullName.HeaderText = "Pilote";
            this.MemberFullName.Name = "MemberFullName";
            this.MemberFullName.ReadOnly = true;
            this.MemberFullName.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartHour";
            this.dataGridViewTextBoxColumn3.HeaderText = "Heure de début";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 142;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EndHour";
            this.dataGridViewTextBoxColumn4.HeaderText = "Heure de fin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 143;
            // 
            // RunwayID
            // 
            this.RunwayID.DataPropertyName = "RunwayID";
            this.RunwayID.HeaderText = "Piste";
            this.RunwayID.Name = "RunwayID";
            this.RunwayID.ReadOnly = true;
            this.RunwayID.Width = 50;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Num RES";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AircraftRegistration";
            this.dataGridViewTextBoxColumn5.HeaderText = "ULM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // AircraftCategoryID
            // 
            this.AircraftCategoryID.DataPropertyName = "AircraftCategoryID";
            this.AircraftCategoryID.HeaderText = "Classe";
            this.AircraftCategoryID.Name = "AircraftCategoryID";
            this.AircraftCategoryID.ReadOnly = true;
            this.AircraftCategoryID.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MemberFullName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pilote";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "StartHour";
            this.dataGridViewTextBoxColumn9.HeaderText = "Heure de début";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 90;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "EndHour";
            this.dataGridViewTextBoxColumn10.HeaderText = "Heure de fin";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RunwayID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Piste";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // cancellationReasonDataGridViewTextBoxColumn
            // 
            this.cancellationReasonDataGridViewTextBoxColumn.DataPropertyName = "CancellationReason";
            this.cancellationReasonDataGridViewTextBoxColumn.HeaderText = "Motif";
            this.cancellationReasonDataGridViewTextBoxColumn.Name = "cancellationReasonDataGridViewTextBoxColumn";
            this.cancellationReasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.cancellationReasonDataGridViewTextBoxColumn.Width = 155;
            // 
            // UCBookingByAircraftCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this._panelBookingByAircraftCRUD);
            this.Controls.Add(this._panelBookingByAircraft_CRUD_Title);
            this.Name = "UCBookingByAircraftCRUD";
            this.Size = new System.Drawing.Size(925, 564);
            this._panelBookingByAircraft_CRUD_Title.ResumeLayout(false);
            this._panelBookingByAircraft_CRUD_Title.PerformLayout();
            this._panelBookingByAircraftCRUD.ResumeLayout(false);
            this._panelBookingByAircraftCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvCancellationByAircraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsCancellations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookingByAircraftCRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelBookingByAircraft_CRUD_Title;
        private System.Windows.Forms.Label _labelBookingByAircraft_CRUD_Title;
        private System.Windows.Forms.Panel _panelBookingByAircraftCRUD;
        private System.Windows.Forms.BindingSource _bsBookings;
        private System.Windows.Forms.DataGridView _dgvBookingByAircraftCRUD;
        private System.Windows.Forms.BindingSource _bsCancellations;
        private System.Windows.Forms.Label _labelBookingByAircraft_CancellationTitle;
        private System.Windows.Forms.DataGridView _dgvCancellationByAircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AircraftRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircraftCategoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunwayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn AircraftCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancellationReasonDataGridViewTextBoxColumn;
    }
}
