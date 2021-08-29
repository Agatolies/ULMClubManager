using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULMClubManager.BL;
using ULMClubManager.BL.Services;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Abstractions;
using ULMClubManager.DTO.Enums;
using ULMClubManager.DTO.Exceptions;
using ULMClubManager.DTO.Helpers;
using ULMClubManger.Forms.SubForms;

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
            InitializeData();
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

                        _btnOpenLicenceManagementForm.BackColor = WithdrawalService.HasWithdrawalByDate(_member.ID.Value, DateTime.Now)
                            ? Color.FromArgb(204, 41, 54)
                            : Color.FromArgb(0, 117, 162);
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

        private void InitializeData()
        {
            _btnPaiementSubscriptionDate.Visible = false;

            _cboxMBRSex.DisplayMember = "Description";
            _cboxMBRSex.ValueMember = "Key";
            _cboxMBRLocality.DisplayMember = "Name";
            _cboxMBRLocality.ValueMember = "ID";
            _cboxMBRSex.DataSource = Gender.GetGenders();

            _panelMBR_Update_btn.Visible = false;
            _panelMBR_Create_btn.Visible = false;

            

            _labelError.Visible = false;

            _localities = LocalityService.ReadAll();
        }

        public void RefreshData(int memberID)
        {
            Member = MemberService.ReadOne(memberID);

            _labelSubscription.Text = MemberService.GetSubscriptionStatus(memberID);
        }

        public void ClearData()
        {
            _bsMember.Clear();
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
            _tboxMBRPhoneNumber.ReadOnly = true;
            _tboxMBRCellphoneNumber.ReadOnly = true;
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
            _tboxMBRPhoneNumber.ReadOnly = false;
            _tboxMBRCellphoneNumber.ReadOnly = false;
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

        private void ShowErrorMessage(Exception ex)
        {
            string decoded = Rules.MessageDecoder(ContextError.MBR, ex.Message);

            _labelError.Text = decoded;
            _labelError.Visible = true;
        }

        private void ShowErrorMessage(BusinessException ex)
        {
            string decoded = Rules.MessageDecoder(ex);

            _labelError.Text = decoded;
            _labelError.Visible = true;
        }

        private void HideErrorMessage()
        {
            _labelError.Text = "";
            _labelError.Visible = false;
        }

        private void _tboxMBRZipCode_TextChanged(object sender, EventArgs e)
        {
            string zipCode = ((TextBox)sender).Text;

            if (zipCode.Length == 4)
            {
                List<Locality> localitiesForZipCode = _localities
                    .Where(l => l.ZipCode.StartsWith(zipCode))
                    .ToList();

                _cboxMBRLocality.DataSource = localitiesForZipCode;
            }
            else
            {
                _cboxMBRLocality.DataSource = new List<Locality>();
                _cboxMBRLocality.SelectedIndex = -1;
                _cboxMBRLocality.Text = "";
            }
        }

        private void _cboxMBRLocality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Locality locality = (Locality)((ComboBox)sender).SelectedItem;

            if (locality != null)
            {
                _tboxMBRZipCode.Text = locality.ZipCode;

                // Fix pour solutionner le bug d'affection par défaut de la localité
                Member.LocalityID = locality.ID.Value;
            }
        }

        private void _btnMBRCreate_Click(object sender, EventArgs e)
        {
            _panelMBR_CRUD_btn.Visible = false;
            _panelMBR_Create_btn.Visible = true;

            _memberBackup = _member.CreateDeepCopy();

            _dtpLICObtentionDte.Value = DateTime.Now;
            _dtpLICExpirationDte.Value = DateTime.Now;

            

            _gboxSubscription.Visible = false;

            UnlockControls(false);
            ClearControls();
        }

        /// <summary>
        /// Finit le processus d'ajout d'un MBR si tout ce passe bien
        /// </summary>
        private void _btnMRBCreateConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                MemberService.CreateOne(Member);

                _memberBackup = null;

                HideErrorMessage();
                LockControls();

                _panelMBR_CRUD_btn.Visible = true;
                _panelMBR_Create_btn.Visible = false;

                _gboxSubscription.Visible = true;

                MessageBox.Show(
                    $"Le membre {_member.FullName} a bien été créé.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (BusinessException ex)
            {
                ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Finit le processus d'ajout d'un MBR si tout ce passe mal
        /// </summary>
        private void _btnMRBCreateCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Voulez-vous annuler la création du membre ?",
                "Attention",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Member = _memberBackup;
                _memberBackup = null;

                LockControls();
                HideErrorMessage();

                _panelMBR_CRUD_btn.Visible = true;
                _panelMBR_Create_btn.Visible = false;

                _gboxSubscription.Visible = true;
            }
        }

        private void _btnMBRUpdate_Click(object sender, EventArgs e)
        {
            _panelMBR_CRUD_btn.Visible = false;
            _panelMBR_Update_btn.Visible = true;

            UnlockControls(false);

            _memberBackup = _member.CreateDeepCopy();

            bool ok = MemberService.IsInOrderOfPaiement(_member.ID.Value);
            
            if (!ok)
                _btnPaiementSubscriptionDate.Visible = true;
        }

        private void _btnMRBUpdateConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dtpPaymentDateSubscription.Visible)
                    _member.SubscriptionPaiementDate = _dtpPaymentDateSubscription.Value;
                else
                    _member.SubscriptionPaiementDate = null;

                if (_member.IsSupporter)
                {
                    _member.LicenceExpirationDate = null;
                    _member.LicenceObtentionDate = null;
                }

                MemberService.UpdateOne(_member);
                RefreshData(_member.ID.Value);

                _memberBackup = null;

                HideErrorMessage();
                LockControls();

                _dtpPaymentDateSubscription.Visible = false;

                _btnPaiementSubscriptionDate.Visible = false;

                _panelMBR_CRUD_btn.Visible = true;
                _panelMBR_Update_btn.Visible = false;

                MessageBox.Show(
                    $"Le membre {_member.FullName} a bien été mis à jour.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (BusinessException ex)
            {
                ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
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
                LockControls();
                HideErrorMessage();

                _dtpPaymentDateSubscription.Visible = false;

                _btnPaiementSubscriptionDate.Visible = false;

                _panelMBR_CRUD_btn.Visible = true;
                _panelMBR_Update_btn.Visible = false;
            }
        }

        /// <summary>
        /// Commence le processus d'ajout d'un MBR
        /// </summary>

        private void _btnMBRDelete_Click(object sender, EventArgs e)
        {
            LockControls();

            DialogResult dialogResult = MessageBox.Show(
                $"Voulez-vous supprimer le membre { _member.FullName }?",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            try
            {
                if (dialogResult == DialogResult.OK)
                    MemberService.DeleteOne(_member.ID.Value);

                ClearControls();
                HideErrorMessage();
            }
            catch (BusinessException ex)
            {
                ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void _btnPaiementSubscriptionDate_Click(object sender, EventArgs e)
        {
            _dtpPaymentDateSubscription.Visible = true;
        }

        private void _btnOpenLicenceManagementForm_Click(object sender, EventArgs e)
        {
            LicenceManagementForm form = new LicenceManagementForm(_member);
            form.Text = $"Gestion des retraits de licence de {_member.FullName}";
            form.ShowDialog(this);
        }
    }
}
