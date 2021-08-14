
namespace ULMClubManger.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDEB_NOM = new System.Windows.Forms.TextBox();
            this.btCharger = new System.Windows.Forms.Button();
            this._dgvPIL = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_DEB_PIL_NOM = new System.Windows.Forms.TextBox();
            this._bt_Read = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._tabPageDelete = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this._tboxLastName = new System.Windows.Forms.TextBox();
            this._labelLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._labelFirstName = new System.Windows.Forms.Label();
            this._tboxFirstName = new System.Windows.Forms.TextBox();
            this._labelSex = new System.Windows.Forms.Label();
            this._labelBirthday = new System.Windows.Forms.Label();
            this._dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this._labelRegistrationDate = new System.Windows.Forms.Label();
            this._dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this._labelStreetName = new System.Windows.Forms.Label();
            this._tboxStreetName = new System.Windows.Forms.TextBox();
            this._labelResidenceNumber = new System.Windows.Forms.Label();
            this._tboxResidenceNumber = new System.Windows.Forms.TextBox();
            this._labelBuildingNumber = new System.Windows.Forms.Label();
            this._tboxBuildingNumber = new System.Windows.Forms.TextBox();
            this._labelStreetNumber = new System.Windows.Forms.Label();
            this._tboxStreetNumber = new System.Windows.Forms.TextBox();
            this._labelZipCode = new System.Windows.Forms.Label();
            this._tboxZipCode = new System.Windows.Forms.TextBox();
            this._lablePhoneNumber = new System.Windows.Forms.Label();
            this._tboxPhoneNumber = new System.Windows.Forms.TextBox();
            this._labelMobilePhoneNumber = new System.Windows.Forms.Label();
            this._tboxMobilePhoneNumber = new System.Windows.Forms.TextBox();
            this._labelEmailAddress = new System.Windows.Forms.Label();
            this._tboxEmailAddress = new System.Windows.Forms.TextBox();
            this._labelAdmin = new System.Windows.Forms.Label();
            this._checkAdmin = new System.Windows.Forms.CheckBox();
            this._labelUserPSD = new System.Windows.Forms.Label();
            this._tboxUserPSD = new System.Windows.Forms.TextBox();
            this._labelUserPWD = new System.Windows.Forms.Label();
            this._tboxUserPWD = new System.Windows.Forms.TextBox();
            this._btnInsertPilot = new System.Windows.Forms.Button();
            this._tboxSex = new System.Windows.Forms.TextBox();
            this._labelISPilot = new System.Windows.Forms.Label();
            this._chekPilotYes = new System.Windows.Forms.CheckBox();
            this._checkPilotNo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvPIL)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDEB_NOM
            // 
            this.tbDEB_NOM.Location = new System.Drawing.Point(52, -106);
            this.tbDEB_NOM.Name = "tbDEB_NOM";
            this.tbDEB_NOM.Size = new System.Drawing.Size(664, 22);
            this.tbDEB_NOM.TabIndex = 0;
            // 
            // btCharger
            // 
            this.btCharger.Location = new System.Drawing.Point(722, -106);
            this.btCharger.Name = "btCharger";
            this.btCharger.Size = new System.Drawing.Size(75, 23);
            this.btCharger.TabIndex = 1;
            this.btCharger.Text = "Charger";
            this.btCharger.UseVisualStyleBackColor = true;
            // 
            // _dgvPIL
            // 
            this._dgvPIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvPIL.Location = new System.Drawing.Point(8, 63);
            this._dgvPIL.Name = "_dgvPIL";
            this._dgvPIL.RowHeadersWidth = 51;
            this._dgvPIL.RowTemplate.Height = 24;
            this._dgvPIL.Size = new System.Drawing.Size(1502, 739);
            this._dgvPIL.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this._tabPageDelete);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1525, 838);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1517, 809);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_DEB_PIL_NOM);
            this.panel1.Controls.Add(this._bt_Read);
            this.panel1.Controls.Add(this._dgvPIL);
            this.panel1.Controls.Add(this.tbDEB_NOM);
            this.panel1.Controls.Add(this.btCharger);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1517, 809);
            this.panel1.TabIndex = 0;
            // 
            // tb_DEB_PIL_NOM
            // 
            this.tb_DEB_PIL_NOM.Location = new System.Drawing.Point(90, 9);
            this.tb_DEB_PIL_NOM.Name = "tb_DEB_PIL_NOM";
            this.tb_DEB_PIL_NOM.Size = new System.Drawing.Size(1420, 22);
            this.tb_DEB_PIL_NOM.TabIndex = 4;
            // 
            // _bt_Read
            // 
            this._bt_Read.BackColor = System.Drawing.SystemColors.MenuBar;
            this._bt_Read.Location = new System.Drawing.Point(1410, 35);
            this._bt_Read.Name = "_bt_Read";
            this._bt_Read.Size = new System.Drawing.Size(100, 22);
            this._bt_Read.TabIndex = 3;
            this._bt_Read.Text = "Lire";
            this._bt_Read.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._bt_Read.Click += new System.EventHandler(this.btRead_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this._checkPilotNo);
            this.tabPage2.Controls.Add(this._chekPilotYes);
            this.tabPage2.Controls.Add(this._labelISPilot);
            this.tabPage2.Controls.Add(this._tboxSex);
            this.tabPage2.Controls.Add(this._btnInsertPilot);
            this.tabPage2.Controls.Add(this._tboxUserPWD);
            this.tabPage2.Controls.Add(this._labelUserPWD);
            this.tabPage2.Controls.Add(this._tboxUserPSD);
            this.tabPage2.Controls.Add(this._labelUserPSD);
            this.tabPage2.Controls.Add(this._checkAdmin);
            this.tabPage2.Controls.Add(this._labelAdmin);
            this.tabPage2.Controls.Add(this._tboxEmailAddress);
            this.tabPage2.Controls.Add(this._labelEmailAddress);
            this.tabPage2.Controls.Add(this._tboxMobilePhoneNumber);
            this.tabPage2.Controls.Add(this._labelMobilePhoneNumber);
            this.tabPage2.Controls.Add(this._tboxPhoneNumber);
            this.tabPage2.Controls.Add(this._lablePhoneNumber);
            this.tabPage2.Controls.Add(this._tboxZipCode);
            this.tabPage2.Controls.Add(this._labelZipCode);
            this.tabPage2.Controls.Add(this._tboxStreetNumber);
            this.tabPage2.Controls.Add(this._labelStreetNumber);
            this.tabPage2.Controls.Add(this._tboxBuildingNumber);
            this.tabPage2.Controls.Add(this._labelBuildingNumber);
            this.tabPage2.Controls.Add(this._tboxResidenceNumber);
            this.tabPage2.Controls.Add(this._labelResidenceNumber);
            this.tabPage2.Controls.Add(this._tboxStreetName);
            this.tabPage2.Controls.Add(this._labelStreetName);
            this.tabPage2.Controls.Add(this._dtpRegistrationDate);
            this.tabPage2.Controls.Add(this._labelRegistrationDate);
            this.tabPage2.Controls.Add(this._dtpBirthday);
            this.tabPage2.Controls.Add(this._labelBirthday);
            this.tabPage2.Controls.Add(this._labelSex);
            this.tabPage2.Controls.Add(this._tboxFirstName);
            this.tabPage2.Controls.Add(this._labelFirstName);
            this.tabPage2.Controls.Add(this._labelLastName);
            this.tabPage2.Controls.Add(this._tboxLastName);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1517, 809);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insert";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _tabPageDelete
            // 
            this._tabPageDelete.Location = new System.Drawing.Point(4, 25);
            this._tabPageDelete.Name = "_tabPageDelete";
            this._tabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageDelete.Size = new System.Drawing.Size(1517, 809);
            this._tabPageDelete.TabIndex = 2;
            this._tabPageDelete.Text = "Delete";
            this._tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(803, 418);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // _tboxLastName
            // 
            this._tboxLastName.Location = new System.Drawing.Point(190, 14);
            this._tboxLastName.Name = "_tboxLastName";
            this._tboxLastName.Size = new System.Drawing.Size(226, 22);
            this._tboxLastName.TabIndex = 0;
            // 
            // _labelLastName
            // 
            this._labelLastName.AutoSize = true;
            this._labelLastName.Location = new System.Drawing.Point(25, 17);
            this._labelLastName.Name = "_labelLastName";
            this._labelLastName.Size = new System.Drawing.Size(37, 17);
            this._labelLastName.TabIndex = 1;
            this._labelLastName.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Début nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // _labelFirstName
            // 
            this._labelFirstName.AutoSize = true;
            this._labelFirstName.Location = new System.Drawing.Point(25, 52);
            this._labelFirstName.Name = "_labelFirstName";
            this._labelFirstName.Size = new System.Drawing.Size(57, 17);
            this._labelFirstName.TabIndex = 2;
            this._labelFirstName.Text = "Prénom";
            this._labelFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // _tboxFirstName
            // 
            this._tboxFirstName.Location = new System.Drawing.Point(190, 49);
            this._tboxFirstName.Name = "_tboxFirstName";
            this._tboxFirstName.Size = new System.Drawing.Size(226, 22);
            this._tboxFirstName.TabIndex = 3;
            // 
            // _labelSex
            // 
            this._labelSex.AutoSize = true;
            this._labelSex.Location = new System.Drawing.Point(23, 90);
            this._labelSex.Name = "_labelSex";
            this._labelSex.Size = new System.Drawing.Size(39, 17);
            this._labelSex.TabIndex = 5;
            this._labelSex.Text = "Sexe";
            // 
            // _labelBirthday
            // 
            this._labelBirthday.AutoSize = true;
            this._labelBirthday.Location = new System.Drawing.Point(28, 137);
            this._labelBirthday.Name = "_labelBirthday";
            this._labelBirthday.Size = new System.Drawing.Size(126, 17);
            this._labelBirthday.TabIndex = 6;
            this._labelBirthday.Text = "Date de naissance";
            // 
            // _dtpBirthday
            // 
            this._dtpBirthday.Location = new System.Drawing.Point(190, 132);
            this._dtpBirthday.Name = "_dtpBirthday";
            this._dtpBirthday.Size = new System.Drawing.Size(226, 22);
            this._dtpBirthday.TabIndex = 7;
            // 
            // _labelRegistrationDate
            // 
            this._labelRegistrationDate.AutoSize = true;
            this._labelRegistrationDate.Location = new System.Drawing.Point(28, 179);
            this._labelRegistrationDate.Name = "_labelRegistrationDate";
            this._labelRegistrationDate.Size = new System.Drawing.Size(117, 17);
            this._labelRegistrationDate.TabIndex = 8;
            this._labelRegistrationDate.Text = "Date d\'inscription";
            // 
            // _dtpRegistrationDate
            // 
            this._dtpRegistrationDate.Location = new System.Drawing.Point(190, 174);
            this._dtpRegistrationDate.Name = "_dtpRegistrationDate";
            this._dtpRegistrationDate.Size = new System.Drawing.Size(226, 22);
            this._dtpRegistrationDate.TabIndex = 9;
            // 
            // _labelStreetName
            // 
            this._labelStreetName.AutoSize = true;
            this._labelStreetName.Location = new System.Drawing.Point(28, 219);
            this._labelStreetName.Name = "_labelStreetName";
            this._labelStreetName.Size = new System.Drawing.Size(34, 17);
            this._labelStreetName.TabIndex = 10;
            this._labelStreetName.Text = "Rue";
            // 
            // _tboxStreetName
            // 
            this._tboxStreetName.Location = new System.Drawing.Point(190, 216);
            this._tboxStreetName.Name = "_tboxStreetName";
            this._tboxStreetName.Size = new System.Drawing.Size(226, 22);
            this._tboxStreetName.TabIndex = 11;
            // 
            // _labelResidenceNumber
            // 
            this._labelResidenceNumber.AutoSize = true;
            this._labelResidenceNumber.Location = new System.Drawing.Point(25, 262);
            this._labelResidenceNumber.Name = "_labelResidenceNumber";
            this._labelResidenceNumber.Size = new System.Drawing.Size(144, 17);
            this._labelResidenceNumber.TabIndex = 12;
            this._labelResidenceNumber.Text = "Numéro de résidence";
            // 
            // _tboxResidenceNumber
            // 
            this._tboxResidenceNumber.Location = new System.Drawing.Point(190, 259);
            this._tboxResidenceNumber.Name = "_tboxResidenceNumber";
            this._tboxResidenceNumber.Size = new System.Drawing.Size(226, 22);
            this._tboxResidenceNumber.TabIndex = 13;
            // 
            // _labelBuildingNumber
            // 
            this._labelBuildingNumber.AutoSize = true;
            this._labelBuildingNumber.Location = new System.Drawing.Point(28, 305);
            this._labelBuildingNumber.Name = "_labelBuildingNumber";
            this._labelBuildingNumber.Size = new System.Drawing.Size(166, 21);
            this._labelBuildingNumber.TabIndex = 14;
            this._labelBuildingNumber.Text = "Numéro d\'immeuble";
            // 
            // _tboxBuildingNumber
            // 
            this._tboxBuildingNumber.Location = new System.Drawing.Point(190, 302);
            this._tboxBuildingNumber.Name = "_tboxBuildingNumber";
            this._tboxBuildingNumber.Size = new System.Drawing.Size(226, 22);
            this._tboxBuildingNumber.TabIndex = 15;
            // 
            // _labelStreetNumber
            // 
            this._labelStreetNumber.AutoSize = true;
            this._labelStreetNumber.Location = new System.Drawing.Point(28, 345);
            this._labelStreetNumber.Name = "_labelStreetNumber";
            this._labelStreetNumber.Size = new System.Drawing.Size(73, 21);
            this._labelStreetNumber.TabIndex = 16;
            this._labelStreetNumber.Text = "Numéro";
            // 
            // _tboxStreetNumber
            // 
            this._tboxStreetNumber.Location = new System.Drawing.Point(190, 342);
            this._tboxStreetNumber.Name = "_tboxStreetNumber";
            this._tboxStreetNumber.Size = new System.Drawing.Size(226, 22);
            this._tboxStreetNumber.TabIndex = 17;
            // 
            // _labelZipCode
            // 
            this._labelZipCode.AutoSize = true;
            this._labelZipCode.Location = new System.Drawing.Point(28, 385);
            this._labelZipCode.Name = "_labelZipCode";
            this._labelZipCode.Size = new System.Drawing.Size(83, 17);
            this._labelZipCode.TabIndex = 18;
            this._labelZipCode.Text = "Code postal";
            // 
            // _tboxZipCode
            // 
            this._tboxZipCode.Location = new System.Drawing.Point(190, 385);
            this._tboxZipCode.Name = "_tboxZipCode";
            this._tboxZipCode.Size = new System.Drawing.Size(226, 22);
            this._tboxZipCode.TabIndex = 19;
            // 
            // _lablePhoneNumber
            // 
            this._lablePhoneNumber.AutoSize = true;
            this._lablePhoneNumber.Location = new System.Drawing.Point(28, 432);
            this._lablePhoneNumber.Name = "_lablePhoneNumber";
            this._lablePhoneNumber.Size = new System.Drawing.Size(76, 17);
            this._lablePhoneNumber.TabIndex = 20;
            this._lablePhoneNumber.Text = "Téléphone";
            // 
            // _tboxPhoneNumber
            // 
            this._tboxPhoneNumber.Location = new System.Drawing.Point(190, 432);
            this._tboxPhoneNumber.Name = "_tboxPhoneNumber";
            this._tboxPhoneNumber.Size = new System.Drawing.Size(226, 22);
            this._tboxPhoneNumber.TabIndex = 21;
            // 
            // _labelMobilePhoneNumber
            // 
            this._labelMobilePhoneNumber.AutoSize = true;
            this._labelMobilePhoneNumber.Location = new System.Drawing.Point(28, 468);
            this._labelMobilePhoneNumber.Name = "_labelMobilePhoneNumber";
            this._labelMobilePhoneNumber.Size = new System.Drawing.Size(49, 21);
            this._labelMobilePhoneNumber.TabIndex = 22;
            this._labelMobilePhoneNumber.Text = "GSM";
            // 
            // _tboxMobilePhoneNumber
            // 
            this._tboxMobilePhoneNumber.Location = new System.Drawing.Point(190, 468);
            this._tboxMobilePhoneNumber.Name = "_tboxMobilePhoneNumber";
            this._tboxMobilePhoneNumber.Size = new System.Drawing.Size(226, 22);
            this._tboxMobilePhoneNumber.TabIndex = 23;
            // 
            // _labelEmailAddress
            // 
            this._labelEmailAddress.AutoSize = true;
            this._labelEmailAddress.Location = new System.Drawing.Point(28, 504);
            this._labelEmailAddress.Name = "_labelEmailAddress";
            this._labelEmailAddress.Size = new System.Drawing.Size(121, 21);
            this._labelEmailAddress.TabIndex = 24;
            this._labelEmailAddress.Text = "Adresse email";
            // 
            // _tboxEmailAddress
            // 
            this._tboxEmailAddress.Location = new System.Drawing.Point(190, 504);
            this._tboxEmailAddress.Name = "_tboxEmailAddress";
            this._tboxEmailAddress.Size = new System.Drawing.Size(226, 22);
            this._tboxEmailAddress.TabIndex = 25;
            // 
            // _labelAdmin
            // 
            this._labelAdmin.AutoSize = true;
            this._labelAdmin.Location = new System.Drawing.Point(28, 544);
            this._labelAdmin.Name = "_labelAdmin";
            this._labelAdmin.Size = new System.Drawing.Size(124, 21);
            this._labelAdmin.TabIndex = 26;
            this._labelAdmin.Text = "Administrateur";
            // 
            // _checkAdmin
            // 
            this._checkAdmin.AutoSize = true;
            this._checkAdmin.Location = new System.Drawing.Point(190, 544);
            this._checkAdmin.Name = "_checkAdmin";
            this._checkAdmin.Size = new System.Drawing.Size(18, 17);
            this._checkAdmin.TabIndex = 27;
            this._checkAdmin.UseVisualStyleBackColor = true;
            // 
            // _labelUserPSD
            // 
            this._labelUserPSD.AutoSize = true;
            this._labelUserPSD.Location = new System.Drawing.Point(28, 582);
            this._labelUserPSD.Name = "_labelUserPSD";
            this._labelUserPSD.Size = new System.Drawing.Size(70, 21);
            this._labelUserPSD.TabIndex = 28;
            this._labelUserPSD.Text = "Pseudo";
            this._labelUserPSD.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // _tboxUserPSD
            // 
            this._tboxUserPSD.Location = new System.Drawing.Point(190, 582);
            this._tboxUserPSD.Name = "_tboxUserPSD";
            this._tboxUserPSD.Size = new System.Drawing.Size(226, 22);
            this._tboxUserPSD.TabIndex = 29;
            // 
            // _labelUserPWD
            // 
            this._labelUserPWD.AutoSize = true;
            this._labelUserPWD.Location = new System.Drawing.Point(28, 623);
            this._labelUserPWD.Name = "_labelUserPWD";
            this._labelUserPWD.Size = new System.Drawing.Size(116, 21);
            this._labelUserPWD.TabIndex = 30;
            this._labelUserPWD.Text = "Mot de passe";
            // 
            // _tboxUserPWD
            // 
            this._tboxUserPWD.Location = new System.Drawing.Point(190, 620);
            this._tboxUserPWD.Name = "_tboxUserPWD";
            this._tboxUserPWD.Size = new System.Drawing.Size(226, 22);
            this._tboxUserPWD.TabIndex = 31;
            // 
            // _btnInsertPilot
            // 
            this._btnInsertPilot.Location = new System.Drawing.Point(802, 739);
            this._btnInsertPilot.Name = "_btnInsertPilot";
            this._btnInsertPilot.Size = new System.Drawing.Size(75, 23);
            this._btnInsertPilot.TabIndex = 32;
            this._btnInsertPilot.Text = "Ajouter";
            this._btnInsertPilot.UseVisualStyleBackColor = true;
            this._btnInsertPilot.Click += new System.EventHandler(this._btnInsertPilot_Click);
            // 
            // _tboxSex
            // 
            this._tboxSex.Location = new System.Drawing.Point(190, 90);
            this._tboxSex.Name = "_tboxSex";
            this._tboxSex.Size = new System.Drawing.Size(226, 22);
            this._tboxSex.TabIndex = 33;
            // 
            // _labelISPilot
            // 
            this._labelISPilot.AutoSize = true;
            this._labelISPilot.Location = new System.Drawing.Point(28, 669);
            this._labelISPilot.Name = "_labelISPilot";
            this._labelISPilot.Size = new System.Drawing.Size(236, 17);
            this._labelISPilot.TabIndex = 34;
            this._labelISPilot.Text = "Avez-vous une licence de pilotage ?";
            // 
            // _chekPilotYes
            // 
            this._chekPilotYes.AutoSize = true;
            this._chekPilotYes.Location = new System.Drawing.Point(308, 669);
            this._chekPilotYes.Name = "_chekPilotYes";
            this._chekPilotYes.Size = new System.Drawing.Size(52, 21);
            this._chekPilotYes.TabIndex = 35;
            this._chekPilotYes.Text = "Oui";
            this._chekPilotYes.UseVisualStyleBackColor = true;
            this._chekPilotYes.Click += new System.EventHandler(this._chekPilotYes_Click);
            // 
            // _checkPilotNo
            // 
            this._checkPilotNo.AutoSize = true;
            this._checkPilotNo.Location = new System.Drawing.Point(432, 668);
            this._checkPilotNo.Name = "_checkPilotNo";
            this._checkPilotNo.Size = new System.Drawing.Size(56, 21);
            this._checkPilotNo.TabIndex = 36;
            this._checkPilotNo.Text = "Non";
            this._checkPilotNo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1355, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 839);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ULM Club Manager Liège";
            ((System.ComponentModel.ISupportInitialize)(this._dgvPIL)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDEB_NOM;
        private System.Windows.Forms.Button btCharger;
        private System.Windows.Forms.DataGridView _dgvPIL;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox _bt_Read;
        private System.Windows.Forms.TextBox tb_DEB_PIL_NOM;
        private System.Windows.Forms.TabPage _tabPageDelete;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _labelLastName;
        private System.Windows.Forms.TextBox _tboxLastName;
        private System.Windows.Forms.Label _labelFirstName;
        private System.Windows.Forms.TextBox _tboxFirstName;
        private System.Windows.Forms.Label _labelSex;
        private System.Windows.Forms.Label _labelUserPSD;
        private System.Windows.Forms.CheckBox _checkAdmin;
        private System.Windows.Forms.Label _labelAdmin;
        private System.Windows.Forms.TextBox _tboxEmailAddress;
        private System.Windows.Forms.Label _labelEmailAddress;
        private System.Windows.Forms.TextBox _tboxMobilePhoneNumber;
        private System.Windows.Forms.Label _labelMobilePhoneNumber;
        private System.Windows.Forms.TextBox _tboxPhoneNumber;
        private System.Windows.Forms.Label _lablePhoneNumber;
        private System.Windows.Forms.TextBox _tboxZipCode;
        private System.Windows.Forms.Label _labelZipCode;
        private System.Windows.Forms.TextBox _tboxStreetNumber;
        private System.Windows.Forms.Label _labelStreetNumber;
        private System.Windows.Forms.TextBox _tboxBuildingNumber;
        private System.Windows.Forms.Label _labelBuildingNumber;
        private System.Windows.Forms.TextBox _tboxResidenceNumber;
        private System.Windows.Forms.Label _labelResidenceNumber;
        private System.Windows.Forms.TextBox _tboxStreetName;
        private System.Windows.Forms.Label _labelStreetName;
        private System.Windows.Forms.DateTimePicker _dtpRegistrationDate;
        private System.Windows.Forms.Label _labelRegistrationDate;
        private System.Windows.Forms.DateTimePicker _dtpBirthday;
        private System.Windows.Forms.Label _labelBirthday;
        private System.Windows.Forms.Button _btnInsertPilot;
        private System.Windows.Forms.TextBox _tboxUserPWD;
        private System.Windows.Forms.Label _labelUserPWD;
        private System.Windows.Forms.TextBox _tboxUserPSD;
        private System.Windows.Forms.TextBox _tboxSex;
        private System.Windows.Forms.CheckBox _checkPilotNo;
        private System.Windows.Forms.CheckBox _chekPilotYes;
        private System.Windows.Forms.Label _labelISPilot;
        private System.Windows.Forms.Button button1;
    }
}