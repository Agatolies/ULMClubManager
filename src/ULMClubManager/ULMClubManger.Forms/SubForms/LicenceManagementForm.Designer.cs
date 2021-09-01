
namespace ULMClubManger.Forms.SubForms
{
    partial class LicenceManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dgvWithdrawals = new System.Windows.Forms.DataGridView();
            this._bsWithdrawals = new System.Windows.Forms.BindingSource(this.components);
            this._panelFooterWithdrawal = new System.Windows.Forms.Panel();
            this._btnAddWithdrawal = new System.Windows.Forms.Button();
            this._tboxWithdrawalMemberName = new System.Windows.Forms.TextBox();
            this._dtpWithdrawalStartDate = new System.Windows.Forms.DateTimePicker();
            this._dtpWithdrawalEndDate = new System.Windows.Forms.DateTimePicker();
            this._rtbWithdrawalReason = new System.Windows.Forms.RichTextBox();
            this._lableMemberName = new System.Windows.Forms.Label();
            this._labelWithdrawalStartDate = new System.Windows.Forms.Label();
            this._labelWithdrawalEndDate = new System.Windows.Forms.Label();
            this._labelWithdrawalReason = new System.Windows.Forms.Label();
            this._colWithdrawalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colWithdrawalStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colWithdrawalEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colWithdrawalReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dgvWithdrawals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsWithdrawals)).BeginInit();
            this._panelFooterWithdrawal.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dgvWithdrawals
            // 
            this._dgvWithdrawals.AllowUserToAddRows = false;
            this._dgvWithdrawals.AllowUserToDeleteRows = false;
            this._dgvWithdrawals.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._dgvWithdrawals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dgvWithdrawals.AutoGenerateColumns = false;
            this._dgvWithdrawals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this._dgvWithdrawals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._colWithdrawalID,
            this._colWithdrawalStartDate,
            this._colWithdrawalEndDate,
            this._colWithdrawalReason});
            this._dgvWithdrawals.DataSource = this._bsWithdrawals;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgvWithdrawals.DefaultCellStyle = dataGridViewCellStyle2;
            this._dgvWithdrawals.Location = new System.Drawing.Point(42, 12);
            this._dgvWithdrawals.Name = "_dgvWithdrawals";
            this._dgvWithdrawals.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvWithdrawals.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._dgvWithdrawals.RowHeadersVisible = false;
            this._dgvWithdrawals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvWithdrawals.Size = new System.Drawing.Size(677, 150);
            this._dgvWithdrawals.TabIndex = 0;
            // 
            // _bsWithdrawals
            // 
            this._bsWithdrawals.DataSource = typeof(ULMClubManager.DTO.Withdrawal);
            // 
            // _panelFooterWithdrawal
            // 
            this._panelFooterWithdrawal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this._panelFooterWithdrawal.Controls.Add(this._btnAddWithdrawal);
            this._panelFooterWithdrawal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelFooterWithdrawal.Location = new System.Drawing.Point(0, 382);
            this._panelFooterWithdrawal.Name = "_panelFooterWithdrawal";
            this._panelFooterWithdrawal.Size = new System.Drawing.Size(800, 68);
            this._panelFooterWithdrawal.TabIndex = 1;
            // 
            // _btnAddWithdrawal
            // 
            this._btnAddWithdrawal.BackColor = System.Drawing.Color.WhiteSmoke;
            this._btnAddWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAddWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAddWithdrawal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this._btnAddWithdrawal.Location = new System.Drawing.Point(22, 19);
            this._btnAddWithdrawal.Name = "_btnAddWithdrawal";
            this._btnAddWithdrawal.Size = new System.Drawing.Size(115, 37);
            this._btnAddWithdrawal.TabIndex = 0;
            this._btnAddWithdrawal.Text = "Ajouter";
            this._btnAddWithdrawal.UseVisualStyleBackColor = false;
            this._btnAddWithdrawal.Click += new System.EventHandler(this._btnAddWithdrawal_Click);
            // 
            // _tboxWithdrawalMemberName
            // 
            this._tboxWithdrawalMemberName.Location = new System.Drawing.Point(201, 190);
            this._tboxWithdrawalMemberName.Name = "_tboxWithdrawalMemberName";
            this._tboxWithdrawalMemberName.Size = new System.Drawing.Size(100, 20);
            this._tboxWithdrawalMemberName.TabIndex = 2;
            // 
            // _dtpWithdrawalStartDate
            // 
            this._dtpWithdrawalStartDate.Location = new System.Drawing.Point(201, 228);
            this._dtpWithdrawalStartDate.Name = "_dtpWithdrawalStartDate";
            this._dtpWithdrawalStartDate.Size = new System.Drawing.Size(200, 20);
            this._dtpWithdrawalStartDate.TabIndex = 3;
            // 
            // _dtpWithdrawalEndDate
            // 
            this._dtpWithdrawalEndDate.Location = new System.Drawing.Point(201, 269);
            this._dtpWithdrawalEndDate.Name = "_dtpWithdrawalEndDate";
            this._dtpWithdrawalEndDate.Size = new System.Drawing.Size(200, 20);
            this._dtpWithdrawalEndDate.TabIndex = 4;
            // 
            // _rtbWithdrawalReason
            // 
            this._rtbWithdrawalReason.Location = new System.Drawing.Point(427, 218);
            this._rtbWithdrawalReason.Name = "_rtbWithdrawalReason";
            this._rtbWithdrawalReason.Size = new System.Drawing.Size(292, 81);
            this._rtbWithdrawalReason.TabIndex = 5;
            this._rtbWithdrawalReason.Text = "";
            // 
            // _lableMemberName
            // 
            this._lableMemberName.AutoSize = true;
            this._lableMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lableMemberName.Location = new System.Drawing.Point(39, 193);
            this._lableMemberName.Name = "_lableMemberName";
            this._lableMemberName.Size = new System.Drawing.Size(39, 13);
            this._lableMemberName.TabIndex = 6;
            this._lableMemberName.Text = "Pilote";
            // 
            // _labelWithdrawalStartDate
            // 
            this._labelWithdrawalStartDate.AutoSize = true;
            this._labelWithdrawalStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelWithdrawalStartDate.Location = new System.Drawing.Point(39, 234);
            this._labelWithdrawalStartDate.Name = "_labelWithdrawalStartDate";
            this._labelWithdrawalStartDate.Size = new System.Drawing.Size(143, 13);
            this._labelWithdrawalStartDate.TabIndex = 7;
            this._labelWithdrawalStartDate.Text = "Date de début du retrait";
            // 
            // _labelWithdrawalEndDate
            // 
            this._labelWithdrawalEndDate.AutoSize = true;
            this._labelWithdrawalEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelWithdrawalEndDate.Location = new System.Drawing.Point(39, 276);
            this._labelWithdrawalEndDate.Name = "_labelWithdrawalEndDate";
            this._labelWithdrawalEndDate.Size = new System.Drawing.Size(125, 13);
            this._labelWithdrawalEndDate.TabIndex = 8;
            this._labelWithdrawalEndDate.Text = "Date de fin du retrait";
            // 
            // _labelWithdrawalReason
            // 
            this._labelWithdrawalReason.AutoSize = true;
            this._labelWithdrawalReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelWithdrawalReason.Location = new System.Drawing.Point(424, 193);
            this._labelWithdrawalReason.Name = "_labelWithdrawalReason";
            this._labelWithdrawalReason.Size = new System.Drawing.Size(35, 13);
            this._labelWithdrawalReason.TabIndex = 9;
            this._labelWithdrawalReason.Text = "Motif";
            // 
            // _colWithdrawalID
            // 
            this._colWithdrawalID.DataPropertyName = "ID";
            this._colWithdrawalID.HeaderText = "ID";
            this._colWithdrawalID.Name = "_colWithdrawalID";
            this._colWithdrawalID.ReadOnly = true;
            this._colWithdrawalID.Width = 50;
            // 
            // _colWithdrawalStartDate
            // 
            this._colWithdrawalStartDate.DataPropertyName = "StartDate";
            this._colWithdrawalStartDate.HeaderText = "Date de début";
            this._colWithdrawalStartDate.Name = "_colWithdrawalStartDate";
            this._colWithdrawalStartDate.ReadOnly = true;
            this._colWithdrawalStartDate.Width = 120;
            // 
            // _colWithdrawalEndDate
            // 
            this._colWithdrawalEndDate.DataPropertyName = "EndDate";
            this._colWithdrawalEndDate.HeaderText = "Date de fin";
            this._colWithdrawalEndDate.Name = "_colWithdrawalEndDate";
            this._colWithdrawalEndDate.ReadOnly = true;
            this._colWithdrawalEndDate.Width = 120;
            // 
            // _colWithdrawalReason
            // 
            this._colWithdrawalReason.DataPropertyName = "Reason";
            this._colWithdrawalReason.HeaderText = "Motif";
            this._colWithdrawalReason.Name = "_colWithdrawalReason";
            this._colWithdrawalReason.ReadOnly = true;
            this._colWithdrawalReason.Width = 385;
            // 
            // LicenceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._labelWithdrawalReason);
            this.Controls.Add(this._labelWithdrawalEndDate);
            this.Controls.Add(this._labelWithdrawalStartDate);
            this.Controls.Add(this._lableMemberName);
            this.Controls.Add(this._rtbWithdrawalReason);
            this.Controls.Add(this._dtpWithdrawalEndDate);
            this.Controls.Add(this._dtpWithdrawalStartDate);
            this.Controls.Add(this._tboxWithdrawalMemberName);
            this.Controls.Add(this._panelFooterWithdrawal);
            this.Controls.Add(this._dgvWithdrawals);
            this.Name = "LicenceManagementForm";
            this.Text = "LicenceManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this._dgvWithdrawals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsWithdrawals)).EndInit();
            this._panelFooterWithdrawal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgvWithdrawals;
        private System.Windows.Forms.BindingSource _bsWithdrawals;
        private System.Windows.Forms.Panel _panelFooterWithdrawal;
        private System.Windows.Forms.Button _btnAddWithdrawal;
        private System.Windows.Forms.TextBox _tboxWithdrawalMemberName;
        private System.Windows.Forms.DateTimePicker _dtpWithdrawalStartDate;
        private System.Windows.Forms.DateTimePicker _dtpWithdrawalEndDate;
        private System.Windows.Forms.RichTextBox _rtbWithdrawalReason;
        private System.Windows.Forms.Label _lableMemberName;
        private System.Windows.Forms.Label _labelWithdrawalStartDate;
        private System.Windows.Forms.Label _labelWithdrawalEndDate;
        private System.Windows.Forms.Label _labelWithdrawalReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colWithdrawalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colWithdrawalStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colWithdrawalEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colWithdrawalReason;
    }
}