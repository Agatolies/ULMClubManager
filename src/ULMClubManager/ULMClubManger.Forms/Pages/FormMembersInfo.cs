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
using ULMClubManager.DTO.Abstractions;
using ULMClubManger.Forms.UserControls;

namespace ULMClubManger.Forms.Pages
{
    public partial class FormMembersInfo : Form
    {
        private List<IMember> _allMembers;

        public FormMembersInfo()
        {
            InitializeComponent();
            InitializeData();

            // Nous mettons notre titre
            //OverallWindow.Text = OverallWindow.Text += " - Données signalétiques d'un membre";
        }

        //public UCLayout ParentLayout => this.Parent.Parent as UCLayout;
        //public Form1 OverallWindow => ParentLayout.Parent as Form1;


        public void InitializeData()
        {
            try
            {
                _allMembers = UserService.ReadAll();
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

            List<IMember> filteredMembers = _allMembers
                .Where(member => member.FullName.Contains(searchLetters))
                .ToList();

            _lbMembers.DataSource = filteredMembers;
        }
        
        //private void ResetWindowTitle()
        //{
        //    OverallWindow.Text = "ULM Club Manager Liège";
        //}
    }
}
