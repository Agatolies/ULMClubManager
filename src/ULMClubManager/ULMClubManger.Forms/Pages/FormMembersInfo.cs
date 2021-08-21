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
        private int _memberID;

        public FormMembersInfo()
        {
            InitializeComponent();

            // Nous mettons notre titre
            //OverallWindow.Text = OverallWindow.Text += " - Données signalétiques d'un membre";
        }

        private void _ucMemberPicker_SelectMember(int memberID)
        {
            _memberID = memberID;

            _ucMemberCRUD.RefreshData(memberID);
        }


        //public UCLayout ParentLayout => this.Parent.Parent as UCLayout;
        //public Form1 OverallWindow => ParentLayout.Parent as Form1;


        //private void ResetWindowTitle()
        //{
        //    OverallWindow.Text = "ULM Club Manager Liège";
        //}
    }
}
