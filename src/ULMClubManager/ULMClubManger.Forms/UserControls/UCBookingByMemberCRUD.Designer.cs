
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this._labelBookingByMember_CRUD_Title = new System.Windows.Forms.Label();
            this._panelBookingByMember_CRUD_Title = new System.Windows.Forms.Panel();
            this._paneldgvBookingMemberCRUD = new System.Windows.Forms.Panel();
            this._labelBookingByMember_CancellationTitle = new System.Windows.Forms.Label();
            this._dgvCancellationByMember = new System.Windows.Forms.DataGridView();
            this._bsCancellations = new System.Windows.Forms.BindingSource(this.components);
            this._dgvBookingByMember = new System.Windows.Forms.DataGridView();
            this._bsBookings = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftRegistrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunwayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AircraftRegistration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancellationReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._panelBookingByMember_CRUD_Title.SuspendLayout();
            this._paneldgvBookingMemberCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvCancellationByMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsCancellations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookingByMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // _labelBookingByMember_CRUD_Title
            // 
            this._labelBookingByMember_CRUD_Title.AutoSize = true;
            this._labelBookingByMember_CRUD_Title.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelBookingByMember_CRUD_Title.Location = new System.Drawing.Point(14, 5);
            this._labelBookingByMember_CRUD_Title.Name = "_labelBookingByMember_CRUD_Title";
            this._labelBookingByMember_CRUD_Title.Size = new System.Drawing.Size(652, 36);
            this._labelBookingByMember_CRUD_Title.TabIndex = 29;
            this._labelBookingByMember_CRUD_Title.Text = "LISTE DES RESERVATIONS PAR PILOTE";
            // 
            // _panelBookingByMember_CRUD_Title
            // 
            this._panelBookingByMember_CRUD_Title.Controls.Add(this._labelBookingByMember_CRUD_Title);
            this._panelBookingByMember_CRUD_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelBookingByMember_CRUD_Title.Location = new System.Drawing.Point(0, 0);
            this._panelBookingByMember_CRUD_Title.Name = "_panelBookingByMember_CRUD_Title";
            this._panelBookingByMember_CRUD_Title.Size = new System.Drawing.Size(925, 54);
            this._panelBookingByMember_CRUD_Title.TabIndex = 32;
            // 
            // _paneldgvBookingMemberCRUD
            // 
            this._paneldgvBookingMemberCRUD.Controls.Add(this._labelBookingByMember_CancellationTitle);
            this._paneldgvBookingMemberCRUD.Controls.Add(this._dgvCancellationByMember);
            this._paneldgvBookingMemberCRUD.Controls.Add(this._dgvBookingByMember);
            this._paneldgvBookingMemberCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this._paneldgvBookingMemberCRUD.Location = new System.Drawing.Point(0, 54);
            this._paneldgvBookingMemberCRUD.Name = "_paneldgvBookingMemberCRUD";
            this._paneldgvBookingMemberCRUD.Size = new System.Drawing.Size(925, 510);
            this._paneldgvBookingMemberCRUD.TabIndex = 35;
            // 
            // _labelBookingByMember_CancellationTitle
            // 
            this._labelBookingByMember_CancellationTitle.AutoSize = true;
            this._labelBookingByMember_CancellationTitle.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold);
            this._labelBookingByMember_CancellationTitle.Location = new System.Drawing.Point(15, 261);
            this._labelBookingByMember_CancellationTitle.Name = "_labelBookingByMember_CancellationTitle";
            this._labelBookingByMember_CancellationTitle.Size = new System.Drawing.Size(340, 27);
            this._labelBookingByMember_CancellationTitle.TabIndex = 36;
            this._labelBookingByMember_CancellationTitle.Text = "RESERVATIONS ANNULEES";
            // 
            // _dgvCancellationByMember
            // 
            this._dgvCancellationByMember.AllowUserToAddRows = false;
            this._dgvCancellationByMember.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this._dgvCancellationByMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dgvCancellationByMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvCancellationByMember.AutoGenerateColumns = false;
            this._dgvCancellationByMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvCancellationByMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvCancellationByMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dgvCancellationByMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvCancellationByMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MemberFullName,
            this.AircraftRegistration,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.cancellationReasonDataGridViewTextBoxColumn});
            this._dgvCancellationByMember.DataSource = this._bsCancellations;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgvCancellationByMember.DefaultCellStyle = dataGridViewCellStyle3;
            this._dgvCancellationByMember.Enabled = false;
            this._dgvCancellationByMember.GridColor = System.Drawing.Color.Gainsboro;
            this._dgvCancellationByMember.Location = new System.Drawing.Point(20, 291);
            this._dgvCancellationByMember.Name = "_dgvCancellationByMember";
            this._dgvCancellationByMember.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvCancellationByMember.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._dgvCancellationByMember.RowHeadersVisible = false;
            this._dgvCancellationByMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgvCancellationByMember.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dgvCancellationByMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvCancellationByMember.ShowEditingIcon = false;
            this._dgvCancellationByMember.Size = new System.Drawing.Size(877, 168);
            this._dgvCancellationByMember.TabIndex = 35;
            // 
            // _bsCancellations
            // 
            this._bsCancellations.DataSource = typeof(ULMClubManager.DTO.DetailedBooking);
            // 
            // _dgvBookingByMember
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this._dgvBookingByMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this._dgvBookingByMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvBookingByMember.AutoGenerateColumns = false;
            this._dgvBookingByMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvBookingByMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvBookingByMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._dgvBookingByMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvBookingByMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.aircraftRegistrationDataGridViewTextBoxColumn,
            this.RunwayID,
            this.Date,
            this.StartHour,
            this.EndHour});
            this._dgvBookingByMember.DataSource = this._bsBookings;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgvBookingByMember.DefaultCellStyle = dataGridViewCellStyle7;
            this._dgvBookingByMember.GridColor = System.Drawing.Color.Gainsboro;
            this._dgvBookingByMember.Location = new System.Drawing.Point(20, 19);
            this._dgvBookingByMember.Name = "_dgvBookingByMember";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvBookingByMember.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this._dgvBookingByMember.RowHeadersVisible = false;
            this._dgvBookingByMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgvBookingByMember.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dgvBookingByMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvBookingByMember.Size = new System.Drawing.Size(877, 227);
            this._dgvBookingByMember.TabIndex = 33;
            this._dgvBookingByMember.SelectionChanged += new System.EventHandler(this._dgvBookingByMemberCRUD_SelectionChanged);
            // 
            // _bsBookings
            // 
            this._bsBookings.DataSource = typeof(ULMClubManager.DTO.DetailedBooking);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Num RES";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MemberFullName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Pilote";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // aircraftRegistrationDataGridViewTextBoxColumn
            // 
            this.aircraftRegistrationDataGridViewTextBoxColumn.DataPropertyName = "AircraftRegistration";
            this.aircraftRegistrationDataGridViewTextBoxColumn.HeaderText = "ULM";
            this.aircraftRegistrationDataGridViewTextBoxColumn.Name = "aircraftRegistrationDataGridViewTextBoxColumn";
            this.aircraftRegistrationDataGridViewTextBoxColumn.ReadOnly = true;
            this.aircraftRegistrationDataGridViewTextBoxColumn.Width = 142;
            // 
            // RunwayID
            // 
            this.RunwayID.DataPropertyName = "RunwayID";
            this.RunwayID.HeaderText = "Piste";
            this.RunwayID.Name = "RunwayID";
            this.RunwayID.ReadOnly = true;
            this.RunwayID.Width = 50;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 143;
            // 
            // StartHour
            // 
            this.StartHour.DataPropertyName = "StartHour";
            this.StartHour.HeaderText = "Heure de début";
            this.StartHour.Name = "StartHour";
            this.StartHour.Width = 142;
            // 
            // EndHour
            // 
            this.EndHour.DataPropertyName = "EndHour";
            this.EndHour.HeaderText = "Heure de fin";
            this.EndHour.Name = "EndHour";
            this.EndHour.Width = 143;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Num RES";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // MemberFullName
            // 
            this.MemberFullName.DataPropertyName = "MemberFullName";
            this.MemberFullName.HeaderText = "Pilote";
            this.MemberFullName.Name = "MemberFullName";
            this.MemberFullName.ReadOnly = true;
            // 
            // AircraftRegistration
            // 
            this.AircraftRegistration.DataPropertyName = "AircraftRegistration";
            this.AircraftRegistration.HeaderText = "ULM";
            this.AircraftRegistration.Name = "AircraftRegistration";
            this.AircraftRegistration.ReadOnly = true;
            this.AircraftRegistration.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RunwayID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Piste";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndHour";
            this.dataGridViewTextBoxColumn5.HeaderText = "Heure de fin";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartHour";
            this.dataGridViewTextBoxColumn4.HeaderText = "Heure de début";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // cancellationReasonDataGridViewTextBoxColumn
            // 
            this.cancellationReasonDataGridViewTextBoxColumn.DataPropertyName = "CancellationReason";
            this.cancellationReasonDataGridViewTextBoxColumn.HeaderText = "Motif";
            this.cancellationReasonDataGridViewTextBoxColumn.Name = "cancellationReasonDataGridViewTextBoxColumn";
            this.cancellationReasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.cancellationReasonDataGridViewTextBoxColumn.Width = 200;
            // 
            // UCBookingByMemberCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this._paneldgvBookingMemberCRUD);
            this.Controls.Add(this._panelBookingByMember_CRUD_Title);
            this.Name = "UCBookingByMemberCRUD";
            this.Size = new System.Drawing.Size(925, 564);
            this._panelBookingByMember_CRUD_Title.ResumeLayout(false);
            this._panelBookingByMember_CRUD_Title.PerformLayout();
            this._paneldgvBookingMemberCRUD.ResumeLayout(false);
            this._paneldgvBookingMemberCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvCancellationByMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsCancellations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookingByMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _labelBookingByMember_CRUD_Title;
        private System.Windows.Forms.BindingSource _bsBookings;
        private System.Windows.Forms.Panel _panelBookingByMember_CRUD_Title;
        private System.Windows.Forms.Panel _paneldgvBookingMemberCRUD;
        private System.Windows.Forms.DataGridView _dgvBookingByMember;
        private System.Windows.Forms.BindingSource _bsCancellations;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label _labelBookingByMember_CancellationTitle;
        private System.Windows.Forms.DataGridView _dgvCancellationByMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AircraftRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancellationReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircraftRegistrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunwayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndHour;
    }
}
