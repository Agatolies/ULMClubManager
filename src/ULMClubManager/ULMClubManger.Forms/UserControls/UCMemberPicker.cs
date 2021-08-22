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

        public UCMemberPicker()
        {
            InitializeComponent();
            InitializeData();
        }

        public void InitializeData()
        {
            try
            {
                _allMembers = MemberService.ReadAll();
                _lbMembers.DataSource = _allMembers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
