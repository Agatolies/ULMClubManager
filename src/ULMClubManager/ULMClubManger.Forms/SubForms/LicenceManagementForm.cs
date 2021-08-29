using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULMClubManager.BL.Services;
using ULMClubManager.DTO;

namespace ULMClubManger.Forms.SubForms
{
    public partial class LicenceManagementForm : Form
    {
        private Member _member;

        public LicenceManagementForm(Member member)
        {
            _member = member;

            InitializeComponent();
            InitializeData();

            _tboxMemberName.Text = member.FullName;
            _tboxMemberName.ReadOnly = true;
        }

        private void InitializeData()
        {
            List<Withdrawal> withdrawalForPilot = WithdrawalService.ReadAllWithdrawalsByPilotID(_member.ID.Value);

            _bsWithdrawals.DataSource = withdrawalForPilot;
        }

        private Withdrawal ExtractWithdrawalFromForm()
        {
            return new Withdrawal(
                _dtpStartDate.Value,
                _dtpEndDate.Value,
                _rtbReason.Text,
                _member.ID.Value);
        }

        private void _btnAddWithdrawal_Click(object sender, EventArgs e)
        {
            Withdrawal withdrawal = ExtractWithdrawalFromForm();
            WithdrawalService.CreateOne(withdrawal);
            InitializeData();
        }
    }
}
