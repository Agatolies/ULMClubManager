
namespace ULMClubManger.Forms.UserControls
{
    partial class UCBookingByMemberCRUD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this._labelBookingByMember_CRUD_Title1 = new System.Windows.Forms.Label();
            this._panelBookingByMember_CRUD_Title = new System.Windows.Forms.Panel();
            this._paneldgvBookingMemberCRUD = new System.Windows.Forms.Panel();
            this._panelBookingByMember_Details = new System.Windows.Forms.Panel();
            this._cboxBookingByMember_TimeSlotEnd = new System.Windows.Forms.ComboBox();
            this._cboxBookingByMember_TimeSlotStart = new System.Windows.Forms.ComboBox();
            this._cboxBookingByMember_Runway = new System.Windows.Forms.ComboBox();
            this._bsRunways = new System.Windows.Forms.BindingSource(this.components);
            this._labelBookingByMember_Runway = new System.Windows.Forms.Label();
            this._labelBookingByMember_Error = new System.Windows.Forms.Label();
            this._tboxBookingByMember_MemberName = new System.Windows.Forms.TextBox();
            this._labelBookingByMember_MemberName = new System.Windows.Forms.Label();
            this._labelBookingByMember_Aircraft = new System.Windows.Forms.Label();
            this._cboxBookingByMember_Aircraft = new System.Windows.Forms.ComboBox();
            this._bsAircrafts = new System.Windows.Forms.BindingSource(this.components);
            this._dtpBookingByMember_Date = new System.Windows.Forms.DateTimePicker();
            this._labelBookingByMember_EndHour = new System.Windows.Forms.Label();
            this._labelBookingByMember_StartHour = new System.Windows.Forms.Label();
            this._labelBookingByMember_Date = new System.Windows.Forms.Label();
            this._labelBookingByMember_Details = new System.Windows.Forms.Label();
            this._labelBookingByMember_NewBooking = new System.Windows.Forms.Label();
            this._dgvBookingByMemberCRUD = new System.Windows.Forms.DataGridView();
            this.aircraftRegistrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunwayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bsBookings = new System.Windows.Forms.BindingSource(this.components);
            this._panelBookingByMember_Update = new System.Windows.Forms.Panel();
            this._btnBookingByMembe_UpdateConfirm = new System.Windows.Forms.Button();
            this._btnBookingByMembe_UpdateDelete = new System.Windows.Forms.Button();
            this._panel_CRUD_BookingByMember_btn = new System.Windows.Forms.Panel();
            this._btnBookingByMemberCreate = new System.Windows.Forms.Button();
            this._btnBookingByMemberUpdate = new System.Windows.Forms.Button();
            this._btnBookingByMemberDelete = new System.Windows.Forms.Button();
            this._panelBookingByMember_Create = new System.Windows.Forms.Panel();
            this._btnBookingByMember_CreateConfirm = new System.Windows.Forms.Button();
            this._btnBookingByMember_CreateCancel = new System.Windows.Forms.Button();
            this._panelBookingByMember_CRUD_Title.SuspendLayout();
            this._paneldgvBookingMemberCRUD.SuspendLayout();
            this._panelBookingByMember_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bsRunways)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsAircrafts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookingByMemberCRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsBookings)).BeginInit();
            this._panelBookingByMember_Update.SuspendLayout();
            this._panel_CRUD_BookingByMember_btn.SuspendLayout();
            this._panelBookingByMember_Create.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelBookingByMember_CRUD_Title1
            // 
            this._labelBookingByMember_CRUD_Title1.AutoSize = true;
            this._labelBookingByMember_CRUD_Title1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByMember_CRUD_Title1.Location = new System.Drawing.Point(14, 5);
            this._labelBookingByMember_CRUD_Title1.Name = "_labelBookingByMember_CRUD_Title1";
            this._labelBookingByMember_CRUD_Title1.Size = new System.Drawing.Size(675, 36);
            this._labelBookingByMember_CRUD_Title1.TabIndex = 29;
            this._labelBookingByMember_CRUD_Title1.Text = "LISTE DES RESERVATIONS PAR MEMBRE";
            // 
            // _panelBookingByMember_CRUD_Title
            // 
            this._panelBookingByMember_CRUD_Title.Controls.Add(this._labelBookingByMember_CRUD_Title1);
            this._panelBookingByMember_CRUD_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelBookingByMember_CRUD_Title.Location = new System.Drawing.Point(0, 0);
            this._panelBookingByMember_CRUD_Title.Name = "_panelBookingByMember_CRUD_Title";
            this._panelBookingByMember_CRUD_Title.Size = new System.Drawing.Size(925, 54);
            this._panelBookingByMember_CRUD_Title.TabIndex = 32;
            // 
            // _paneldgvBookingMemberCRUD
            // 
            this._paneldgvBookingMemberCRUD.Controls.Add(this._panelBookingByMember_Details);
            this._paneldgvBookingMemberCRUD.Controls.Add(this._dgvBookingByMemberCRUD);
            this._paneldgvBookingMemberCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this._paneldgvBookingMemberCRUD.Location = new System.Drawing.Point(0, 54);
            this._paneldgvBookingMemberCRUD.Name = "_paneldgvBookingMemberCRUD";
            this._paneldgvBookingMemberCRUD.Size = new System.Drawing.Size(925, 991);
            this._paneldgvBookingMemberCRUD.TabIndex = 35;
            // 
            // _panelBookingByMember_Details
            // 
            this._panelBookingByMember_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelBookingByMember_Details.Controls.Add(this._cboxBookingByMember_TimeSlotEnd);
            this._panelBookingByMember_Details.Controls.Add(this._cboxBookingByMember_TimeSlotStart);
            this._panelBookingByMember_Details.Controls.Add(this._cboxBookingByMember_Runway);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_Runway);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_Error);
            this._panelBookingByMember_Details.Controls.Add(this._tboxBookingByMember_MemberName);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_MemberName);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_Aircraft);
            this._panelBookingByMember_Details.Controls.Add(this._cboxBookingByMember_Aircraft);
            this._panelBookingByMember_Details.Controls.Add(this._dtpBookingByMember_Date);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_EndHour);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_StartHour);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_Date);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_Details);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_NewBooking);
            this._panelBookingByMember_Details.Location = new System.Drawing.Point(20, 317);
            this._panelBookingByMember_Details.Name = "_panelBookingByMember_Details";
            this._panelBookingByMember_Details.Size = new System.Drawing.Size(877, 437);
            this._panelBookingByMember_Details.TabIndex = 34;
            // 
            // _cboxBookingByMember_TimeSlotEnd
            // 
            this._cboxBookingByMember_TimeSlotEnd.Enabled = false;
            this._cboxBookingByMember_TimeSlotEnd.FormattingEnabled = true;
            this._cboxBookingByMember_TimeSlotEnd.Location = new System.Drawing.Point(18, 276);
            this._cboxBookingByMember_TimeSlotEnd.Name = "_cboxBookingByMember_TimeSlotEnd";
            this._cboxBookingByMember_TimeSlotEnd.Size = new System.Drawing.Size(223, 21);
            this._cboxBookingByMember_TimeSlotEnd.TabIndex = 47;
            // 
            // _cboxBookingByMember_TimeSlotStart
            // 
            this._cboxBookingByMember_TimeSlotStart.Enabled = false;
            this._cboxBookingByMember_TimeSlotStart.FormattingEnabled = true;
            this._cboxBookingByMember_TimeSlotStart.Location = new System.Drawing.Point(18, 227);
            this._cboxBookingByMember_TimeSlotStart.Name = "_cboxBookingByMember_TimeSlotStart";
            this._cboxBookingByMember_TimeSlotStart.Size = new System.Drawing.Size(223, 21);
            this._cboxBookingByMember_TimeSlotStart.TabIndex = 46;
            this._cboxBookingByMember_TimeSlotStart.SelectedIndexChanged += new System.EventHandler(this._cboxBookingByMember_TimeSlotStart_SelectedIndexChanged);
            // 
            // _cboxBookingByMember_Runway
            // 
            this._cboxBookingByMember_Runway.DataSource = this._bsRunways;
            this._cboxBookingByMember_Runway.Enabled = false;
            this._cboxBookingByMember_Runway.FormattingEnabled = true;
            this._cboxBookingByMember_Runway.Location = new System.Drawing.Point(18, 329);
            this._cboxBookingByMember_Runway.Name = "_cboxBookingByMember_Runway";
            this._cboxBookingByMember_Runway.Size = new System.Drawing.Size(223, 21);
            this._cboxBookingByMember_Runway.TabIndex = 45;
            // 
            // _bsRunways
            // 
            this._bsRunways.DataSource = typeof(ULMClubManager.DTO.Runway);
            // 
            // _labelBookingByMember_Runway
            // 
            this._labelBookingByMember_Runway.AutoSize = true;
            this._labelBookingByMember_Runway.Location = new System.Drawing.Point(15, 313);
            this._labelBookingByMember_Runway.Name = "_labelBookingByMember_Runway";
            this._labelBookingByMember_Runway.Size = new System.Drawing.Size(30, 13);
            this._labelBookingByMember_Runway.TabIndex = 44;
            this._labelBookingByMember_Runway.Text = "Piste";
            // 
            // _labelBookingByMember_Error
            // 
            this._labelBookingByMember_Error.AutoSize = true;
            this._labelBookingByMember_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByMember_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this._labelBookingByMember_Error.Location = new System.Drawing.Point(15, 376);
            this._labelBookingByMember_Error.Name = "_labelBookingByMember_Error";
            this._labelBookingByMember_Error.Size = new System.Drawing.Size(231, 16);
            this._labelBookingByMember_Error.TabIndex = 43;
            this._labelBookingByMember_Error.Text = "ERROR MESSAGE GOES HERE";
            // 
            // _tboxBookingByMember_MemberName
            // 
            this._tboxBookingByMember_MemberName.Location = new System.Drawing.Point(18, 79);
            this._tboxBookingByMember_MemberName.Name = "_tboxBookingByMember_MemberName";
            this._tboxBookingByMember_MemberName.ReadOnly = true;
            this._tboxBookingByMember_MemberName.Size = new System.Drawing.Size(223, 20);
            this._tboxBookingByMember_MemberName.TabIndex = 41;
            // 
            // _labelBookingByMember_MemberName
            // 
            this._labelBookingByMember_MemberName.AutoSize = true;
            this._labelBookingByMember_MemberName.Location = new System.Drawing.Point(15, 63);
            this._labelBookingByMember_MemberName.Name = "_labelBookingByMember_MemberName";
            this._labelBookingByMember_MemberName.Size = new System.Drawing.Size(45, 13);
            this._labelBookingByMember_MemberName.TabIndex = 40;
            this._labelBookingByMember_MemberName.Text = "Membre";
            // 
            // _labelBookingByMember_Aircraft
            // 
            this._labelBookingByMember_Aircraft.AutoSize = true;
            this._labelBookingByMember_Aircraft.Location = new System.Drawing.Point(15, 111);
            this._labelBookingByMember_Aircraft.Name = "_labelBookingByMember_Aircraft";
            this._labelBookingByMember_Aircraft.Size = new System.Drawing.Size(30, 13);
            this._labelBookingByMember_Aircraft.TabIndex = 39;
            this._labelBookingByMember_Aircraft.Text = "ULM";
            // 
            // _cboxBookingByMember_Aircraft
            // 
            this._cboxBookingByMember_Aircraft.DataSource = this._bsAircrafts;
            this._cboxBookingByMember_Aircraft.Enabled = false;
            this._cboxBookingByMember_Aircraft.FormattingEnabled = true;
            this._cboxBookingByMember_Aircraft.Location = new System.Drawing.Point(18, 127);
            this._cboxBookingByMember_Aircraft.Name = "_cboxBookingByMember_Aircraft";
            this._cboxBookingByMember_Aircraft.Size = new System.Drawing.Size(223, 21);
            this._cboxBookingByMember_Aircraft.TabIndex = 38;
            // 
            // _dtpBookingByMember_Date
            // 
            this._dtpBookingByMember_Date.Enabled = false;
            this._dtpBookingByMember_Date.Location = new System.Drawing.Point(18, 177);
            this._dtpBookingByMember_Date.Name = "_dtpBookingByMember_Date";
            this._dtpBookingByMember_Date.Size = new System.Drawing.Size(223, 20);
            this._dtpBookingByMember_Date.TabIndex = 37;
            // 
            // _labelBookingByMember_EndHour
            // 
            this._labelBookingByMember_EndHour.AutoSize = true;
            this._labelBookingByMember_EndHour.Location = new System.Drawing.Point(15, 260);
            this._labelBookingByMember_EndHour.Name = "_labelBookingByMember_EndHour";
            this._labelBookingByMember_EndHour.Size = new System.Drawing.Size(65, 13);
            this._labelBookingByMember_EndHour.TabIndex = 36;
            this._labelBookingByMember_EndHour.Text = "Heure de fin";
            // 
            // _labelBookingByMember_StartHour
            // 
            this._labelBookingByMember_StartHour.AutoSize = true;
            this._labelBookingByMember_StartHour.Location = new System.Drawing.Point(15, 211);
            this._labelBookingByMember_StartHour.Name = "_labelBookingByMember_StartHour";
            this._labelBookingByMember_StartHour.Size = new System.Drawing.Size(81, 13);
            this._labelBookingByMember_StartHour.TabIndex = 34;
            this._labelBookingByMember_StartHour.Text = "Heure de début";
            // 
            // _labelBookingByMember_Date
            // 
            this._labelBookingByMember_Date.AutoSize = true;
            this._labelBookingByMember_Date.Location = new System.Drawing.Point(15, 161);
            this._labelBookingByMember_Date.Name = "_labelBookingByMember_Date";
            this._labelBookingByMember_Date.Size = new System.Drawing.Size(30, 13);
            this._labelBookingByMember_Date.TabIndex = 32;
            this._labelBookingByMember_Date.Text = "Date";
            // 
            // _labelBookingByMember_Details
            // 
            this._labelBookingByMember_Details.AutoSize = true;
            this._labelBookingByMember_Details.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByMember_Details.Location = new System.Drawing.Point(13, 12);
            this._labelBookingByMember_Details.Name = "_labelBookingByMember_Details";
            this._labelBookingByMember_Details.Size = new System.Drawing.Size(117, 27);
            this._labelBookingByMember_Details.TabIndex = 30;
            this._labelBookingByMember_Details.Text = "DETAILS";
            // 
            // _labelBookingByMember_NewBooking
            // 
            this._labelBookingByMember_NewBooking.AutoSize = true;
            this._labelBookingByMember_NewBooking.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByMember_NewBooking.Location = new System.Drawing.Point(13, 12);
            this._labelBookingByMember_NewBooking.Name = "_labelBookingByMember_NewBooking";
            this._labelBookingByMember_NewBooking.Size = new System.Drawing.Size(326, 27);
            this._labelBookingByMember_NewBooking.TabIndex = 48;
            this._labelBookingByMember_NewBooking.Text = "NOUVELLE RESERVATION";
            // 
            // _dgvBookingByMemberCRUD
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this._dgvBookingByMemberCRUD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this._dgvBookingByMemberCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvBookingByMemberCRUD.AutoGenerateColumns = false;
            this._dgvBookingByMemberCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvBookingByMemberCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvBookingByMemberCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._dgvBookingByMemberCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvBookingByMemberCRUD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aircraftRegistrationDataGridViewTextBoxColumn,
            this.Date,
            this.StartHour,
            this.EndHour,
            this.RunwayID});
            this._dgvBookingByMemberCRUD.DataSource = this._bsBookings;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgvBookingByMemberCRUD.DefaultCellStyle = dataGridViewCellStyle7;
            this._dgvBookingByMemberCRUD.GridColor = System.Drawing.Color.Gainsboro;
            this._dgvBookingByMemberCRUD.Location = new System.Drawing.Point(20, 19);
            this._dgvBookingByMemberCRUD.Name = "_dgvBookingByMemberCRUD";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvBookingByMemberCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this._dgvBookingByMemberCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgvBookingByMemberCRUD.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dgvBookingByMemberCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvBookingByMemberCRUD.Size = new System.Drawing.Size(877, 292);
            this._dgvBookingByMemberCRUD.TabIndex = 33;
            this._dgvBookingByMemberCRUD.SelectionChanged += new System.EventHandler(this._dgvBookingByMemberCRUD_SelectionChanged);
            // 
            // aircraftRegistrationDataGridViewTextBoxColumn
            // 
            this.aircraftRegistrationDataGridViewTextBoxColumn.DataPropertyName = "AircraftRegistration";
            this.aircraftRegistrationDataGridViewTextBoxColumn.HeaderText = "ULM";
            this.aircraftRegistrationDataGridViewTextBoxColumn.Name = "aircraftRegistrationDataGridViewTextBoxColumn";
            this.aircraftRegistrationDataGridViewTextBoxColumn.ReadOnly = true;
            this.aircraftRegistrationDataGridViewTextBoxColumn.Width = 135;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 135;
            // 
            // StartHour
            // 
            this.StartHour.DataPropertyName = "StartHour";
            this.StartHour.HeaderText = "Heure de début";
            this.StartHour.Name = "StartHour";
            this.StartHour.Width = 135;
            // 
            // EndHour
            // 
            this.EndHour.DataPropertyName = "EndHour";
            this.EndHour.HeaderText = "Heure de fin";
            this.EndHour.Name = "EndHour";
            this.EndHour.Width = 135;
            // 
            // RunwayID
            // 
            this.RunwayID.DataPropertyName = "RunwayID";
            this.RunwayID.HeaderText = "Piste";
            this.RunwayID.Name = "RunwayID";
            this.RunwayID.ReadOnly = true;
            this.RunwayID.Width = 135;
            // 
            // _bsBookings
            // 
            this._bsBookings.DataSource = typeof(ULMClubManager.DTO.DetailedBooking);
            // 
            // _panelBookingByMember_Update
            // 
            this._panelBookingByMember_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelBookingByMember_Update.Controls.Add(this._btnBookingByMembe_UpdateConfirm);
            this._panelBookingByMember_Update.Controls.Add(this._btnBookingByMembe_UpdateDelete);
            this._panelBookingByMember_Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBookingByMember_Update.Location = new System.Drawing.Point(0, 763);
            this._panelBookingByMember_Update.Name = "_panelBookingByMember_Update";
            this._panelBookingByMember_Update.Size = new System.Drawing.Size(925, 94);
            this._panelBookingByMember_Update.TabIndex = 37;
            // 
            // _btnBookingByMembe_UpdateConfirm
            // 
            this._btnBookingByMembe_UpdateConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnBookingByMembe_UpdateConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnBookingByMembe_UpdateConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBookingByMembe_UpdateConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBookingByMembe_UpdateConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnBookingByMembe_UpdateConfirm.Location = new System.Drawing.Point(18, 15);
            this._btnBookingByMembe_UpdateConfirm.Name = "_btnBookingByMembe_UpdateConfirm";
            this._btnBookingByMembe_UpdateConfirm.Size = new System.Drawing.Size(150, 61);
            this._btnBookingByMembe_UpdateConfirm.TabIndex = 29;
            this._btnBookingByMembe_UpdateConfirm.Text = "Sauvegarder";
            this._btnBookingByMembe_UpdateConfirm.UseVisualStyleBackColor = false;
            this._btnBookingByMembe_UpdateConfirm.Click += new System.EventHandler(this._btnBookingByMembe_UpdateConfirm_Click);
            // 
            // _btnBookingByMembe_UpdateDelete
            // 
            this._btnBookingByMembe_UpdateDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnBookingByMembe_UpdateDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnBookingByMembe_UpdateDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBookingByMembe_UpdateDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBookingByMembe_UpdateDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnBookingByMembe_UpdateDelete.Location = new System.Drawing.Point(198, 15);
            this._btnBookingByMembe_UpdateDelete.Name = "_btnBookingByMembe_UpdateDelete";
            this._btnBookingByMembe_UpdateDelete.Size = new System.Drawing.Size(150, 61);
            this._btnBookingByMembe_UpdateDelete.TabIndex = 31;
            this._btnBookingByMembe_UpdateDelete.Text = "Annuler";
            this._btnBookingByMembe_UpdateDelete.UseVisualStyleBackColor = false;
            this._btnBookingByMembe_UpdateDelete.Click += new System.EventHandler(this._btnBookingByMembe_UpdateDelete_Click);
            // 
            // _panel_CRUD_BookingByMember_btn
            // 
            this._panel_CRUD_BookingByMember_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panel_CRUD_BookingByMember_btn.Controls.Add(this._btnBookingByMemberCreate);
            this._panel_CRUD_BookingByMember_btn.Controls.Add(this._btnBookingByMemberUpdate);
            this._panel_CRUD_BookingByMember_btn.Controls.Add(this._btnBookingByMemberDelete);
            this._panel_CRUD_BookingByMember_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panel_CRUD_BookingByMember_btn.Location = new System.Drawing.Point(0, 951);
            this._panel_CRUD_BookingByMember_btn.Name = "_panel_CRUD_BookingByMember_btn";
            this._panel_CRUD_BookingByMember_btn.Size = new System.Drawing.Size(925, 94);
            this._panel_CRUD_BookingByMember_btn.TabIndex = 36;
            // 
            // _btnBookingByMemberCreate
            // 
            this._btnBookingByMemberCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnBookingByMemberCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnBookingByMemberCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBookingByMemberCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBookingByMemberCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnBookingByMemberCreate.Location = new System.Drawing.Point(18, 15);
            this._btnBookingByMemberCreate.Name = "_btnBookingByMemberCreate";
            this._btnBookingByMemberCreate.Size = new System.Drawing.Size(150, 61);
            this._btnBookingByMemberCreate.TabIndex = 29;
            this._btnBookingByMemberCreate.Text = "Ajouter";
            this._btnBookingByMemberCreate.UseVisualStyleBackColor = false;
            this._btnBookingByMemberCreate.Click += new System.EventHandler(this._btnBookingByMemberCreate_Click);
            // 
            // _btnBookingByMemberUpdate
            // 
            this._btnBookingByMemberUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnBookingByMemberUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnBookingByMemberUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBookingByMemberUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBookingByMemberUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnBookingByMemberUpdate.Location = new System.Drawing.Point(198, 15);
            this._btnBookingByMemberUpdate.Name = "_btnBookingByMemberUpdate";
            this._btnBookingByMemberUpdate.Size = new System.Drawing.Size(150, 61);
            this._btnBookingByMemberUpdate.TabIndex = 31;
            this._btnBookingByMemberUpdate.Text = "Modifier";
            this._btnBookingByMemberUpdate.UseVisualStyleBackColor = false;
            this._btnBookingByMemberUpdate.Click += new System.EventHandler(this._btnBookingByMemberUpdate_Click);
            // 
            // _btnBookingByMemberDelete
            // 
            this._btnBookingByMemberDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnBookingByMemberDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnBookingByMemberDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBookingByMemberDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBookingByMemberDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnBookingByMemberDelete.Location = new System.Drawing.Point(378, 15);
            this._btnBookingByMemberDelete.Name = "_btnBookingByMemberDelete";
            this._btnBookingByMemberDelete.Size = new System.Drawing.Size(150, 61);
            this._btnBookingByMemberDelete.TabIndex = 30;
            this._btnBookingByMemberDelete.Text = "Supprimer";
            this._btnBookingByMemberDelete.UseVisualStyleBackColor = false;
            this._btnBookingByMemberDelete.Click += new System.EventHandler(this._btnBookingByMemberDelete_Click);
            // 
            // _panelBookingByMember_Create
            // 
            this._panelBookingByMember_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelBookingByMember_Create.Controls.Add(this._btnBookingByMember_CreateConfirm);
            this._panelBookingByMember_Create.Controls.Add(this._btnBookingByMember_CreateCancel);
            this._panelBookingByMember_Create.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelBookingByMember_Create.Location = new System.Drawing.Point(0, 857);
            this._panelBookingByMember_Create.Name = "_panelBookingByMember_Create";
            this._panelBookingByMember_Create.Size = new System.Drawing.Size(925, 94);
            this._panelBookingByMember_Create.TabIndex = 37;
            // 
            // _btnBookingByMember_CreateConfirm
            // 
            this._btnBookingByMember_CreateConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnBookingByMember_CreateConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnBookingByMember_CreateConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBookingByMember_CreateConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBookingByMember_CreateConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnBookingByMember_CreateConfirm.Location = new System.Drawing.Point(18, 15);
            this._btnBookingByMember_CreateConfirm.Name = "_btnBookingByMember_CreateConfirm";
            this._btnBookingByMember_CreateConfirm.Size = new System.Drawing.Size(150, 61);
            this._btnBookingByMember_CreateConfirm.TabIndex = 29;
            this._btnBookingByMember_CreateConfirm.Text = "Créer";
            this._btnBookingByMember_CreateConfirm.UseVisualStyleBackColor = false;
            this._btnBookingByMember_CreateConfirm.Click += new System.EventHandler(this._btnBookingByMember_CreateConfirm_Click);
            // 
            // _btnBookingByMember_CreateCancel
            // 
            this._btnBookingByMember_CreateCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnBookingByMember_CreateCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnBookingByMember_CreateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBookingByMember_CreateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnBookingByMember_CreateCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnBookingByMember_CreateCancel.Location = new System.Drawing.Point(198, 15);
            this._btnBookingByMember_CreateCancel.Name = "_btnBookingByMember_CreateCancel";
            this._btnBookingByMember_CreateCancel.Size = new System.Drawing.Size(150, 61);
            this._btnBookingByMember_CreateCancel.TabIndex = 31;
            this._btnBookingByMember_CreateCancel.Text = "Annuler";
            this._btnBookingByMember_CreateCancel.UseVisualStyleBackColor = false;
            this._btnBookingByMember_CreateCancel.Click += new System.EventHandler(this._btnBookingByMember_CreateCancel_Click);
            // 
            // UCBookingByMemberCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this._panelBookingByMember_Update);
            this.Controls.Add(this._panelBookingByMember_Create);
            this.Controls.Add(this._panel_CRUD_BookingByMember_btn);
            this.Controls.Add(this._paneldgvBookingMemberCRUD);
            this.Controls.Add(this._panelBookingByMember_CRUD_Title);
            this.Name = "UCBookingByMemberCRUD";
            this.Size = new System.Drawing.Size(925, 1045);
            this._panelBookingByMember_CRUD_Title.ResumeLayout(false);
            this._panelBookingByMember_CRUD_Title.PerformLayout();
            this._paneldgvBookingMemberCRUD.ResumeLayout(false);
            this._panelBookingByMember_Details.ResumeLayout(false);
            this._panelBookingByMember_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bsRunways)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsAircrafts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookingByMemberCRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsBookings)).EndInit();
            this._panelBookingByMember_Update.ResumeLayout(false);
            this._panel_CRUD_BookingByMember_btn.ResumeLayout(false);
            this._panelBookingByMember_Create.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _labelBookingByMember_CRUD_Title1;
        private System.Windows.Forms.BindingSource _bsBookings;
        private System.Windows.Forms.Panel _panelBookingByMember_CRUD_Title;
        private System.Windows.Forms.Panel _paneldgvBookingMemberCRUD;
        private System.Windows.Forms.DataGridView _dgvBookingByMemberCRUD;
        private System.Windows.Forms.BindingSource _bsAircrafts;
        private System.Windows.Forms.Panel _panel_CRUD_BookingByMember_btn;
        private System.Windows.Forms.Button _btnBookingByMemberCreate;
        private System.Windows.Forms.Button _btnBookingByMemberUpdate;
        private System.Windows.Forms.Button _btnBookingByMemberDelete;
        private System.Windows.Forms.Panel _panelBookingByMember_Details;
        private System.Windows.Forms.Label _labelBookingByMember_Details;
        private System.Windows.Forms.Label _labelBookingByMember_Date;
        private System.Windows.Forms.Label _labelBookingByMember_EndHour;
        private System.Windows.Forms.Label _labelBookingByMember_StartHour;
        private System.Windows.Forms.DateTimePicker _dtpBookingByMember_Date;
        private System.Windows.Forms.ComboBox _cboxBookingByMember_Aircraft;
        private System.Windows.Forms.Label _labelBookingByMember_Aircraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircraftRegistrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunwayID;
        private System.Windows.Forms.Label _labelBookingByMember_MemberName;
        private System.Windows.Forms.Label _labelBookingByMember_Error;
        private System.Windows.Forms.Panel _panelBookingByMember_Update;
        private System.Windows.Forms.Button _btnBookingByMembe_UpdateConfirm;
        private System.Windows.Forms.Button _btnBookingByMembe_UpdateDelete;
        private System.Windows.Forms.Panel _panelBookingByMember_Create;
        private System.Windows.Forms.Button _btnBookingByMember_CreateConfirm;
        private System.Windows.Forms.Button _btnBookingByMember_CreateCancel;
        private System.Windows.Forms.BindingSource _bsRunways;
        private System.Windows.Forms.ComboBox _cboxBookingByMember_Runway;
        private System.Windows.Forms.Label _labelBookingByMember_Runway;
        private System.Windows.Forms.ComboBox _cboxBookingByMember_TimeSlotEnd;
        private System.Windows.Forms.ComboBox _cboxBookingByMember_TimeSlotStart;
        private System.Windows.Forms.TextBox _tboxBookingByMember_MemberName;
        private System.Windows.Forms.Label _labelBookingByMember_NewBooking;
    }
}
