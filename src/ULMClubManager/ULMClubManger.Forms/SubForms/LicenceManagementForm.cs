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

            _tboxWithdrawalMemberName.Text = member.FullName;
            _tboxWithdrawalMemberName.ReadOnly = true;
        }

        private void InitializeData()
        {
            List<Withdrawal> withdrawalForPilot = WithdrawalService.ReadAllWithdrawalsByPilotID(_member.ID.Value);

            _bsWithdrawals.DataSource = withdrawalForPilot;
        }

        private Withdrawal ExtractWithdrawalFromForm()
        {
            return new Withdrawal(
                _dtpWithdrawalStartDate.Value,
                _dtpWithdrawalEndDate.Value,
                _rtbWithdrawalReason.Text,
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
