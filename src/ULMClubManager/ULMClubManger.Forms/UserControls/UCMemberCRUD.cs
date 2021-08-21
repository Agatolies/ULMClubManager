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
    public partial class UCMemberCRUD : UserControl
    {
        public UCMemberCRUD()
        {
            InitializeComponent();

            _cboxSex.DataSource = Gender.GetGenders();
            _cboxSex.DisplayMember = "Description";
            _cboxSex.ValueMember = "Key";
        }

        public void RefreshData(int memberID)
        {
            _bsMember.DataSource = UserService.ReadOne(memberID);
        }
        
        public void ClearData()
        {
            _bsMember.Clear();
        }
    }
}
