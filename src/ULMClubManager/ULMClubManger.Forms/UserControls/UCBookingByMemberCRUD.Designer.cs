
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
            this._labelBookingByMember_CRUD_Title1 = new System.Windows.Forms.Label();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._panelBookingByMember_CRUD_Title = new System.Windows.Forms.Panel();
            this._paneldgvBookingMemberCRUD = new System.Windows.Forms.Panel();
            this._dgvBookingByMemberCRUD = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runwayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this._panelBookingByMember_CRUD_Title.SuspendLayout();
            this._paneldgvBookingMemberCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookingByMemberCRUD)).BeginInit();
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
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(ULMClubManager.DTO.Booking);
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
            this._paneldgvBookingMemberCRUD.Controls.Add(this._dgvBookingByMemberCRUD);
            this._paneldgvBookingMemberCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this._paneldgvBookingMemberCRUD.Location = new System.Drawing.Point(0, 54);
            this._paneldgvBookingMemberCRUD.Name = "_paneldgvBookingMemberCRUD";
            this._paneldgvBookingMemberCRUD.Size = new System.Drawing.Size(925, 991);
            this._paneldgvBookingMemberCRUD.TabIndex = 35;
            // 
            // _dgvBookingByMemberCRUD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._dgvBookingByMemberCRUD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dgvBookingByMemberCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvBookingByMemberCRUD.AutoGenerateColumns = false;
            this._dgvBookingByMemberCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvBookingByMemberCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvBookingByMemberCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dgvBookingByMemberCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvBookingByMemberCRUD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.aircraftIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.startHourDataGridViewTextBoxColumn,
            this.endHourDataGridViewTextBoxColumn,
            this.runwayIDDataGridViewTextBoxColumn});
            this._dgvBookingByMemberCRUD.DataSource = this.bookingBindingSource;
            this._dgvBookingByMemberCRUD.GridColor = System.Drawing.Color.Gainsboro;
            this._dgvBookingByMemberCRUD.Location = new System.Drawing.Point(20, 19);
            this._dgvBookingByMemberCRUD.Name = "_dgvBookingByMemberCRUD";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvBookingByMemberCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._dgvBookingByMemberCRUD.Size = new System.Drawing.Size(877, 750);
            this._dgvBookingByMemberCRUD.TabIndex = 33;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID réservation";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 135;
            // 
            // aircraftIDDataGridViewTextBoxColumn
            // 
            this.aircraftIDDataGridViewTextBoxColumn.DataPropertyName = "AircraftID";
            this.aircraftIDDataGridViewTextBoxColumn.HeaderText = "ULM ID";
            this.aircraftIDDataGridViewTextBoxColumn.Name = "aircraftIDDataGridViewTextBoxColumn";
            this.aircraftIDDataGridViewTextBoxColumn.Width = 135;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 135;
            // 
            // startHourDataGridViewTextBoxColumn
            // 
            this.startHourDataGridViewTextBoxColumn.DataPropertyName = "StartHour";
            this.startHourDataGridViewTextBoxColumn.HeaderText = "Heure de début";
            this.startHourDataGridViewTextBoxColumn.Name = "startHourDataGridViewTextBoxColumn";
            this.startHourDataGridViewTextBoxColumn.Width = 135;
            // 
            // endHourDataGridViewTextBoxColumn
            // 
            this.endHourDataGridViewTextBoxColumn.DataPropertyName = "EndHour";
            this.endHourDataGridViewTextBoxColumn.HeaderText = "Heure de fin";
            this.endHourDataGridViewTextBoxColumn.Name = "endHourDataGridViewTextBoxColumn";
            this.endHourDataGridViewTextBoxColumn.Width = 135;
            // 
            // runwayIDDataGridViewTextBoxColumn
            // 
            this.runwayIDDataGridViewTextBoxColumn.DataPropertyName = "RunwayID";
            this.runwayIDDataGridViewTextBoxColumn.HeaderText = "Piste";
            this.runwayIDDataGridViewTextBoxColumn.Name = "runwayIDDataGridViewTextBoxColumn";
            this.runwayIDDataGridViewTextBoxColumn.Width = 135;
            // 
            // UCBookingByMemberCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this._paneldgvBookingMemberCRUD);
            this.Controls.Add(this._panelBookingByMember_CRUD_Title);
            this.Name = "UCBookingByMemberCRUD";
            this.Size = new System.Drawing.Size(925, 1045);
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this._panelBookingByMember_CRUD_Title.ResumeLayout(false);
            this._panelBookingByMember_CRUD_Title.PerformLayout();
            this._paneldgvBookingMemberCRUD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookingByMemberCRUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _labelBookingByMember_CRUD_Title1;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.Panel _panelBookingByMember_CRUD_Title;
        private System.Windows.Forms.Panel _paneldgvBookingMemberCRUD;
        private System.Windows.Forms.DataGridView _dgvBookingByMemberCRUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircraftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runwayIDDataGridViewTextBoxColumn;
    }
}
