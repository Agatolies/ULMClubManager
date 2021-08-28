
namespace ULMClubManger.Forms.UserControls
{
    partial class UCBookingByMemberDetailsForm
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
            this._dtpBookingByMember_Date = new System.Windows.Forms.DateTimePicker();
            this._cboxBookingByMember_Aircraft = new System.Windows.Forms.ComboBox();
            this._bsAircrafts = new System.Windows.Forms.BindingSource(this.components);
            this._cboxBookingByMember_Runway = new System.Windows.Forms.ComboBox();
            this._bsRunways = new System.Windows.Forms.BindingSource(this.components);
            this._cboxBookingByMember_TimeSlotStart = new System.Windows.Forms.ComboBox();
            this._cboxBookingByMember_TimeSlotEnd = new System.Windows.Forms.ComboBox();
            this._btnFooterBookingByMemberCancel = new System.Windows.Forms.Button();
            this._btnFooterBookingByMemberUpdate = new System.Windows.Forms.Button();
            this._btnFooterBookingByMemberCreate = new System.Windows.Forms.Button();
            this._panelFooterBookingByMemberCRUD = new System.Windows.Forms.Panel();
            this._btnFooterBookingByMember_CreateCancel = new System.Windows.Forms.Button();
            this._btnFooterBookingByMember_CreateConfirm = new System.Windows.Forms.Button();
            this._panelFooterBookingByMember_Create = new System.Windows.Forms.Panel();
            this._btnFooterBookingByMember_UpdateDelete = new System.Windows.Forms.Button();
            this._btnFooterBookingByMember_UpdateConfirm = new System.Windows.Forms.Button();
            this._panelFooterBookingByMember_Update = new System.Windows.Forms.Panel();
            this._btnFooterBookingByMember_CancelCancel = new System.Windows.Forms.Button();
            this._btnFooterBookingByMember_CancelConfirm = new System.Windows.Forms.Button();
            this._panelFooterBookingByMember_Cancel = new System.Windows.Forms.Panel();
            this._labelBookingByMember_Error = new System.Windows.Forms.Label();
            this._panelBookingByMember_Details = new System.Windows.Forms.Panel();
            this._tboxlBookingByMember_CancellationReason = new System.Windows.Forms.TextBox();
            this._labelBookingByMember_CancellationReason = new System.Windows.Forms.Label();
            this._labelBookingByMember_Runway = new System.Windows.Forms.Label();
            this._labelBookingByMember_MemberName = new System.Windows.Forms.Label();
            this._labelBookingByMember_Aircraft = new System.Windows.Forms.Label();
            this._labelBookingByMember_EndHour = new System.Windows.Forms.Label();
            this._labelBookingByMember_StartHour = new System.Windows.Forms.Label();
            this._labelBookingByMember_Date = new System.Windows.Forms.Label();
            this._labelBookingByMember_NewBooking = new System.Windows.Forms.Label();
            this._labelBookingByMember_Update = new System.Windows.Forms.Label();
            this._labelBookingByMember_Cancellation = new System.Windows.Forms.Label();
            this._labelBookingByMBR_MemberName = new System.Windows.Forms.Label();
            this._labelBookingByMBR_AircraftRegistration = new System.Windows.Forms.Label();
            this._labelBookingByMBR_Runway = new System.Windows.Forms.Label();
            this._labelBookingByMBR_Date = new System.Windows.Forms.Label();
            this._labelBookingByMBR_StartHour = new System.Windows.Forms.Label();
            this._labelBookingByMBR_EndHour = new System.Windows.Forms.Label();
            this._labelBookingByMBR_CancellationReason = new System.Windows.Forms.Label();
            this._tboxBookingByMBR_CancellationReason = new System.Windows.Forms.TextBox();
            this._labelBookingByMBR_ErrorMessage = new System.Windows.Forms.Label();
            this._labelBookingByMBR_DetailsTitle = new System.Windows.Forms.Label();
            this._panelBookingByMBR_Details = new System.Windows.Forms.Panel();
            this._cboxBookingByMember_MemberName = new System.Windows.Forms.ComboBox();
            this._bsPilots = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._bsAircrafts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsRunways)).BeginInit();
            this._panelFooterBookingByMemberCRUD.SuspendLayout();
            this._panelFooterBookingByMember_Create.SuspendLayout();
            this._panelFooterBookingByMember_Update.SuspendLayout();
            this._panelFooterBookingByMember_Cancel.SuspendLayout();
            this._panelBookingByMember_Details.SuspendLayout();
            this._panelBookingByMBR_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bsPilots)).BeginInit();
            this.SuspendLayout();
            // 
            // _dtpBookingByMember_Date
            // 
            this._dtpBookingByMember_Date.Enabled = false;
            this._dtpBookingByMember_Date.Location = new System.Drawing.Point(301, 60);
            this._dtpBookingByMember_Date.Name = "_dtpBookingByMember_Date";
            this._dtpBookingByMember_Date.Size = new System.Drawing.Size(223, 20);
            this._dtpBookingByMember_Date.TabIndex = 37;
            // 
            // _cboxBookingByMember_Aircraft
            // 
            this._cboxBookingByMember_Aircraft.DataSource = this._bsAircrafts;
            this._cboxBookingByMember_Aircraft.Enabled = false;
            this._cboxBookingByMember_Aircraft.FormattingEnabled = true;
            this._cboxBookingByMember_Aircraft.Location = new System.Drawing.Point(18, 108);
            this._cboxBookingByMember_Aircraft.Name = "_cboxBookingByMember_Aircraft";
            this._cboxBookingByMember_Aircraft.Size = new System.Drawing.Size(223, 21);
            this._cboxBookingByMember_Aircraft.TabIndex = 38;
            // 
            // _bsAircrafts
            // 
            this._bsAircrafts.DataSource = typeof(ULMClubManager.DTO.Aircraft);
            // 
            // _cboxBookingByMember_Runway
            // 
            this._cboxBookingByMember_Runway.DataSource = this._bsRunways;
            this._cboxBookingByMember_Runway.Enabled = false;
            this._cboxBookingByMember_Runway.FormattingEnabled = true;
            this._cboxBookingByMember_Runway.Location = new System.Drawing.Point(18, 155);
            this._cboxBookingByMember_Runway.Name = "_cboxBookingByMember_Runway";
            this._cboxBookingByMember_Runway.Size = new System.Drawing.Size(223, 21);
            this._cboxBookingByMember_Runway.TabIndex = 45;
            // 
            // _bsRunways
            // 
            this._bsRunways.DataSource = typeof(ULMClubManager.DTO.Runway);
            // 
            // _cboxBookingByMember_TimeSlotStart
            // 
            this._cboxBookingByMember_TimeSlotStart.Enabled = false;
            this._cboxBookingByMember_TimeSlotStart.FormattingEnabled = true;
            this._cboxBookingByMember_TimeSlotStart.Location = new System.Drawing.Point(301, 110);
            this._cboxBookingByMember_TimeSlotStart.Name = "_cboxBookingByMember_TimeSlotStart";
            this._cboxBookingByMember_TimeSlotStart.Size = new System.Drawing.Size(223, 21);
            this._cboxBookingByMember_TimeSlotStart.TabIndex = 46;
            this._cboxBookingByMember_TimeSlotStart.SelectedIndexChanged += new System.EventHandler(this._cboxBookingByMember_TimeSlotStart_SelectedIndexChanged);
            // 
            // _cboxBookingByMember_TimeSlotEnd
            // 
            this._cboxBookingByMember_TimeSlotEnd.Enabled = false;
            this._cboxBookingByMember_TimeSlotEnd.FormattingEnabled = true;
            this._cboxBookingByMember_TimeSlotEnd.Location = new System.Drawing.Point(301, 159);
            this._cboxBookingByMember_TimeSlotEnd.Name = "_cboxBookingByMember_TimeSlotEnd";
            this._cboxBookingByMember_TimeSlotEnd.Size = new System.Drawing.Size(223, 21);
            this._cboxBookingByMember_TimeSlotEnd.TabIndex = 47;
            // 
            // _btnFooterBookingByMemberCancel
            // 
            this._btnFooterBookingByMemberCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnFooterBookingByMemberCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnFooterBookingByMemberCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnFooterBookingByMemberCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFooterBookingByMemberCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnFooterBookingByMemberCancel.Location = new System.Drawing.Point(378, 15);
            this._btnFooterBookingByMemberCancel.Name = "_btnFooterBookingByMemberCancel";
            this._btnFooterBookingByMemberCancel.Size = new System.Drawing.Size(150, 61);
            this._btnFooterBookingByMemberCancel.TabIndex = 30;
            this._btnFooterBookingByMemberCancel.Text = "Annuler";
            this._btnFooterBookingByMemberCancel.UseVisualStyleBackColor = false;
            this._btnFooterBookingByMemberCancel.Click += new System.EventHandler(this._btnFooterBookingByMemberCancel_Click);
            // 
            // _btnFooterBookingByMemberUpdate
            // 
            this._btnFooterBookingByMemberUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnFooterBookingByMemberUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnFooterBookingByMemberUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnFooterBookingByMemberUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFooterBookingByMemberUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnFooterBookingByMemberUpdate.Location = new System.Drawing.Point(198, 15);
            this._btnFooterBookingByMemberUpdate.Name = "_btnFooterBookingByMemberUpdate";
            this._btnFooterBookingByMemberUpdate.Size = new System.Drawing.Size(150, 61);
            this._btnFooterBookingByMemberUpdate.TabIndex = 31;
            this._btnFooterBookingByMemberUpdate.Text = "Modifier";
            this._btnFooterBookingByMemberUpdate.UseVisualStyleBackColor = false;
            this._btnFooterBookingByMemberUpdate.Click += new System.EventHandler(this._btnFooterBookingByMemberUpdate_Click);
            // 
            // _btnFooterBookingByMemberCreate
            // 
            this._btnFooterBookingByMemberCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnFooterBookingByMemberCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnFooterBookingByMemberCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnFooterBookingByMemberCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFooterBookingByMemberCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnFooterBookingByMemberCreate.Location = new System.Drawing.Point(18, 15);
            this._btnFooterBookingByMemberCreate.Name = "_btnFooterBookingByMemberCreate";
            this._btnFooterBookingByMemberCreate.Size = new System.Drawing.Size(150, 61);
            this._btnFooterBookingByMemberCreate.TabIndex = 29;
            this._btnFooterBookingByMemberCreate.Text = "Ajouter";
            this._btnFooterBookingByMemberCreate.UseVisualStyleBackColor = false;
            this._btnFooterBookingByMemberCreate.Click += new System.EventHandler(this._btnFooterBookingByMemberCreate_Click);
            // 
            // _panelFooterBookingByMemberCRUD
            // 
            this._panelFooterBookingByMemberCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelFooterBookingByMemberCRUD.Controls.Add(this._btnFooterBookingByMemberCreate);
            this._panelFooterBookingByMemberCRUD.Controls.Add(this._btnFooterBookingByMemberUpdate);
            this._panelFooterBookingByMemberCRUD.Controls.Add(this._btnFooterBookingByMemberCancel);
            this._panelFooterBookingByMemberCRUD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelFooterBookingByMemberCRUD.Location = new System.Drawing.Point(0, 538);
            this._panelFooterBookingByMemberCRUD.Name = "_panelFooterBookingByMemberCRUD";
            this._panelFooterBookingByMemberCRUD.Size = new System.Drawing.Size(925, 94);
            this._panelFooterBookingByMemberCRUD.TabIndex = 36;
            // 
            // _btnFooterBookingByMember_CreateCancel
            // 
            this._btnFooterBookingByMember_CreateCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnFooterBookingByMember_CreateCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnFooterBookingByMember_CreateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnFooterBookingByMember_CreateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFooterBookingByMember_CreateCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnFooterBookingByMember_CreateCancel.Location = new System.Drawing.Point(198, 15);
            this._btnFooterBookingByMember_CreateCancel.Name = "_btnFooterBookingByMember_CreateCancel";
            this._btnFooterBookingByMember_CreateCancel.Size = new System.Drawing.Size(150, 61);
            this._btnFooterBookingByMember_CreateCancel.TabIndex = 31;
            this._btnFooterBookingByMember_CreateCancel.Text = "Annuler";
            this._btnFooterBookingByMember_CreateCancel.UseVisualStyleBackColor = false;
            this._btnFooterBookingByMember_CreateCancel.Click += new System.EventHandler(this._btnFooterBookingByMember_CreateCancel_Click);
            // 
            // _btnFooterBookingByMember_CreateConfirm
            // 
            this._btnFooterBookingByMember_CreateConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnFooterBookingByMember_CreateConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnFooterBookingByMember_CreateConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnFooterBookingByMember_CreateConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFooterBookingByMember_CreateConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnFooterBookingByMember_CreateConfirm.Location = new System.Drawing.Point(18, 15);
            this._btnFooterBookingByMember_CreateConfirm.Name = "_btnFooterBookingByMember_CreateConfirm";
            this._btnFooterBookingByMember_CreateConfirm.Size = new System.Drawing.Size(150, 61);
            this._btnFooterBookingByMember_CreateConfirm.TabIndex = 29;
            this._btnFooterBookingByMember_CreateConfirm.Text = "Créer";
            this._btnFooterBookingByMember_CreateConfirm.UseVisualStyleBackColor = false;
            this._btnFooterBookingByMember_CreateConfirm.Click += new System.EventHandler(this._btnFooterBookingByMember_CreateConfirm_Click);
            // 
            // _panelFooterBookingByMember_Create
            // 
            this._panelFooterBookingByMember_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelFooterBookingByMember_Create.Controls.Add(this._btnFooterBookingByMember_CreateConfirm);
            this._panelFooterBookingByMember_Create.Controls.Add(this._btnFooterBookingByMember_CreateCancel);
            this._panelFooterBookingByMember_Create.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelFooterBookingByMember_Create.Location = new System.Drawing.Point(0, 444);
            this._panelFooterBookingByMember_Create.Name = "_panelFooterBookingByMember_Create";
            this._panelFooterBookingByMember_Create.Size = new System.Drawing.Size(925, 94);
            this._panelFooterBookingByMember_Create.TabIndex = 37;
            this._panelFooterBookingByMember_Create.Visible = false;
            // 
            // _btnFooterBookingByMember_UpdateDelete
            // 
            this._btnFooterBookingByMember_UpdateDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnFooterBookingByMember_UpdateDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnFooterBookingByMember_UpdateDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnFooterBookingByMember_UpdateDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFooterBookingByMember_UpdateDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnFooterBookingByMember_UpdateDelete.Location = new System.Drawing.Point(198, 15);
            this._btnFooterBookingByMember_UpdateDelete.Name = "_btnFooterBookingByMember_UpdateDelete";
            this._btnFooterBookingByMember_UpdateDelete.Size = new System.Drawing.Size(150, 61);
            this._btnFooterBookingByMember_UpdateDelete.TabIndex = 31;
            this._btnFooterBookingByMember_UpdateDelete.Text = "Annuler";
            this._btnFooterBookingByMember_UpdateDelete.UseVisualStyleBackColor = false;
            this._btnFooterBookingByMember_UpdateDelete.Click += new System.EventHandler(this._btnFooterBookingByMember_UpdateDelete_Click);
            // 
            // _btnFooterBookingByMember_UpdateConfirm
            // 
            this._btnFooterBookingByMember_UpdateConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnFooterBookingByMember_UpdateConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnFooterBookingByMember_UpdateConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnFooterBookingByMember_UpdateConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFooterBookingByMember_UpdateConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnFooterBookingByMember_UpdateConfirm.Location = new System.Drawing.Point(18, 15);
            this._btnFooterBookingByMember_UpdateConfirm.Name = "_btnFooterBookingByMember_UpdateConfirm";
            this._btnFooterBookingByMember_UpdateConfirm.Size = new System.Drawing.Size(150, 61);
            this._btnFooterBookingByMember_UpdateConfirm.TabIndex = 29;
            this._btnFooterBookingByMember_UpdateConfirm.Text = "Sauvegarder";
            this._btnFooterBookingByMember_UpdateConfirm.UseVisualStyleBackColor = false;
            this._btnFooterBookingByMember_UpdateConfirm.Click += new System.EventHandler(this._btnFooterBookingByMember_UpdateConfirm_Click);
            // 
            // _panelFooterBookingByMember_Update
            // 
            this._panelFooterBookingByMember_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelFooterBookingByMember_Update.Controls.Add(this._btnFooterBookingByMember_UpdateConfirm);
            this._panelFooterBookingByMember_Update.Controls.Add(this._btnFooterBookingByMember_UpdateDelete);
            this._panelFooterBookingByMember_Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelFooterBookingByMember_Update.Location = new System.Drawing.Point(0, 350);
            this._panelFooterBookingByMember_Update.Name = "_panelFooterBookingByMember_Update";
            this._panelFooterBookingByMember_Update.Size = new System.Drawing.Size(925, 94);
            this._panelFooterBookingByMember_Update.TabIndex = 37;
            this._panelFooterBookingByMember_Update.Visible = false;
            // 
            // _btnFooterBookingByMember_CancelCancel
            // 
            this._btnFooterBookingByMember_CancelCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnFooterBookingByMember_CancelCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnFooterBookingByMember_CancelCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnFooterBookingByMember_CancelCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFooterBookingByMember_CancelCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnFooterBookingByMember_CancelCancel.Location = new System.Drawing.Point(198, 15);
            this._btnFooterBookingByMember_CancelCancel.Name = "_btnFooterBookingByMember_CancelCancel";
            this._btnFooterBookingByMember_CancelCancel.Size = new System.Drawing.Size(150, 61);
            this._btnFooterBookingByMember_CancelCancel.TabIndex = 31;
            this._btnFooterBookingByMember_CancelCancel.Text = "Annuler";
            this._btnFooterBookingByMember_CancelCancel.UseVisualStyleBackColor = false;
            this._btnFooterBookingByMember_CancelCancel.Click += new System.EventHandler(this._btnFooterBookingByMember_CancelCancel_Click);
            // 
            // _btnFooterBookingByMember_CancelConfirm
            // 
            this._btnFooterBookingByMember_CancelConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnFooterBookingByMember_CancelConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnFooterBookingByMember_CancelConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnFooterBookingByMember_CancelConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFooterBookingByMember_CancelConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnFooterBookingByMember_CancelConfirm.Location = new System.Drawing.Point(18, 15);
            this._btnFooterBookingByMember_CancelConfirm.Name = "_btnFooterBookingByMember_CancelConfirm";
            this._btnFooterBookingByMember_CancelConfirm.Size = new System.Drawing.Size(150, 61);
            this._btnFooterBookingByMember_CancelConfirm.TabIndex = 29;
            this._btnFooterBookingByMember_CancelConfirm.Text = "Sauvegarder";
            this._btnFooterBookingByMember_CancelConfirm.UseVisualStyleBackColor = false;
            this._btnFooterBookingByMember_CancelConfirm.Click += new System.EventHandler(this._btnFooterBookingByMember_CancelConfirm_Click);
            // 
            // _panelFooterBookingByMember_Cancel
            // 
            this._panelFooterBookingByMember_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelFooterBookingByMember_Cancel.Controls.Add(this._btnFooterBookingByMember_CancelConfirm);
            this._panelFooterBookingByMember_Cancel.Controls.Add(this._btnFooterBookingByMember_CancelCancel);
            this._panelFooterBookingByMember_Cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelFooterBookingByMember_Cancel.Location = new System.Drawing.Point(0, 256);
            this._panelFooterBookingByMember_Cancel.Name = "_panelFooterBookingByMember_Cancel";
            this._panelFooterBookingByMember_Cancel.Size = new System.Drawing.Size(925, 94);
            this._panelFooterBookingByMember_Cancel.TabIndex = 38;
            this._panelFooterBookingByMember_Cancel.Visible = false;
            // 
            // _labelBookingByMember_Error
            // 
            this._labelBookingByMember_Error.AutoSize = true;
            this._labelBookingByMember_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByMember_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this._labelBookingByMember_Error.Location = new System.Drawing.Point(-3, 205);
            this._labelBookingByMember_Error.Name = "_labelBookingByMember_Error";
            this._labelBookingByMember_Error.Size = new System.Drawing.Size(231, 16);
            this._labelBookingByMember_Error.TabIndex = 43;
            this._labelBookingByMember_Error.Text = "ERROR MESSAGE GOES HERE";
            this._labelBookingByMember_Error.Visible = false;
            // 
            // _panelBookingByMember_Details
            // 
            this._panelBookingByMember_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelBookingByMember_Details.Controls.Add(this._tboxlBookingByMember_CancellationReason);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_CancellationReason);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_Runway);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_Error);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_MemberName);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_Aircraft);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_EndHour);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_StartHour);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_Date);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_NewBooking);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_Update);
            this._panelBookingByMember_Details.Controls.Add(this._labelBookingByMember_Cancellation);
            this._panelBookingByMember_Details.Location = new System.Drawing.Point(20, 474);
            this._panelBookingByMember_Details.Name = "_panelBookingByMember_Details";
            this._panelBookingByMember_Details.Size = new System.Drawing.Size(877, 277);
            this._panelBookingByMember_Details.TabIndex = 34;
            this._panelBookingByMember_Details.Visible = false;
            // 
            // _tboxlBookingByMember_CancellationReason
            // 
            this._tboxlBookingByMember_CancellationReason.Location = new System.Drawing.Point(569, 73);
            this._tboxlBookingByMember_CancellationReason.Name = "_tboxlBookingByMember_CancellationReason";
            this._tboxlBookingByMember_CancellationReason.Size = new System.Drawing.Size(225, 20);
            this._tboxlBookingByMember_CancellationReason.TabIndex = 52;
            this._tboxlBookingByMember_CancellationReason.Visible = false;
            // 
            // _labelBookingByMember_CancellationReason
            // 
            this._labelBookingByMember_CancellationReason.AutoSize = true;
            this._labelBookingByMember_CancellationReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this._labelBookingByMember_CancellationReason.Location = new System.Drawing.Point(566, 54);
            this._labelBookingByMember_CancellationReason.Name = "_labelBookingByMember_CancellationReason";
            this._labelBookingByMember_CancellationReason.Size = new System.Drawing.Size(101, 13);
            this._labelBookingByMember_CancellationReason.TabIndex = 51;
            this._labelBookingByMember_CancellationReason.Text = "Motif de l\'annulation";
            this._labelBookingByMember_CancellationReason.Visible = false;
            // 
            // _labelBookingByMember_Runway
            // 
            this._labelBookingByMember_Runway.AutoSize = true;
            this._labelBookingByMember_Runway.Location = new System.Drawing.Point(-3, 149);
            this._labelBookingByMember_Runway.Name = "_labelBookingByMember_Runway";
            this._labelBookingByMember_Runway.Size = new System.Drawing.Size(30, 13);
            this._labelBookingByMember_Runway.TabIndex = 44;
            this._labelBookingByMember_Runway.Text = "Piste";
            // 
            // _labelBookingByMember_MemberName
            // 
            this._labelBookingByMember_MemberName.AutoSize = true;
            this._labelBookingByMember_MemberName.Location = new System.Drawing.Point(-3, 54);
            this._labelBookingByMember_MemberName.Name = "_labelBookingByMember_MemberName";
            this._labelBookingByMember_MemberName.Size = new System.Drawing.Size(45, 13);
            this._labelBookingByMember_MemberName.TabIndex = 40;
            this._labelBookingByMember_MemberName.Text = "Membre";
            // 
            // _labelBookingByMember_Aircraft
            // 
            this._labelBookingByMember_Aircraft.AutoSize = true;
            this._labelBookingByMember_Aircraft.Location = new System.Drawing.Point(-3, 102);
            this._labelBookingByMember_Aircraft.Name = "_labelBookingByMember_Aircraft";
            this._labelBookingByMember_Aircraft.Size = new System.Drawing.Size(30, 13);
            this._labelBookingByMember_Aircraft.TabIndex = 39;
            this._labelBookingByMember_Aircraft.Text = "ULM";
            // 
            // _labelBookingByMember_EndHour
            // 
            this._labelBookingByMember_EndHour.AutoSize = true;
            this._labelBookingByMember_EndHour.Location = new System.Drawing.Point(280, 153);
            this._labelBookingByMember_EndHour.Name = "_labelBookingByMember_EndHour";
            this._labelBookingByMember_EndHour.Size = new System.Drawing.Size(65, 13);
            this._labelBookingByMember_EndHour.TabIndex = 36;
            this._labelBookingByMember_EndHour.Text = "Heure de fin";
            // 
            // _labelBookingByMember_StartHour
            // 
            this._labelBookingByMember_StartHour.AutoSize = true;
            this._labelBookingByMember_StartHour.Location = new System.Drawing.Point(280, 104);
            this._labelBookingByMember_StartHour.Name = "_labelBookingByMember_StartHour";
            this._labelBookingByMember_StartHour.Size = new System.Drawing.Size(81, 13);
            this._labelBookingByMember_StartHour.TabIndex = 34;
            this._labelBookingByMember_StartHour.Text = "Heure de début";
            // 
            // _labelBookingByMember_Date
            // 
            this._labelBookingByMember_Date.AutoSize = true;
            this._labelBookingByMember_Date.Location = new System.Drawing.Point(280, 54);
            this._labelBookingByMember_Date.Name = "_labelBookingByMember_Date";
            this._labelBookingByMember_Date.Size = new System.Drawing.Size(30, 13);
            this._labelBookingByMember_Date.TabIndex = 32;
            this._labelBookingByMember_Date.Text = "Date";
            // 
            // _labelBookingByMember_NewBooking
            // 
            this._labelBookingByMember_NewBooking.AutoSize = true;
            this._labelBookingByMember_NewBooking.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByMember_NewBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this._labelBookingByMember_NewBooking.Location = new System.Drawing.Point(-5, 13);
            this._labelBookingByMember_NewBooking.Name = "_labelBookingByMember_NewBooking";
            this._labelBookingByMember_NewBooking.Size = new System.Drawing.Size(326, 27);
            this._labelBookingByMember_NewBooking.TabIndex = 48;
            this._labelBookingByMember_NewBooking.Text = "NOUVELLE RESERVATION";
            this._labelBookingByMember_NewBooking.Visible = false;
            // 
            // _labelBookingByMember_Update
            // 
            this._labelBookingByMember_Update.AutoSize = true;
            this._labelBookingByMember_Update.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByMember_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this._labelBookingByMember_Update.Location = new System.Drawing.Point(-5, 13);
            this._labelBookingByMember_Update.Name = "_labelBookingByMember_Update";
            this._labelBookingByMember_Update.Size = new System.Drawing.Size(361, 27);
            this._labelBookingByMember_Update.TabIndex = 50;
            this._labelBookingByMember_Update.Text = "MODIFIER LA RESERVATION";
            this._labelBookingByMember_Update.Visible = false;
            // 
            // _labelBookingByMember_Cancellation
            // 
            this._labelBookingByMember_Cancellation.AutoSize = true;
            this._labelBookingByMember_Cancellation.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByMember_Cancellation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this._labelBookingByMember_Cancellation.Location = new System.Drawing.Point(-5, 13);
            this._labelBookingByMember_Cancellation.Name = "_labelBookingByMember_Cancellation";
            this._labelBookingByMember_Cancellation.Size = new System.Drawing.Size(357, 27);
            this._labelBookingByMember_Cancellation.TabIndex = 49;
            this._labelBookingByMember_Cancellation.Text = "ANNULER LA RESERVATION";
            this._labelBookingByMember_Cancellation.Visible = false;
            // 
            // _labelBookingByMBR_MemberName
            // 
            this._labelBookingByMBR_MemberName.AutoSize = true;
            this._labelBookingByMBR_MemberName.Location = new System.Drawing.Point(15, 44);
            this._labelBookingByMBR_MemberName.Name = "_labelBookingByMBR_MemberName";
            this._labelBookingByMBR_MemberName.Size = new System.Drawing.Size(33, 13);
            this._labelBookingByMBR_MemberName.TabIndex = 48;
            this._labelBookingByMBR_MemberName.Text = "Pilote";
            // 
            // _labelBookingByMBR_AircraftRegistration
            // 
            this._labelBookingByMBR_AircraftRegistration.AutoSize = true;
            this._labelBookingByMBR_AircraftRegistration.Location = new System.Drawing.Point(15, 92);
            this._labelBookingByMBR_AircraftRegistration.Name = "_labelBookingByMBR_AircraftRegistration";
            this._labelBookingByMBR_AircraftRegistration.Size = new System.Drawing.Size(30, 13);
            this._labelBookingByMBR_AircraftRegistration.TabIndex = 49;
            this._labelBookingByMBR_AircraftRegistration.Text = "ULM";
            // 
            // _labelBookingByMBR_Runway
            // 
            this._labelBookingByMBR_Runway.AutoSize = true;
            this._labelBookingByMBR_Runway.Location = new System.Drawing.Point(15, 139);
            this._labelBookingByMBR_Runway.Name = "_labelBookingByMBR_Runway";
            this._labelBookingByMBR_Runway.Size = new System.Drawing.Size(30, 13);
            this._labelBookingByMBR_Runway.TabIndex = 50;
            this._labelBookingByMBR_Runway.Text = "Piste";
            // 
            // _labelBookingByMBR_Date
            // 
            this._labelBookingByMBR_Date.AutoSize = true;
            this._labelBookingByMBR_Date.Location = new System.Drawing.Point(298, 44);
            this._labelBookingByMBR_Date.Name = "_labelBookingByMBR_Date";
            this._labelBookingByMBR_Date.Size = new System.Drawing.Size(30, 13);
            this._labelBookingByMBR_Date.TabIndex = 51;
            this._labelBookingByMBR_Date.Text = "Date";
            // 
            // _labelBookingByMBR_StartHour
            // 
            this._labelBookingByMBR_StartHour.AutoSize = true;
            this._labelBookingByMBR_StartHour.Location = new System.Drawing.Point(298, 92);
            this._labelBookingByMBR_StartHour.Name = "_labelBookingByMBR_StartHour";
            this._labelBookingByMBR_StartHour.Size = new System.Drawing.Size(81, 13);
            this._labelBookingByMBR_StartHour.TabIndex = 52;
            this._labelBookingByMBR_StartHour.Text = "Heure de début";
            // 
            // _labelBookingByMBR_EndHour
            // 
            this._labelBookingByMBR_EndHour.AutoSize = true;
            this._labelBookingByMBR_EndHour.Location = new System.Drawing.Point(298, 139);
            this._labelBookingByMBR_EndHour.Name = "_labelBookingByMBR_EndHour";
            this._labelBookingByMBR_EndHour.Size = new System.Drawing.Size(65, 13);
            this._labelBookingByMBR_EndHour.TabIndex = 53;
            this._labelBookingByMBR_EndHour.Text = "Heure de fin";
            // 
            // _labelBookingByMBR_CancellationReason
            // 
            this._labelBookingByMBR_CancellationReason.AutoSize = true;
            this._labelBookingByMBR_CancellationReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByMBR_CancellationReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this._labelBookingByMBR_CancellationReason.Location = new System.Drawing.Point(573, 53);
            this._labelBookingByMBR_CancellationReason.Name = "_labelBookingByMBR_CancellationReason";
            this._labelBookingByMBR_CancellationReason.Size = new System.Drawing.Size(122, 13);
            this._labelBookingByMBR_CancellationReason.TabIndex = 54;
            this._labelBookingByMBR_CancellationReason.Text = "Motif de l\'annulation";
            this._labelBookingByMBR_CancellationReason.Visible = false;
            // 
            // _tboxBookingByMBR_CancellationReason
            // 
            this._tboxBookingByMBR_CancellationReason.Location = new System.Drawing.Point(576, 69);
            this._tboxBookingByMBR_CancellationReason.Name = "_tboxBookingByMBR_CancellationReason";
            this._tboxBookingByMBR_CancellationReason.Size = new System.Drawing.Size(223, 20);
            this._tboxBookingByMBR_CancellationReason.TabIndex = 55;
            this._tboxBookingByMBR_CancellationReason.Visible = false;
            // 
            // _labelBookingByMBR_ErrorMessage
            // 
            this._labelBookingByMBR_ErrorMessage.AutoSize = true;
            this._labelBookingByMBR_ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByMBR_ErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this._labelBookingByMBR_ErrorMessage.Location = new System.Drawing.Point(14, 205);
            this._labelBookingByMBR_ErrorMessage.Name = "_labelBookingByMBR_ErrorMessage";
            this._labelBookingByMBR_ErrorMessage.Size = new System.Drawing.Size(188, 24);
            this._labelBookingByMBR_ErrorMessage.TabIndex = 56;
            this._labelBookingByMBR_ErrorMessage.Text = "ERROR MESSAGE";
            this._labelBookingByMBR_ErrorMessage.Visible = false;
            // 
            // _labelBookingByMBR_DetailsTitle
            // 
            this._labelBookingByMBR_DetailsTitle.AutoSize = true;
            this._labelBookingByMBR_DetailsTitle.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold);
            this._labelBookingByMBR_DetailsTitle.Location = new System.Drawing.Point(13, 0);
            this._labelBookingByMBR_DetailsTitle.Name = "_labelBookingByMBR_DetailsTitle";
            this._labelBookingByMBR_DetailsTitle.Size = new System.Drawing.Size(193, 27);
            this._labelBookingByMBR_DetailsTitle.TabIndex = 57;
            this._labelBookingByMBR_DetailsTitle.Text = "DETAILS TITLE";
            // 
            // _panelBookingByMBR_Details
            // 
            this._panelBookingByMBR_Details.BackColor = System.Drawing.Color.WhiteSmoke;
            this._panelBookingByMBR_Details.Controls.Add(this._cboxBookingByMember_MemberName);
            this._panelBookingByMBR_Details.Controls.Add(this._labelBookingByMBR_DetailsTitle);
            this._panelBookingByMBR_Details.Controls.Add(this._labelBookingByMBR_ErrorMessage);
            this._panelBookingByMBR_Details.Controls.Add(this._cboxBookingByMember_Aircraft);
            this._panelBookingByMBR_Details.Controls.Add(this._dtpBookingByMember_Date);
            this._panelBookingByMBR_Details.Controls.Add(this._tboxBookingByMBR_CancellationReason);
            this._panelBookingByMBR_Details.Controls.Add(this._cboxBookingByMember_Runway);
            this._panelBookingByMBR_Details.Controls.Add(this._labelBookingByMBR_CancellationReason);
            this._panelBookingByMBR_Details.Controls.Add(this._cboxBookingByMember_TimeSlotStart);
            this._panelBookingByMBR_Details.Controls.Add(this._labelBookingByMBR_EndHour);
            this._panelBookingByMBR_Details.Controls.Add(this._cboxBookingByMember_TimeSlotEnd);
            this._panelBookingByMBR_Details.Controls.Add(this._labelBookingByMBR_StartHour);
            this._panelBookingByMBR_Details.Controls.Add(this._labelBookingByMBR_Date);
            this._panelBookingByMBR_Details.Controls.Add(this._labelBookingByMBR_MemberName);
            this._panelBookingByMBR_Details.Controls.Add(this._labelBookingByMBR_Runway);
            this._panelBookingByMBR_Details.Controls.Add(this._labelBookingByMBR_AircraftRegistration);
            this._panelBookingByMBR_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelBookingByMBR_Details.Location = new System.Drawing.Point(0, 0);
            this._panelBookingByMBR_Details.Name = "_panelBookingByMBR_Details";
            this._panelBookingByMBR_Details.Size = new System.Drawing.Size(925, 256);
            this._panelBookingByMBR_Details.TabIndex = 58;
            // 
            // _cboxBookingByMember_MemberName
            // 
            this._cboxBookingByMember_MemberName.DataSource = this._bsPilots;
            this._cboxBookingByMember_MemberName.Enabled = false;
            this._cboxBookingByMember_MemberName.FormattingEnabled = true;
            this._cboxBookingByMember_MemberName.Location = new System.Drawing.Point(18, 60);
            this._cboxBookingByMember_MemberName.Name = "_cboxBookingByMember_MemberName";
            this._cboxBookingByMember_MemberName.Size = new System.Drawing.Size(223, 21);
            this._cboxBookingByMember_MemberName.TabIndex = 58;
            // 
            // _bsPilots
            // 
            this._bsPilots.DataSource = typeof(ULMClubManager.DTO.Member);
            // 
            // UCBookingByMemberDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panelBookingByMBR_Details);
            this.Controls.Add(this._panelFooterBookingByMember_Cancel);
            this.Controls.Add(this._panelFooterBookingByMember_Update);
            this.Controls.Add(this._panelFooterBookingByMember_Create);
            this.Controls.Add(this._panelFooterBookingByMemberCRUD);
            this.Name = "UCBookingByMemberDetailsForm";
            this.Size = new System.Drawing.Size(925, 632);
            ((System.ComponentModel.ISupportInitialize)(this._bsAircrafts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsRunways)).EndInit();
            this._panelFooterBookingByMemberCRUD.ResumeLayout(false);
            this._panelFooterBookingByMember_Create.ResumeLayout(false);
            this._panelFooterBookingByMember_Update.ResumeLayout(false);
            this._panelFooterBookingByMember_Cancel.ResumeLayout(false);
            this._panelBookingByMember_Details.ResumeLayout(false);
            this._panelBookingByMember_Details.PerformLayout();
            this._panelBookingByMBR_Details.ResumeLayout(false);
            this._panelBookingByMBR_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bsPilots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource _bsAircrafts;
        private System.Windows.Forms.BindingSource _bsRunways;
        private System.Windows.Forms.Label _labelBookingByMember_Error;
        private System.Windows.Forms.Button _btnFooterBookingByMemberCancel;
        private System.Windows.Forms.Button _btnFooterBookingByMemberUpdate;
        private System.Windows.Forms.Button _btnFooterBookingByMemberCreate;
        private System.Windows.Forms.Panel _panelFooterBookingByMemberCRUD;
        private System.Windows.Forms.Button _btnFooterBookingByMember_CreateCancel;
        private System.Windows.Forms.Button _btnFooterBookingByMember_CreateConfirm;
        private System.Windows.Forms.Panel _panelFooterBookingByMember_Create;
        private System.Windows.Forms.Button _btnFooterBookingByMember_UpdateDelete;
        private System.Windows.Forms.Button _btnFooterBookingByMember_UpdateConfirm;
        private System.Windows.Forms.Panel _panelFooterBookingByMember_Update;
        private System.Windows.Forms.Button _btnFooterBookingByMember_CancelCancel;
        private System.Windows.Forms.Button _btnFooterBookingByMember_CancelConfirm;
        private System.Windows.Forms.Panel _panelFooterBookingByMember_Cancel;
        private System.Windows.Forms.Panel _panelBookingByMember_Details;
        private System.Windows.Forms.TextBox _tboxlBookingByMember_CancellationReason;
        private System.Windows.Forms.Label _labelBookingByMember_CancellationReason;
        private System.Windows.Forms.ComboBox _cboxBookingByMember_TimeSlotEnd;
        private System.Windows.Forms.ComboBox _cboxBookingByMember_TimeSlotStart;
        private System.Windows.Forms.ComboBox _cboxBookingByMember_Runway;
        private System.Windows.Forms.Label _labelBookingByMember_Runway;
        private System.Windows.Forms.Label _labelBookingByMember_MemberName;
        private System.Windows.Forms.Label _labelBookingByMember_Aircraft;
        private System.Windows.Forms.ComboBox _cboxBookingByMember_Aircraft;
        private System.Windows.Forms.DateTimePicker _dtpBookingByMember_Date;
        private System.Windows.Forms.Label _labelBookingByMember_EndHour;
        private System.Windows.Forms.Label _labelBookingByMember_StartHour;
        private System.Windows.Forms.Label _labelBookingByMember_Date;
        private System.Windows.Forms.Label _labelBookingByMember_NewBooking;
        private System.Windows.Forms.Label _labelBookingByMember_Update;
        private System.Windows.Forms.Label _labelBookingByMember_Cancellation;
        private System.Windows.Forms.Label _labelBookingByMBR_MemberName;
        private System.Windows.Forms.Label _labelBookingByMBR_AircraftRegistration;
        private System.Windows.Forms.Label _labelBookingByMBR_Runway;
        private System.Windows.Forms.Label _labelBookingByMBR_Date;
        private System.Windows.Forms.Label _labelBookingByMBR_StartHour;
        private System.Windows.Forms.Label _labelBookingByMBR_EndHour;
        private System.Windows.Forms.Label _labelBookingByMBR_CancellationReason;
        private System.Windows.Forms.TextBox _tboxBookingByMBR_CancellationReason;
        private System.Windows.Forms.Label _labelBookingByMBR_ErrorMessage;
        private System.Windows.Forms.Label _labelBookingByMBR_DetailsTitle;
        private System.Windows.Forms.Panel _panelBookingByMBR_Details;
        private System.Windows.Forms.ComboBox _cboxBookingByMember_MemberName;
        private System.Windows.Forms.BindingSource _bsPilots;
    }
}
