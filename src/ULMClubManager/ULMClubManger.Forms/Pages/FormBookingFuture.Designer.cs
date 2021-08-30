
namespace ULMClubManger.Forms.Pages
{
    partial class FormBookingFuture
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._bsBookings = new System.Windows.Forms.BindingSource(this.components);
            this._dgvBookings = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AircraftRegistration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AircraftCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runwayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._panelFooterBookingFuture = new System.Windows.Forms.Panel();
            this._panelTopBookingFuture = new System.Windows.Forms.Panel();
            this._labelBookingFutureTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._bsBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookings)).BeginInit();
            this._panelTopBookingFuture.SuspendLayout();
            this.SuspendLayout();
            // 
            // _bsBookings
            // 
            this._bsBookings.DataSource = typeof(ULMClubManager.DTO.DetailedBooking);
            // 
            // _dgvBookings
            // 
            this._dgvBookings.AllowUserToAddRows = false;
            this._dgvBookings.AllowUserToDeleteRows = false;
            this._dgvBookings.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._dgvBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dgvBookings.AutoGenerateColumns = false;
            this._dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.MemberFullName,
            this.aircraftIDDataGridViewTextBoxColumn,
            this.AircraftRegistration,
            this.AircraftCategoryID,
            this.dateDataGridViewTextBoxColumn,
            this.startHourDataGridViewTextBoxColumn,
            this.endHourDataGridViewTextBoxColumn,
            this.runwayIDDataGridViewTextBoxColumn});
            this._dgvBookings.DataSource = this._bsBookings;
            this._dgvBookings.Location = new System.Drawing.Point(157, 124);
            this._dgvBookings.Margin = new System.Windows.Forms.Padding(10);
            this._dgvBookings.Name = "_dgvBookings";
            this._dgvBookings.ReadOnly = true;
            this._dgvBookings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._dgvBookings.RowHeadersVisible = false;
            this._dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvBookings.Size = new System.Drawing.Size(800, 472);
            this._dgvBookings.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Num RES";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // MemberFullName
            // 
            this.MemberFullName.DataPropertyName = "MemberFullName";
            this.MemberFullName.HeaderText = "Pilote";
            this.MemberFullName.Name = "MemberFullName";
            this.MemberFullName.ReadOnly = true;
            this.MemberFullName.Width = 150;
            // 
            // aircraftIDDataGridViewTextBoxColumn
            // 
            this.aircraftIDDataGridViewTextBoxColumn.DataPropertyName = "AircraftID";
            this.aircraftIDDataGridViewTextBoxColumn.HeaderText = "ULM";
            this.aircraftIDDataGridViewTextBoxColumn.Name = "aircraftIDDataGridViewTextBoxColumn";
            this.aircraftIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aircraftIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // AircraftRegistration
            // 
            this.AircraftRegistration.DataPropertyName = "AircraftRegistration";
            this.AircraftRegistration.HeaderText = "Immatriculation";
            this.AircraftRegistration.Name = "AircraftRegistration";
            this.AircraftRegistration.ReadOnly = true;
            // 
            // AircraftCategoryID
            // 
            this.AircraftCategoryID.DataPropertyName = "AircraftCategoryID";
            this.AircraftCategoryID.HeaderText = "Type";
            this.AircraftCategoryID.Name = "AircraftCategoryID";
            this.AircraftCategoryID.ReadOnly = true;
            this.AircraftCategoryID.Width = 50;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startHourDataGridViewTextBoxColumn
            // 
            this.startHourDataGridViewTextBoxColumn.DataPropertyName = "StartHour";
            this.startHourDataGridViewTextBoxColumn.HeaderText = "Heure de début";
            this.startHourDataGridViewTextBoxColumn.Name = "startHourDataGridViewTextBoxColumn";
            this.startHourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endHourDataGridViewTextBoxColumn
            // 
            this.endHourDataGridViewTextBoxColumn.DataPropertyName = "EndHour";
            this.endHourDataGridViewTextBoxColumn.HeaderText = "Heure de fin";
            this.endHourDataGridViewTextBoxColumn.Name = "endHourDataGridViewTextBoxColumn";
            this.endHourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // runwayIDDataGridViewTextBoxColumn
            // 
            this.runwayIDDataGridViewTextBoxColumn.DataPropertyName = "RunwayID";
            this.runwayIDDataGridViewTextBoxColumn.HeaderText = "Piste";
            this.runwayIDDataGridViewTextBoxColumn.Name = "runwayIDDataGridViewTextBoxColumn";
            this.runwayIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.runwayIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // _panelFooterBookingFuture
            // 
            this._panelFooterBookingFuture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelFooterBookingFuture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelFooterBookingFuture.Location = new System.Drawing.Point(0, 690);
            this._panelFooterBookingFuture.Name = "_panelFooterBookingFuture";
            this._panelFooterBookingFuture.Size = new System.Drawing.Size(1093, 94);
            this._panelFooterBookingFuture.TabIndex = 43;
            // 
            // _panelTopBookingFuture
            // 
            this._panelTopBookingFuture.Controls.Add(this._labelBookingFutureTitle);
            this._panelTopBookingFuture.Controls.Add(this._dgvBookings);
            this._panelTopBookingFuture.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelTopBookingFuture.Location = new System.Drawing.Point(0, 0);
            this._panelTopBookingFuture.Name = "_panelTopBookingFuture";
            this._panelTopBookingFuture.Size = new System.Drawing.Size(1093, 690);
            this._panelTopBookingFuture.TabIndex = 44;
            // 
            // _labelBookingFutureTitle
            // 
            this._labelBookingFutureTitle.AutoSize = true;
            this._labelBookingFutureTitle.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold);
            this._labelBookingFutureTitle.Location = new System.Drawing.Point(14, 5);
            this._labelBookingFutureTitle.Name = "_labelBookingFutureTitle";
            this._labelBookingFutureTitle.Size = new System.Drawing.Size(404, 36);
            this._labelBookingFutureTitle.TabIndex = 3;
            this._labelBookingFutureTitle.Text = "RESERVATION A VENIR";
            // 
            // FormBookingFuture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1093, 784);
            this.Controls.Add(this._panelTopBookingFuture);
            this.Controls.Add(this._panelFooterBookingFuture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBookingFuture";
            this.Text = "FormBookingFuture";
            ((System.ComponentModel.ISupportInitialize)(this._bsBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookings)).EndInit();
            this._panelTopBookingFuture.ResumeLayout(false);
            this._panelTopBookingFuture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource _bsBookings;
        private System.Windows.Forms.DataGridView _dgvBookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircraftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AircraftRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn AircraftCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runwayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel _panelFooterBookingFuture;
        private System.Windows.Forms.Panel _panelTopBookingFuture;
        private System.Windows.Forms.Label _labelBookingFutureTitle;
    }
}