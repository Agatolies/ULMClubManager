using System.Data;
using ULMClubManager.BL.Services;
using ULMClubManager.DTO;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCMemberPicker : UserControl
    {
        public event delSelectMember? SelectMember;

        private List<Member>? _allMembers;
        private List<Member>? _allPilots;
        private List<Member>? _allSupporters;

        public UCMemberPicker()
        {
            InitializeComponent();

            _cboxMemberTypes.DisplayMember = "Description";
            _cboxMemberTypes.ValueMember = "Key";
        }

        public void InitializeData()
        {
            try
            {
                _allMembers = MemberService.ReadAll();
                _allPilots = _allMembers.Where(member => member.IsPilot).ToList();
                _allSupporters = _allMembers.Where(member => member.IsSupporter).ToList();

                _lbMembers.DataSource = _allMembers;
                _cboxMemberTypes.DataSource = MemberType.GetMemberTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterMembers()
        {
            string searchLetters = _tboxSearchMember.Text;
            MemberType memberType = (MemberType)_cboxMemberTypes.SelectedItem;

            List<Member> filteredMembers;

            switch (memberType.Key)
            {
                case MemberTypeKey.Pilot:
                    filteredMembers = _allPilots;
                    break;
                case MemberTypeKey.Supporter:
                    filteredMembers = _allSupporters;
                    break;
                case MemberTypeKey.Member:
                default:
                    filteredMembers = _allMembers;
                    break;
            }

            filteredMembers = filteredMembers
                .Where(member => member.FullName.IndexOf(searchLetters, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            _lbMembers.DataSource = filteredMembers;
        }

        private void UCMemberPicker_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void _tboxSearchMember_TextChanged(object sender, EventArgs e)
        {
            FilterMembers();
        }

        private void _lbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lbMembers.DataSource != null && SelectMember != null)
                SelectMember(((Member)_lbMembers.SelectedItem).ID.Value);
        }

        private void _cboxMemberTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMembers();
        }
    }
}
