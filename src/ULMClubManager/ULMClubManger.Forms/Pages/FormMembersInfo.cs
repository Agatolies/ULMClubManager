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
    }
}
