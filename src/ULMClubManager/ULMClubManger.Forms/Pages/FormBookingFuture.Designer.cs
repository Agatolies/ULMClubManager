
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
            this._bsBookings = new System.Windows.Forms.BindingSource(this.components);
            this._dgvBookings = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancellationReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancellationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancellationHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircraftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runwayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._bsBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookings)).BeginInit();
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
            this._dgvBookings.AutoGenerateColumns = false;
            this._dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.startHourDataGridViewTextBoxColumn,
            this.endHourDataGridViewTextBoxColumn,
            this.cancellationReasonDataGridViewTextBoxColumn,
            this.cancellationDateDataGridViewTextBoxColumn,
            this.cancellationHourDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.aircraftIDDataGridViewTextBoxColumn,
            this.runwayIDDataGridViewTextBoxColumn});
            this._dgvBookings.DataSource = this._bsBookings;
            this._dgvBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvBookings.Location = new System.Drawing.Point(0, 0);
            this._dgvBookings.Name = "_dgvBookings";
            this._dgvBookings.ReadOnly = true;
            this._dgvBookings.Size = new System.Drawing.Size(800, 450);
            this._dgvBookings.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.startHourDataGridViewTextBoxColumn.HeaderText = "StartHour";
            this.startHourDataGridViewTextBoxColumn.Name = "startHourDataGridViewTextBoxColumn";
            this.startHourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endHourDataGridViewTextBoxColumn
            // 
            this.endHourDataGridViewTextBoxColumn.DataPropertyName = "EndHour";
            this.endHourDataGridViewTextBoxColumn.HeaderText = "EndHour";
            this.endHourDataGridViewTextBoxColumn.Name = "endHourDataGridViewTextBoxColumn";
            this.endHourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cancellationReasonDataGridViewTextBoxColumn
            // 
            this.cancellationReasonDataGridViewTextBoxColumn.DataPropertyName = "CancellationReason";
            this.cancellationReasonDataGridViewTextBoxColumn.HeaderText = "CancellationReason";
            this.cancellationReasonDataGridViewTextBoxColumn.Name = "cancellationReasonDataGridViewTextBoxColumn";
            this.cancellationReasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cancellationDateDataGridViewTextBoxColumn
            // 
            this.cancellationDateDataGridViewTextBoxColumn.DataPropertyName = "CancellationDate";
            this.cancellationDateDataGridViewTextBoxColumn.HeaderText = "CancellationDate";
            this.cancellationDateDataGridViewTextBoxColumn.Name = "cancellationDateDataGridViewTextBoxColumn";
            this.cancellationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cancellationHourDataGridViewTextBoxColumn
            // 
            this.cancellationHourDataGridViewTextBoxColumn.DataPropertyName = "CancellationHour";
            this.cancellationHourDataGridViewTextBoxColumn.HeaderText = "CancellationHour";
            this.cancellationHourDataGridViewTextBoxColumn.Name = "cancellationHourDataGridViewTextBoxColumn";
            this.cancellationHourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aircraftIDDataGridViewTextBoxColumn
            // 
            this.aircraftIDDataGridViewTextBoxColumn.DataPropertyName = "AircraftID";
            this.aircraftIDDataGridViewTextBoxColumn.HeaderText = "AircraftID";
            this.aircraftIDDataGridViewTextBoxColumn.Name = "aircraftIDDataGridViewTextBoxColumn";
            this.aircraftIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // runwayIDDataGridViewTextBoxColumn
            // 
            this.runwayIDDataGridViewTextBoxColumn.DataPropertyName = "RunwayID";
            this.runwayIDDataGridViewTextBoxColumn.HeaderText = "RunwayID";
            this.runwayIDDataGridViewTextBoxColumn.Name = "runwayIDDataGridViewTextBoxColumn";
            this.runwayIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormBookingFuture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._dgvBookings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBookingFuture";
            this.Text = "FormBookingFuture";
            ((System.ComponentModel.ISupportInitialize)(this._bsBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource _bsBookings;
        private System.Windows.Forms.DataGridView _dgvBookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancellationReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancellationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancellationHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircraftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runwayIDDataGridViewTextBoxColumn;
    }
}