﻿
namespace ULMClubManger.Forms.UserControls
{
    partial class UCMemberCRUD
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
            this._labelMBRLastName = new System.Windows.Forms.Label();
            this._labelMBRFirstName = new System.Windows.Forms.Label();
            this._tboxMBRLastName = new System.Windows.Forms.TextBox();
            this._bsMember = new System.Windows.Forms.BindingSource(this.components);
            this._tboxMBRFirstName = new System.Windows.Forms.TextBox();
            this._labelMBRID = new System.Windows.Forms.Label();
            this._tboxMBRID = new System.Windows.Forms.TextBox();
            this._labelMBRSex = new System.Windows.Forms.Label();
            this._cboxMBRSex = new System.Windows.Forms.ComboBox();
            this._labelMBRDteOfBirth = new System.Windows.Forms.Label();
            this._dtpMBRDteOfBirth = new System.Windows.Forms.DateTimePicker();
            this._labelMBREmailAddress = new System.Windows.Forms.Label();
            this._tboxMBREmailAddress = new System.Windows.Forms.TextBox();
            this._labelMBRStreet = new System.Windows.Forms.Label();
            this._tboxMBRPostalAddress = new System.Windows.Forms.TextBox();
            this._labelMBRResidenceName = new System.Windows.Forms.Label();
            this._tboxMBRResidenceName = new System.Windows.Forms.TextBox();
            this._labelMBRBoxNumber = new System.Windows.Forms.Label();
            this._tboxMBRBoxNumber = new System.Windows.Forms.TextBox();
            this._labelMBRBuildingNumber = new System.Windows.Forms.Label();
            this._tboxMBRBuildingNumber = new System.Windows.Forms.TextBox();
            this._labelMBRLocality = new System.Windows.Forms.Label();
            this._tboxMBRZipCode = new System.Windows.Forms.TextBox();
            this._labelMRBRegistrationDate = new System.Windows.Forms.Label();
            this._dtpMRBRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this._cboxMBRLocality = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnMBRCreate = new System.Windows.Forms.Button();
            this._btnMBRDelete = new System.Windows.Forms.Button();
            this._btnMBRUpdate = new System.Windows.Forms.Button();
            this._panelMBR_CRUD_btn = new System.Windows.Forms.Panel();
            this._gboxPIL = new System.Windows.Forms.GroupBox();
            this._tboxLICCountry = new System.Windows.Forms.TextBox();
            this._labelLICCountry = new System.Windows.Forms.Label();
            this._dtpLICExpirationDte = new System.Windows.Forms.DateTimePicker();
            this._labelLICExpirationDte = new System.Windows.Forms.Label();
            this._dtpLICObtentionDte = new System.Windows.Forms.DateTimePicker();
            this._labelLICObtentionDte = new System.Windows.Forms.Label();
            this._tboxLICNum = new System.Windows.Forms.TextBox();
            this._labelLICNum = new System.Windows.Forms.Label();
            this._cboxMBRQual6 = new System.Windows.Forms.CheckBox();
            this._cboxMBRQual5 = new System.Windows.Forms.CheckBox();
            this._cboxMBRQual4 = new System.Windows.Forms.CheckBox();
            this._cboxMBRQual3 = new System.Windows.Forms.CheckBox();
            this._cboxMBRQual1 = new System.Windows.Forms.CheckBox();
            this._cboxMBRQual2 = new System.Windows.Forms.CheckBox();
            this._panelMBR_Update_btn = new System.Windows.Forms.Panel();
            this._btnMRBUpdateConfirm = new System.Windows.Forms.Button();
            this._btnMBRUpdateCancel = new System.Windows.Forms.Button();
            this._panelMBR_Create_btn = new System.Windows.Forms.Panel();
            this._btnMRBCreateConfirm = new System.Windows.Forms.Button();
            this._btnMRBCreateCancel = new System.Windows.Forms.Button();
            this._labelMBRPhoneNumber = new System.Windows.Forms.Label();
            this._tboxMBRPhoneNumber = new System.Windows.Forms.TextBox();
            this._labelMBRCellphoneNumber = new System.Windows.Forms.Label();
            this._tboxMBRCellphoneNumber = new System.Windows.Forms.TextBox();
            this._labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._bsMember)).BeginInit();
            this._panelMBR_CRUD_btn.SuspendLayout();
            this._gboxPIL.SuspendLayout();
            this._panelMBR_Update_btn.SuspendLayout();
            this._panelMBR_Create_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelMBRLastName
            // 
            this._labelMBRLastName.AutoSize = true;
            this._labelMBRLastName.Location = new System.Drawing.Point(23, 107);
            this._labelMBRLastName.Name = "_labelMBRLastName";
            this._labelMBRLastName.Size = new System.Drawing.Size(35, 13);
            this._labelMBRLastName.TabIndex = 0;
            this._labelMBRLastName.Text = "Nom :";
            // 
            // _labelMBRFirstName
            // 
            this._labelMBRFirstName.AutoSize = true;
            this._labelMBRFirstName.Location = new System.Drawing.Point(23, 134);
            this._labelMBRFirstName.Name = "_labelMBRFirstName";
            this._labelMBRFirstName.Size = new System.Drawing.Size(49, 13);
            this._labelMBRFirstName.TabIndex = 1;
            this._labelMBRFirstName.Text = "Prénom :";
            // 
            // _tboxMBRLastName
            // 
            this._tboxMBRLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tboxMBRLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "LastName", true));
            this._tboxMBRLastName.Location = new System.Drawing.Point(164, 104);
            this._tboxMBRLastName.MaximumSize = new System.Drawing.Size(240, 20);
            this._tboxMBRLastName.MinimumSize = new System.Drawing.Size(240, 20);
            this._tboxMBRLastName.Name = "_tboxMBRLastName";
            this._tboxMBRLastName.ReadOnly = true;
            this._tboxMBRLastName.Size = new System.Drawing.Size(240, 20);
            this._tboxMBRLastName.TabIndex = 2;
            // 
            // _bsMember
            // 
            this._bsMember.DataSource = typeof(ULMClubManager.DTO.Member);
            // 
            // _tboxMBRFirstName
            // 
            this._tboxMBRFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tboxMBRFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "FirstName", true));
            this._tboxMBRFirstName.Location = new System.Drawing.Point(164, 131);
            this._tboxMBRFirstName.MaximumSize = new System.Drawing.Size(240, 20);
            this._tboxMBRFirstName.MinimumSize = new System.Drawing.Size(240, 20);
            this._tboxMBRFirstName.Name = "_tboxMBRFirstName";
            this._tboxMBRFirstName.ReadOnly = true;
            this._tboxMBRFirstName.Size = new System.Drawing.Size(240, 20);
            this._tboxMBRFirstName.TabIndex = 3;
            // 
            // _labelMBRID
            // 
            this._labelMBRID.AutoSize = true;
            this._labelMBRID.Location = new System.Drawing.Point(23, 78);
            this._labelMBRID.Name = "_labelMBRID";
            this._labelMBRID.Size = new System.Drawing.Size(22, 13);
            this._labelMBRID.TabIndex = 4;
            this._labelMBRID.Text = "Id :";
            // 
            // _tboxMBRID
            // 
            this._tboxMBRID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tboxMBRID.Location = new System.Drawing.Point(164, 75);
            this._tboxMBRID.MaximumSize = new System.Drawing.Size(75, 20);
            this._tboxMBRID.MinimumSize = new System.Drawing.Size(75, 20);
            this._tboxMBRID.Name = "_tboxMBRID";
            this._tboxMBRID.ReadOnly = true;
            this._tboxMBRID.Size = new System.Drawing.Size(75, 20);
            this._tboxMBRID.TabIndex = 5;
            // 
            // _labelMBRSex
            // 
            this._labelMBRSex.AutoSize = true;
            this._labelMBRSex.Location = new System.Drawing.Point(23, 162);
            this._labelMBRSex.Name = "_labelMBRSex";
            this._labelMBRSex.Size = new System.Drawing.Size(37, 13);
            this._labelMBRSex.TabIndex = 6;
            this._labelMBRSex.Text = "Sexe :";
            // 
            // _cboxMBRSex
            // 
            this._cboxMBRSex.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._bsMember, "Sex", true));
            this._cboxMBRSex.Enabled = false;
            this._cboxMBRSex.FormattingEnabled = true;
            this._cboxMBRSex.Location = new System.Drawing.Point(164, 159);
            this._cboxMBRSex.Name = "_cboxMBRSex";
            this._cboxMBRSex.Size = new System.Drawing.Size(106, 21);
            this._cboxMBRSex.TabIndex = 7;
            // 
            // _labelMBRDteOfBirth
            // 
            this._labelMBRDteOfBirth.AutoSize = true;
            this._labelMBRDteOfBirth.Location = new System.Drawing.Point(23, 192);
            this._labelMBRDteOfBirth.Name = "_labelMBRDteOfBirth";
            this._labelMBRDteOfBirth.Size = new System.Drawing.Size(102, 13);
            this._labelMBRDteOfBirth.TabIndex = 8;
            this._labelMBRDteOfBirth.Text = "Date de naissance :";
            // 
            // _dtpMBRDteOfBirth
            // 
            this._dtpMBRDteOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "DateOfBirth", true));
            this._dtpMBRDteOfBirth.Enabled = false;
            this._dtpMBRDteOfBirth.Location = new System.Drawing.Point(164, 186);
            this._dtpMBRDteOfBirth.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this._dtpMBRDteOfBirth.Name = "_dtpMBRDteOfBirth";
            this._dtpMBRDteOfBirth.Size = new System.Drawing.Size(240, 20);
            this._dtpMBRDteOfBirth.TabIndex = 9;
            // 
            // _labelMBREmailAddress
            // 
            this._labelMBREmailAddress.AutoSize = true;
            this._labelMBREmailAddress.Location = new System.Drawing.Point(23, 219);
            this._labelMBREmailAddress.Name = "_labelMBREmailAddress";
            this._labelMBREmailAddress.Size = new System.Drawing.Size(78, 13);
            this._labelMBREmailAddress.TabIndex = 10;
            this._labelMBREmailAddress.Text = "Adresse email :";
            // 
            // _tboxMBREmailAddress
            // 
            this._tboxMBREmailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tboxMBREmailAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "EmailAddress", true));
            this._tboxMBREmailAddress.Location = new System.Drawing.Point(164, 216);
            this._tboxMBREmailAddress.MaximumSize = new System.Drawing.Size(240, 20);
            this._tboxMBREmailAddress.MinimumSize = new System.Drawing.Size(240, 20);
            this._tboxMBREmailAddress.Name = "_tboxMBREmailAddress";
            this._tboxMBREmailAddress.ReadOnly = true;
            this._tboxMBREmailAddress.Size = new System.Drawing.Size(240, 20);
            this._tboxMBREmailAddress.TabIndex = 11;
            // 
            // _labelMBRStreet
            // 
            this._labelMBRStreet.AutoSize = true;
            this._labelMBRStreet.Location = new System.Drawing.Point(23, 298);
            this._labelMBRStreet.Name = "_labelMBRStreet";
            this._labelMBRStreet.Size = new System.Drawing.Size(33, 13);
            this._labelMBRStreet.TabIndex = 12;
            this._labelMBRStreet.Text = "Rue :";
            // 
            // _tboxMBRPostalAddress
            // 
            this._tboxMBRPostalAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tboxMBRPostalAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "Street", true));
            this._tboxMBRPostalAddress.Location = new System.Drawing.Point(164, 295);
            this._tboxMBRPostalAddress.MaximumSize = new System.Drawing.Size(240, 20);
            this._tboxMBRPostalAddress.MinimumSize = new System.Drawing.Size(240, 20);
            this._tboxMBRPostalAddress.Name = "_tboxMBRPostalAddress";
            this._tboxMBRPostalAddress.ReadOnly = true;
            this._tboxMBRPostalAddress.Size = new System.Drawing.Size(240, 20);
            this._tboxMBRPostalAddress.TabIndex = 12;
            // 
            // _labelMBRResidenceName
            // 
            this._labelMBRResidenceName.AutoSize = true;
            this._labelMBRResidenceName.Location = new System.Drawing.Point(23, 354);
            this._labelMBRResidenceName.Name = "_labelMBRResidenceName";
            this._labelMBRResidenceName.Size = new System.Drawing.Size(104, 13);
            this._labelMBRResidenceName.TabIndex = 14;
            this._labelMBRResidenceName.Text = "Nom de Résidence :";
            // 
            // _tboxMBRResidenceName
            // 
            this._tboxMBRResidenceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tboxMBRResidenceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "ResidenceName", true));
            this._tboxMBRResidenceName.Location = new System.Drawing.Point(164, 351);
            this._tboxMBRResidenceName.MaximumSize = new System.Drawing.Size(240, 20);
            this._tboxMBRResidenceName.MinimumSize = new System.Drawing.Size(240, 20);
            this._tboxMBRResidenceName.Name = "_tboxMBRResidenceName";
            this._tboxMBRResidenceName.ReadOnly = true;
            this._tboxMBRResidenceName.Size = new System.Drawing.Size(240, 20);
            this._tboxMBRResidenceName.TabIndex = 15;
            // 
            // _labelMBRBoxNumber
            // 
            this._labelMBRBoxNumber.AutoSize = true;
            this._labelMBRBoxNumber.Location = new System.Drawing.Point(23, 326);
            this._labelMBRBoxNumber.Name = "_labelMBRBoxNumber";
            this._labelMBRBoxNumber.Size = new System.Drawing.Size(39, 13);
            this._labelMBRBoxNumber.TabIndex = 16;
            this._labelMBRBoxNumber.Text = "Boîte :";
            // 
            // _tboxMBRBoxNumber
            // 
            this._tboxMBRBoxNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "BoxNumber", true));
            this._tboxMBRBoxNumber.Location = new System.Drawing.Point(164, 323);
            this._tboxMBRBoxNumber.Name = "_tboxMBRBoxNumber";
            this._tboxMBRBoxNumber.ReadOnly = true;
            this._tboxMBRBoxNumber.Size = new System.Drawing.Size(75, 20);
            this._tboxMBRBoxNumber.TabIndex = 13;
            // 
            // _labelMBRBuildingNumber
            // 
            this._labelMBRBuildingNumber.AutoSize = true;
            this._labelMBRBuildingNumber.Location = new System.Drawing.Point(23, 381);
            this._labelMBRBuildingNumber.Name = "_labelMBRBuildingNumber";
            this._labelMBRBuildingNumber.Size = new System.Drawing.Size(78, 13);
            this._labelMBRBuildingNumber.TabIndex = 18;
            this._labelMBRBuildingNumber.Text = "Num bâtiment :";
            // 
            // _tboxMBRBuildingNumber
            // 
            this._tboxMBRBuildingNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "BuildingNumber", true));
            this._tboxMBRBuildingNumber.Location = new System.Drawing.Point(164, 378);
            this._tboxMBRBuildingNumber.Name = "_tboxMBRBuildingNumber";
            this._tboxMBRBuildingNumber.ReadOnly = true;
            this._tboxMBRBuildingNumber.Size = new System.Drawing.Size(75, 20);
            this._tboxMBRBuildingNumber.TabIndex = 19;
            // 
            // _labelMBRLocality
            // 
            this._labelMBRLocality.AutoSize = true;
            this._labelMBRLocality.Location = new System.Drawing.Point(22, 412);
            this._labelMBRLocality.Name = "_labelMBRLocality";
            this._labelMBRLocality.Size = new System.Drawing.Size(50, 13);
            this._labelMBRLocality.TabIndex = 20;
            this._labelMBRLocality.Text = "Localité :";
            // 
            // _tboxMBRZipCode
            // 
            this._tboxMBRZipCode.Location = new System.Drawing.Point(164, 409);
            this._tboxMBRZipCode.Name = "_tboxMBRZipCode";
            this._tboxMBRZipCode.ReadOnly = true;
            this._tboxMBRZipCode.Size = new System.Drawing.Size(75, 20);
            this._tboxMBRZipCode.TabIndex = 23;
            this._tboxMBRZipCode.TextChanged += new System.EventHandler(this._tboxMBRZipCode_TextChanged);
            // 
            // _labelMRBRegistrationDate
            // 
            this._labelMRBRegistrationDate.AutoSize = true;
            this._labelMRBRegistrationDate.Location = new System.Drawing.Point(22, 442);
            this._labelMRBRegistrationDate.Name = "_labelMRBRegistrationDate";
            this._labelMRBRegistrationDate.Size = new System.Drawing.Size(132, 13);
            this._labelMRBRegistrationDate.TabIndex = 24;
            this._labelMRBRegistrationDate.Text = "Date d\'inscription au club :";
            // 
            // _dtpMRBRegistrationDate
            // 
            this._dtpMRBRegistrationDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "RegistrationDate", true));
            this._dtpMRBRegistrationDate.Enabled = false;
            this._dtpMRBRegistrationDate.Location = new System.Drawing.Point(164, 436);
            this._dtpMRBRegistrationDate.Name = "_dtpMRBRegistrationDate";
            this._dtpMRBRegistrationDate.Size = new System.Drawing.Size(240, 20);
            this._dtpMRBRegistrationDate.TabIndex = 25;
            // 
            // _cboxMBRLocality
            // 
            this._cboxMBRLocality.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._bsMember, "LocalityID", true));
            this._cboxMBRLocality.Enabled = false;
            this._cboxMBRLocality.FormattingEnabled = true;
            this._cboxMBRLocality.Location = new System.Drawing.Point(245, 409);
            this._cboxMBRLocality.Name = "_cboxMBRLocality";
            this._cboxMBRLocality.Size = new System.Drawing.Size(159, 21);
            this._cboxMBRLocality.TabIndex = 27;
            this._cboxMBRLocality.SelectedIndexChanged += new System.EventHandler(this._cboxMBRLocality_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "DONNEES SIGNALETIQUES";
            // 
            // _btnMBRCreate
            // 
            this._btnMBRCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnMBRCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnMBRCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMBRCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMBRCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnMBRCreate.Location = new System.Drawing.Point(18, 15);
            this._btnMBRCreate.Name = "_btnMBRCreate";
            this._btnMBRCreate.Size = new System.Drawing.Size(150, 61);
            this._btnMBRCreate.TabIndex = 29;
            this._btnMBRCreate.Text = "Ajouter";
            this._btnMBRCreate.UseVisualStyleBackColor = false;
            this._btnMBRCreate.Click += new System.EventHandler(this._btnMBRCreate_Click);
            // 
            // _btnMBRDelete
            // 
            this._btnMBRDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnMBRDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnMBRDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMBRDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMBRDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnMBRDelete.Location = new System.Drawing.Point(378, 15);
            this._btnMBRDelete.Name = "_btnMBRDelete";
            this._btnMBRDelete.Size = new System.Drawing.Size(150, 61);
            this._btnMBRDelete.TabIndex = 30;
            this._btnMBRDelete.Text = "Supprimer";
            this._btnMBRDelete.UseVisualStyleBackColor = false;
            this._btnMBRDelete.Click += new System.EventHandler(this._btnMBRDelete_Click);
            // 
            // _btnMBRUpdate
            // 
            this._btnMBRUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnMBRUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnMBRUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMBRUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMBRUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnMBRUpdate.Location = new System.Drawing.Point(198, 15);
            this._btnMBRUpdate.Name = "_btnMBRUpdate";
            this._btnMBRUpdate.Size = new System.Drawing.Size(150, 61);
            this._btnMBRUpdate.TabIndex = 31;
            this._btnMBRUpdate.Text = "Modifier";
            this._btnMBRUpdate.UseVisualStyleBackColor = false;
            this._btnMBRUpdate.Click += new System.EventHandler(this._btnMBRUpdate_Click);
            // 
            // _panelMBR_CRUD_btn
            // 
            this._panelMBR_CRUD_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelMBR_CRUD_btn.Controls.Add(this._btnMBRCreate);
            this._panelMBR_CRUD_btn.Controls.Add(this._btnMBRUpdate);
            this._panelMBR_CRUD_btn.Controls.Add(this._btnMBRDelete);
            this._panelMBR_CRUD_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelMBR_CRUD_btn.Location = new System.Drawing.Point(0, 951);
            this._panelMBR_CRUD_btn.Name = "_panelMBR_CRUD_btn";
            this._panelMBR_CRUD_btn.Size = new System.Drawing.Size(545, 94);
            this._panelMBR_CRUD_btn.TabIndex = 32;
            // 
            // _gboxPIL
            // 
            this._gboxPIL.Controls.Add(this._tboxLICCountry);
            this._gboxPIL.Controls.Add(this._labelLICCountry);
            this._gboxPIL.Controls.Add(this._dtpLICExpirationDte);
            this._gboxPIL.Controls.Add(this._labelLICExpirationDte);
            this._gboxPIL.Controls.Add(this._dtpLICObtentionDte);
            this._gboxPIL.Controls.Add(this._labelLICObtentionDte);
            this._gboxPIL.Controls.Add(this._tboxLICNum);
            this._gboxPIL.Controls.Add(this._labelLICNum);
            this._gboxPIL.Controls.Add(this._cboxMBRQual6);
            this._gboxPIL.Controls.Add(this._cboxMBRQual5);
            this._gboxPIL.Controls.Add(this._cboxMBRQual4);
            this._gboxPIL.Controls.Add(this._cboxMBRQual3);
            this._gboxPIL.Controls.Add(this._cboxMBRQual1);
            this._gboxPIL.Controls.Add(this._cboxMBRQual2);
            this._gboxPIL.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gboxPIL.Location = new System.Drawing.Point(14, 474);
            this._gboxPIL.Name = "_gboxPIL";
            this._gboxPIL.Size = new System.Drawing.Size(510, 225);
            this._gboxPIL.TabIndex = 33;
            this._gboxPIL.TabStop = false;
            this._gboxPIL.Text = "LICENCE ET QUALIFICATIONS";
            // 
            // _tboxLICCountry
            // 
            this._tboxLICCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "LicenceCountry", true));
            this._tboxLICCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tboxLICCountry.Location = new System.Drawing.Point(10, 186);
            this._tboxLICCountry.Name = "_tboxLICCountry";
            this._tboxLICCountry.ReadOnly = true;
            this._tboxLICCountry.Size = new System.Drawing.Size(201, 20);
            this._tboxLICCountry.TabIndex = 13;
            // 
            // _labelLICCountry
            // 
            this._labelLICCountry.AutoSize = true;
            this._labelLICCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelLICCountry.Location = new System.Drawing.Point(9, 170);
            this._labelLICCountry.Name = "_labelLICCountry";
            this._labelLICCountry.Size = new System.Drawing.Size(91, 13);
            this._labelLICCountry.TabIndex = 12;
            this._labelLICCountry.Text = "Pays d\'obtention :";
            // 
            // _dtpLICExpirationDte
            // 
            this._dtpLICExpirationDte.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._bsMember, "LicenceExpirationDate", true));
            this._dtpLICExpirationDte.Enabled = false;
            this._dtpLICExpirationDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dtpLICExpirationDte.Location = new System.Drawing.Point(11, 135);
            this._dtpLICExpirationDte.Name = "_dtpLICExpirationDte";
            this._dtpLICExpirationDte.Size = new System.Drawing.Size(200, 20);
            this._dtpLICExpirationDte.TabIndex = 11;
            // 
            // _labelLICExpirationDte
            // 
            this._labelLICExpirationDte.AutoSize = true;
            this._labelLICExpirationDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelLICExpirationDte.Location = new System.Drawing.Point(9, 119);
            this._labelLICExpirationDte.Name = "_labelLICExpirationDte";
            this._labelLICExpirationDte.Size = new System.Drawing.Size(92, 13);
            this._labelLICExpirationDte.TabIndex = 10;
            this._labelLICExpirationDte.Text = "Date d\'expiration :";
            // 
            // _dtpLICObtentionDte
            // 
            this._dtpLICObtentionDte.Checked = false;
            this._dtpLICObtentionDte.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._bsMember, "LicenceObtentionDate", true));
            this._dtpLICObtentionDte.Enabled = false;
            this._dtpLICObtentionDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dtpLICObtentionDte.Location = new System.Drawing.Point(11, 85);
            this._dtpLICObtentionDte.Name = "_dtpLICObtentionDte";
            this._dtpLICObtentionDte.Size = new System.Drawing.Size(200, 20);
            this._dtpLICObtentionDte.TabIndex = 9;
            // 
            // _labelLICObtentionDte
            // 
            this._labelLICObtentionDte.AutoSize = true;
            this._labelLICObtentionDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelLICObtentionDte.Location = new System.Drawing.Point(9, 69);
            this._labelLICObtentionDte.Name = "_labelLICObtentionDte";
            this._labelLICObtentionDte.Size = new System.Drawing.Size(91, 13);
            this._labelLICObtentionDte.TabIndex = 8;
            this._labelLICObtentionDte.Text = "Date d\'obtention :";
            // 
            // _tboxLICNum
            // 
            this._tboxLICNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "LicenceNumber", true));
            this._tboxLICNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tboxLICNum.Location = new System.Drawing.Point(11, 41);
            this._tboxLICNum.Name = "_tboxLICNum";
            this._tboxLICNum.ReadOnly = true;
            this._tboxLICNum.Size = new System.Drawing.Size(201, 20);
            this._tboxLICNum.TabIndex = 7;
            // 
            // _labelLICNum
            // 
            this._labelLICNum.AutoSize = true;
            this._labelLICNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelLICNum.Location = new System.Drawing.Point(9, 25);
            this._labelLICNum.Name = "_labelLICNum";
            this._labelLICNum.Size = new System.Drawing.Size(102, 13);
            this._labelLICNum.TabIndex = 6;
            this._labelLICNum.Text = "Numéro de licence :";
            // 
            // _cboxMBRQual6
            // 
            this._cboxMBRQual6.AutoSize = true;
            this._cboxMBRQual6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._bsMember, "QualificationType6", true));
            this._cboxMBRQual6.Enabled = false;
            this._cboxMBRQual6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboxMBRQual6.Location = new System.Drawing.Point(334, 188);
            this._cboxMBRQual6.Name = "_cboxMBRQual6";
            this._cboxMBRQual6.Size = new System.Drawing.Size(134, 17);
            this._cboxMBRQual6.TabIndex = 5;
            this._cboxMBRQual6.Text = "Classe 6 : Hélicoptères";
            this._cboxMBRQual6.UseVisualStyleBackColor = true;
            // 
            // _cboxMBRQual5
            // 
            this._cboxMBRQual5.AutoSize = true;
            this._cboxMBRQual5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._bsMember, "QualificationType5", true));
            this._cboxMBRQual5.Enabled = false;
            this._cboxMBRQual5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboxMBRQual5.Location = new System.Drawing.Point(334, 159);
            this._cboxMBRQual5.Name = "_cboxMBRQual5";
            this._cboxMBRQual5.Size = new System.Drawing.Size(119, 17);
            this._cboxMBRQual5.TabIndex = 4;
            this._cboxMBRQual5.Text = "Classe 5 : Aérostats";
            this._cboxMBRQual5.UseVisualStyleBackColor = true;
            // 
            // _cboxMBRQual4
            // 
            this._cboxMBRQual4.AutoSize = true;
            this._cboxMBRQual4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._bsMember, "QualificationType4", true));
            this._cboxMBRQual4.Enabled = false;
            this._cboxMBRQual4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboxMBRQual4.Location = new System.Drawing.Point(334, 130);
            this._cboxMBRQual4.Name = "_cboxMBRQual4";
            this._cboxMBRQual4.Size = new System.Drawing.Size(119, 17);
            this._cboxMBRQual4.TabIndex = 3;
            this._cboxMBRQual4.Text = "Classe 4 : Autogires";
            this._cboxMBRQual4.UseVisualStyleBackColor = true;
            // 
            // _cboxMBRQual3
            // 
            this._cboxMBRQual3.AutoSize = true;
            this._cboxMBRQual3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._bsMember, "QualificationType3", true));
            this._cboxMBRQual3.Enabled = false;
            this._cboxMBRQual3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboxMBRQual3.Location = new System.Drawing.Point(334, 101);
            this._cboxMBRQual3.Name = "_cboxMBRQual3";
            this._cboxMBRQual3.Size = new System.Drawing.Size(152, 17);
            this._cboxMBRQual3.TabIndex = 2;
            this._cboxMBRQual3.Text = "Classe 3 : Appareils 3 axes";
            this._cboxMBRQual3.UseVisualStyleBackColor = true;
            // 
            // _cboxMBRQual1
            // 
            this._cboxMBRQual1.AutoSize = true;
            this._cboxMBRQual1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._bsMember, "QualificationType1", true));
            this._cboxMBRQual1.Enabled = false;
            this._cboxMBRQual1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboxMBRQual1.Location = new System.Drawing.Point(334, 42);
            this._cboxMBRQual1.Name = "_cboxMBRQual1";
            this._cboxMBRQual1.Size = new System.Drawing.Size(134, 17);
            this._cboxMBRQual1.TabIndex = 1;
            this._cboxMBRQual1.Text = "Classe 1 : Paramoteurs";
            this._cboxMBRQual1.UseVisualStyleBackColor = true;
            // 
            // _cboxMBRQual2
            // 
            this._cboxMBRQual2.AutoSize = true;
            this._cboxMBRQual2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this._bsMember, "QualificationType2", true));
            this._cboxMBRQual2.Enabled = false;
            this._cboxMBRQual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboxMBRQual2.Location = new System.Drawing.Point(334, 72);
            this._cboxMBRQual2.Name = "_cboxMBRQual2";
            this._cboxMBRQual2.Size = new System.Drawing.Size(130, 17);
            this._cboxMBRQual2.TabIndex = 0;
            this._cboxMBRQual2.Text = "Classe 2 : Pendulaires";
            this._cboxMBRQual2.UseVisualStyleBackColor = true;
            // 
            // _panelMBR_Update_btn
            // 
            this._panelMBR_Update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelMBR_Update_btn.Controls.Add(this._btnMRBUpdateConfirm);
            this._panelMBR_Update_btn.Controls.Add(this._btnMBRUpdateCancel);
            this._panelMBR_Update_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelMBR_Update_btn.Location = new System.Drawing.Point(0, 857);
            this._panelMBR_Update_btn.Name = "_panelMBR_Update_btn";
            this._panelMBR_Update_btn.Size = new System.Drawing.Size(545, 94);
            this._panelMBR_Update_btn.TabIndex = 36;
            // 
            // _btnMRBUpdateConfirm
            // 
            this._btnMRBUpdateConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnMRBUpdateConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnMRBUpdateConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMRBUpdateConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMRBUpdateConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnMRBUpdateConfirm.Location = new System.Drawing.Point(18, 15);
            this._btnMRBUpdateConfirm.Name = "_btnMRBUpdateConfirm";
            this._btnMRBUpdateConfirm.Size = new System.Drawing.Size(150, 61);
            this._btnMRBUpdateConfirm.TabIndex = 29;
            this._btnMRBUpdateConfirm.Text = "Sauvegarder";
            this._btnMRBUpdateConfirm.UseVisualStyleBackColor = false;
            this._btnMRBUpdateConfirm.Click += new System.EventHandler(this._btnMRBUpdateConfirm_Click);
            // 
            // _btnMBRUpdateCancel
            // 
            this._btnMBRUpdateCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnMBRUpdateCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnMBRUpdateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMBRUpdateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMBRUpdateCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnMBRUpdateCancel.Location = new System.Drawing.Point(198, 15);
            this._btnMBRUpdateCancel.Name = "_btnMBRUpdateCancel";
            this._btnMBRUpdateCancel.Size = new System.Drawing.Size(150, 61);
            this._btnMBRUpdateCancel.TabIndex = 31;
            this._btnMBRUpdateCancel.Text = "Annuler";
            this._btnMBRUpdateCancel.UseVisualStyleBackColor = false;
            this._btnMBRUpdateCancel.Click += new System.EventHandler(this._btnMBRUpdateCancel_Click);
            // 
            // _panelMBR_Create_btn
            // 
            this._panelMBR_Create_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelMBR_Create_btn.Controls.Add(this._btnMRBCreateConfirm);
            this._panelMBR_Create_btn.Controls.Add(this._btnMRBCreateCancel);
            this._panelMBR_Create_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelMBR_Create_btn.Location = new System.Drawing.Point(0, 763);
            this._panelMBR_Create_btn.Name = "_panelMBR_Create_btn";
            this._panelMBR_Create_btn.Size = new System.Drawing.Size(545, 94);
            this._panelMBR_Create_btn.TabIndex = 37;
            // 
            // _btnMRBCreateConfirm
            // 
            this._btnMRBCreateConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnMRBCreateConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnMRBCreateConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMRBCreateConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMRBCreateConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnMRBCreateConfirm.Location = new System.Drawing.Point(18, 15);
            this._btnMRBCreateConfirm.Name = "_btnMRBCreateConfirm";
            this._btnMRBCreateConfirm.Size = new System.Drawing.Size(150, 61);
            this._btnMRBCreateConfirm.TabIndex = 29;
            this._btnMRBCreateConfirm.Text = "Sauvegarder";
            this._btnMRBCreateConfirm.UseVisualStyleBackColor = false;
            this._btnMRBCreateConfirm.Click += new System.EventHandler(this._btnMRBCreateConfirm_Click);
            // 
            // _btnMRBCreateCancel
            // 
            this._btnMRBCreateCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnMRBCreateCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnMRBCreateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMRBCreateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMRBCreateCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this._btnMRBCreateCancel.Location = new System.Drawing.Point(198, 15);
            this._btnMRBCreateCancel.Name = "_btnMRBCreateCancel";
            this._btnMRBCreateCancel.Size = new System.Drawing.Size(150, 61);
            this._btnMRBCreateCancel.TabIndex = 31;
            this._btnMRBCreateCancel.Text = "Annuler";
            this._btnMRBCreateCancel.UseVisualStyleBackColor = false;
            this._btnMRBCreateCancel.Click += new System.EventHandler(this._btnMRBCreateCancel_Click);
            // 
            // _labelMBRPhoneNumber
            // 
            this._labelMBRPhoneNumber.AutoSize = true;
            this._labelMBRPhoneNumber.Location = new System.Drawing.Point(23, 246);
            this._labelMBRPhoneNumber.Name = "_labelMBRPhoneNumber";
            this._labelMBRPhoneNumber.Size = new System.Drawing.Size(86, 13);
            this._labelMBRPhoneNumber.TabIndex = 38;
            this._labelMBRPhoneNumber.Text = "Téléphone fixe  :";
            // 
            // _tboxMBRPhoneNumber
            // 
            this._tboxMBRPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tboxMBRPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "PhoneNumber", true));
            this._tboxMBRPhoneNumber.Location = new System.Drawing.Point(164, 243);
            this._tboxMBRPhoneNumber.MaximumSize = new System.Drawing.Size(240, 20);
            this._tboxMBRPhoneNumber.MinimumSize = new System.Drawing.Size(240, 20);
            this._tboxMBRPhoneNumber.Name = "_tboxMBRPhoneNumber";
            this._tboxMBRPhoneNumber.ReadOnly = true;
            this._tboxMBRPhoneNumber.Size = new System.Drawing.Size(240, 20);
            this._tboxMBRPhoneNumber.TabIndex = 39;
            // 
            // _labelMBRCellphoneNumber
            // 
            this._labelMBRCellphoneNumber.AutoSize = true;
            this._labelMBRCellphoneNumber.Location = new System.Drawing.Point(23, 272);
            this._labelMBRCellphoneNumber.Name = "_labelMBRCellphoneNumber";
            this._labelMBRCellphoneNumber.Size = new System.Drawing.Size(40, 13);
            this._labelMBRCellphoneNumber.TabIndex = 40;
            this._labelMBRCellphoneNumber.Text = "GSM  :";
            // 
            // _tboxMBRCellphoneNumber
            // 
            this._tboxMBRCellphoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tboxMBRCellphoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bsMember, "CellphoneNumber", true));
            this._tboxMBRCellphoneNumber.Location = new System.Drawing.Point(164, 269);
            this._tboxMBRCellphoneNumber.MaximumSize = new System.Drawing.Size(240, 20);
            this._tboxMBRCellphoneNumber.MinimumSize = new System.Drawing.Size(240, 20);
            this._tboxMBRCellphoneNumber.Name = "_tboxMBRCellphoneNumber";
            this._tboxMBRCellphoneNumber.ReadOnly = true;
            this._tboxMBRCellphoneNumber.Size = new System.Drawing.Size(240, 20);
            this._tboxMBRCellphoneNumber.TabIndex = 41;
            // 
            // _labelError
            // 
            this._labelError.AutoSize = true;
            this._labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this._labelError.Location = new System.Drawing.Point(18, 706);
            this._labelError.Name = "_labelError";
            this._labelError.Size = new System.Drawing.Size(254, 16);
            this._labelError.TabIndex = 42;
            this._labelError.Text = "ERROR MESSAGE GOES HERE";
            // 
            // UCMemberCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.Controls.Add(this._labelError);
            this.Controls.Add(this._tboxMBRCellphoneNumber);
            this.Controls.Add(this._labelMBRCellphoneNumber);
            this.Controls.Add(this._tboxMBRPhoneNumber);
            this.Controls.Add(this._labelMBRPhoneNumber);
            this.Controls.Add(this._panelMBR_Create_btn);
            this.Controls.Add(this._panelMBR_Update_btn);
            this.Controls.Add(this._gboxPIL);
            this.Controls.Add(this._panelMBR_CRUD_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cboxMBRLocality);
            this.Controls.Add(this._dtpMRBRegistrationDate);
            this.Controls.Add(this._labelMRBRegistrationDate);
            this.Controls.Add(this._tboxMBRZipCode);
            this.Controls.Add(this._labelMBRLocality);
            this.Controls.Add(this._tboxMBRBuildingNumber);
            this.Controls.Add(this._labelMBRBuildingNumber);
            this.Controls.Add(this._tboxMBRBoxNumber);
            this.Controls.Add(this._labelMBRBoxNumber);
            this.Controls.Add(this._tboxMBRResidenceName);
            this.Controls.Add(this._labelMBRResidenceName);
            this.Controls.Add(this._tboxMBRPostalAddress);
            this.Controls.Add(this._labelMBRStreet);
            this.Controls.Add(this._tboxMBREmailAddress);
            this.Controls.Add(this._labelMBREmailAddress);
            this.Controls.Add(this._dtpMBRDteOfBirth);
            this.Controls.Add(this._labelMBRDteOfBirth);
            this.Controls.Add(this._cboxMBRSex);
            this.Controls.Add(this._labelMBRSex);
            this.Controls.Add(this._tboxMBRID);
            this.Controls.Add(this._labelMBRID);
            this.Controls.Add(this._tboxMBRFirstName);
            this.Controls.Add(this._tboxMBRLastName);
            this.Controls.Add(this._labelMBRFirstName);
            this.Controls.Add(this._labelMBRLastName);
            this.Name = "UCMemberCRUD";
            this.Size = new System.Drawing.Size(545, 1045);
            ((System.ComponentModel.ISupportInitialize)(this._bsMember)).EndInit();
            this._panelMBR_CRUD_btn.ResumeLayout(false);
            this._gboxPIL.ResumeLayout(false);
            this._gboxPIL.PerformLayout();
            this._panelMBR_Update_btn.ResumeLayout(false);
            this._panelMBR_Create_btn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelMBRLastName;
        private System.Windows.Forms.Label _labelMBRFirstName;
        private System.Windows.Forms.TextBox _tboxMBRLastName;
        private System.Windows.Forms.TextBox _tboxMBRFirstName;
        private System.Windows.Forms.Label _labelMBRID;
        private System.Windows.Forms.TextBox _tboxMBRID;
        private System.Windows.Forms.Label _labelMBRSex;
        private System.Windows.Forms.ComboBox _cboxMBRSex;
        private System.Windows.Forms.BindingSource _bsMember;
        private System.Windows.Forms.Label _labelMBRDteOfBirth;
        private System.Windows.Forms.DateTimePicker _dtpMBRDteOfBirth;
        private System.Windows.Forms.Label _labelMBREmailAddress;
        private System.Windows.Forms.TextBox _tboxMBREmailAddress;
        private System.Windows.Forms.Label _labelMBRStreet;
        private System.Windows.Forms.TextBox _tboxMBRPostalAddress;
        private System.Windows.Forms.Label _labelMBRResidenceName;
        private System.Windows.Forms.TextBox _tboxMBRResidenceName;
        private System.Windows.Forms.Label _labelMBRBoxNumber;
        private System.Windows.Forms.TextBox _tboxMBRBoxNumber;
        private System.Windows.Forms.Label _labelMBRBuildingNumber;
        private System.Windows.Forms.TextBox _tboxMBRBuildingNumber;
        private System.Windows.Forms.Label _labelMBRLocality;
        private System.Windows.Forms.TextBox _tboxMBRZipCode;
        private System.Windows.Forms.Label _labelMRBRegistrationDate;
        private System.Windows.Forms.DateTimePicker _dtpMRBRegistrationDate;
        private System.Windows.Forms.ComboBox _cboxMBRLocality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnMBRCreate;
        private System.Windows.Forms.Button _btnMBRDelete;
        private System.Windows.Forms.Button _btnMBRUpdate;
        private System.Windows.Forms.Panel _panelMBR_CRUD_btn;
        private System.Windows.Forms.GroupBox _gboxPIL;
        private System.Windows.Forms.CheckBox _cboxMBRQual6;
        private System.Windows.Forms.CheckBox _cboxMBRQual5;
        private System.Windows.Forms.CheckBox _cboxMBRQual4;
        private System.Windows.Forms.CheckBox _cboxMBRQual3;
        private System.Windows.Forms.CheckBox _cboxMBRQual1;
        private System.Windows.Forms.CheckBox _cboxMBRQual2;
        private System.Windows.Forms.TextBox _tboxLICCountry;
        private System.Windows.Forms.Label _labelLICCountry;
        private System.Windows.Forms.DateTimePicker _dtpLICExpirationDte;
        private System.Windows.Forms.Label _labelLICExpirationDte;
        private System.Windows.Forms.DateTimePicker _dtpLICObtentionDte;
        private System.Windows.Forms.Label _labelLICObtentionDte;
        private System.Windows.Forms.TextBox _tboxLICNum;
        private System.Windows.Forms.Label _labelLICNum;
        private System.Windows.Forms.Panel _panelMBR_Update_btn;
        private System.Windows.Forms.Button _btnMRBUpdateConfirm;
        private System.Windows.Forms.Button _btnMBRUpdateCancel;
        private System.Windows.Forms.Panel _panelMBR_Create_btn;
        private System.Windows.Forms.Button _btnMRBCreateConfirm;
        private System.Windows.Forms.Button _btnMRBCreateCancel;
        private System.Windows.Forms.Label _labelMBRPhoneNumber;
        private System.Windows.Forms.TextBox _tboxMBRPhoneNumber;
        private System.Windows.Forms.Label _labelMBRCellphoneNumber;
        private System.Windows.Forms.TextBox _tboxMBRCellphoneNumber;
        private System.Windows.Forms.Label _labelError;
    }
}
