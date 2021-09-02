using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ULMClubManager.BL.Services;
using ULMClubManager.DTO;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCBookingPickerByMember : UserControl
    {
        public event delSelectMember SelectPilot;

        private List<Member> _allPilots;

        public UCBookingPickerByMember()
        {
            InitializeComponent();
        }

        public void InitializeData()
        {
            try
            {
                _allPilots = MemberService.ReadAll().Where(member => member.IsPilot).ToList();
                _lbPilots.DataSource = _allPilots;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterPilots()
        {
            string searchLetters = _tboxSearchPilot.Text;

            List<Member> filteredPilots = _allPilots
                .Where(member => member.FullName.IndexOf(searchLetters, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            _lbPilots.DataSource = filteredPilots;
        }

        private void UCBookingPickerByMember_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void _tboxSearchPilot_TextChanged(object sender, EventArgs e)
        {
            FilterPilots();
        }

        private void _lbPilots_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lbPilots.DataSource != null && SelectPilot != null)
                SelectPilot(((Member)_lbPilots.SelectedItem).ID.Value);
        }
    }
}
