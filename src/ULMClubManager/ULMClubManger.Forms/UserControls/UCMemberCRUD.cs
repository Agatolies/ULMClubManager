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
using ULMClubManager.DTO.Helpers;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCMemberCRUD : UserControl
    {
        private List<Locality> _localities;
        private Member _member;
        private Member _memberBackup;

        public UCMemberCRUD()
        {
            InitializeComponent();

            _cboxMBRSex.DisplayMember = "Description";
            _cboxMBRSex.ValueMember = "Key";
            _cboxMBRLocality.DisplayMember = "Name";
            _cboxMBRLocality.ValueMember = "ID";

            _panelMBR_Update_btn.Visible = false;

            _cboxMBRSex.DataSource = Gender.GetGenders();
            _localities = LocalityService.ReadAll();
        }

        public Member Member
        {
            get { return _member; }
            private set 
            {
                _member = value;

                if (_member != null)
                {
                    _bsMember.DataSource = _member;

                    if (_member.ID.HasValue)
                    {
                        Locality locality = _localities
                            .FirstOrDefault(l => l.ID == _member.LocalityID);

                        _tboxMBRZipCode.Text = locality.ZipCode;
                        _tboxMBRID.Text = _member.ID.Value.ToString();
                        _gboxPIL.Visible = _member.IsPilot;
                    }
                    else
                    {
                        _tboxMBRZipCode.Text = "";
                        _tboxMBRID.Text = "";
                        _gboxPIL.Visible = true;
                    }
                }
            }
        }

        public void RefreshData(int memberID)
        {
            Member = MemberService.ReadOne(memberID);
        }

        public void ClearData()
        {
            _bsMember.Clear();
        }

        private void _tboxMBRZipCode_TextChanged(object sender, EventArgs e)
        {
            string zipCode = ((TextBox)sender).Text;

            if (zipCode == "" || zipCode.Length != 4)
            {
                _cboxMBRLocality.DataSource = new List<Locality>();
                _cboxMBRLocality.SelectedIndex = -1;
                _cboxMBRLocality.Text = "";
            }
            else
            {
                List<Locality> localitiesForZipCode = _localities
                    .Where(l => l.ZipCode.StartsWith(zipCode))
                    .ToList();

                _cboxMBRLocality.DataSource = localitiesForZipCode;
            }
        }

        private void _cboxMBRLocality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Locality locality = (Locality)((ComboBox)sender).SelectedItem;

            _tboxMBRZipCode.Text = locality.ZipCode;
        }

        private void ClearControls()
        {
            Member = new Member();
        }

        private void LockControls()
        {
            _tboxMBRID.ReadOnly = true;

            _tboxMBRLastName.ReadOnly = true;
            _tboxMBRFirstName.ReadOnly = true;
            _cboxMBRSex.Enabled = false;
            _dtpMBRDteOfBirth.Enabled = false;
            _tboxMBREmailAddress.ReadOnly = true;
            _tboxMBRPostalAddress.ReadOnly = true;
            _tboxMBRBoxNumber.ReadOnly = true;
            _tboxMBRResidenceName.ReadOnly = true;
            _tboxMBRBuildingNumber.ReadOnly = true;
            _tboxMBRZipCode.ReadOnly = true;
            _cboxMBRLocality.Enabled = false;
            _dtpMRBRegistrationDate.Enabled = false;

            _tboxLICNum.ReadOnly = true;
            _dtpLICObtentionDte.Enabled = false;
            _dtpLICExpirationDte.Enabled = false;
            _tboxLICCountry.ReadOnly = true;

            _cboxMBRQual1.Enabled = false;
            _cboxMBRQual2.Enabled = false;
            _cboxMBRQual3.Enabled = false;
            _cboxMBRQual4.Enabled = false;
            _cboxMBRQual5.Enabled = false;
            _cboxMBRQual6.Enabled = false;
        }

        private void UnlockControls(bool unlockID)
        {
            if (unlockID)
                _tboxMBRID.ReadOnly = false;

            _tboxMBRLastName.ReadOnly = false;
            _tboxMBRFirstName.ReadOnly = false;
            _cboxMBRSex.Enabled = true;
            _dtpMBRDteOfBirth.Enabled = true;
            _tboxMBREmailAddress.ReadOnly = false;
            _tboxMBRPostalAddress.ReadOnly = false; 
            _tboxMBRBoxNumber.ReadOnly = false;
            _tboxMBRResidenceName.ReadOnly = false;
            _tboxMBRBuildingNumber.ReadOnly = false;
            _tboxMBRZipCode.ReadOnly = false;
            _cboxMBRLocality.Enabled = true;
            _dtpMRBRegistrationDate.Enabled = true;

            _tboxLICNum.ReadOnly = false;
            _dtpLICObtentionDte.Enabled = true;
            _dtpLICExpirationDte.Enabled = true;
            _tboxLICCountry.ReadOnly = false;

            _cboxMBRQual1.Enabled = true;
            _cboxMBRQual2.Enabled = true;
            _cboxMBRQual3.Enabled = true;
            _cboxMBRQual4.Enabled = true;
            _cboxMBRQual5.Enabled = true;
            _cboxMBRQual6.Enabled = true;
        }

        private void _btnMBRCreate_Click(object sender, EventArgs e)
        {
            UnlockControls(true);

            ClearControls();

            //LockControls();
        }


        private void _btnMBRDelete_Click(object sender, EventArgs e)
        {

        }

        private void _btnMBRUpdate_Click(object sender, EventArgs e)
        {
            _panelMBR_CRUD_btn.Visible = false;
            _panelMBR_Update_btn.Visible = true;

            UnlockControls(false);

            _memberBackup = _member.CreateDeepCopy();
        }

        private void _btnMRBUpdateConfirm_Click(object sender, EventArgs e)
        {
            MemberService.UpdateOne(_member);

            _memberBackup = null;

            MessageBox.Show(
                $"Le membre {_member.FullName} a bien été mis à jour.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LockControls();

            _panelMBR_CRUD_btn.Visible = true;
            _panelMBR_Update_btn.Visible = false;
        }

        private void _btnMBRUpdateCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Voulez-vous annuler la modification en cours ?",
                "Attention",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Member = _memberBackup;
                _memberBackup = null;
                LockControls();

                _panelMBR_CRUD_btn.Visible = true;
                _panelMBR_Update_btn.Visible = false;
            }
        }
    }
}
