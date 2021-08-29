﻿using System;
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
        public FormMembersInfo()
        {
            InitializeComponent();
        }

        private void _ucMemberPicker_SelectMember(int memberID)
        {
            _ucMemberCRUD.RefreshData(memberID);
        }

        private void _ucMemberCRUD_MemberCreating()
        {
            _ucMemberPicker.Enabled = false;
        }

        private void _ucMemberCRUD_MemberUpdating()
        {
            _ucMemberPicker.Enabled = false;
        }

        private void _ucMemberCRUD_MemberCanceling()
        {
            _ucMemberPicker.Enabled = false;
        }

        private void _ucMemberCRUD_MemberCreated()
        {
            int index = _ucMemberPicker._lbMembers.SelectedIndex;
            _ucMemberPicker.InitializeData();
            _ucMemberPicker._lbMembers.SelectedIndex = index;

            _ucMemberPicker.Enabled = true;
        }

        private void _ucMemberCRUD_MemberUpdated()
        {
            int index = _ucMemberPicker._lbMembers.SelectedIndex;
            _ucMemberPicker.InitializeData();
            _ucMemberPicker._lbMembers.SelectedIndex = index;

            _ucMemberPicker.Enabled = true;
        }

        private void _ucMemberCRUD_MemberCanceled()
        {
            _ucMemberPicker.InitializeData();
            _ucMemberPicker.Enabled = true;
        }
    }
}
