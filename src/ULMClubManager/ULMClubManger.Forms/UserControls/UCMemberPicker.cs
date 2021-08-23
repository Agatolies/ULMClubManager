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
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCMemberPicker : UserControl
    {
        public event delSelect SelectMember;

        private List<Member> _allMembers;
        private List<Member> _allPilots;
        private List<Member> _allSupporters;

        public UCMemberPicker()
        {
            InitializeComponent();
        }

        public void InitializeData()
        {
            try
            {
                _allMembers = MemberService.ReadAll();
                _lbMembers.DataSource = _allMembers;

                _allPilots = _allMembers.Where(member => member.IsPilot).ToList();
                _allSupporters = _allMembers.Where(member => member.IsSupporter).ToList();

                //Comment alimenter la DataSource de _cboxMemberTypes???
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCMemberPicker_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void _tboxSearchMember_TextChanged(object sender, EventArgs e)
        {
            string searchLetters = _tboxSearchMember.Text;

            List<Member> filteredMembers = _allMembers
                .Where(member => member.FullName.Contains(searchLetters))
                .ToList();

            _lbMembers.DataSource = filteredMembers;
        }

        private void _lbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lbMembers.DataSource != null && this.SelectMember != null)
                this.SelectMember(((Member)_lbMembers.SelectedItem).ID.Value);
        }
    }
}
