using System.Data;
using ULMClubManager.BL;
using ULMClubManager.BL.Services;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Enums;
using ULMClubManager.DTO.Exceptions;
using ULMClubManager.DTO.Helpers;
using ULMClubManger.Forms.SubForms;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCMemberCRUD : UserControl
    {
        public event delMemberCreating MemberCreating;
        public event delMemberUpdating MemberUpdating;
        public event delMemberCanceling MemberCanceling;

        public event delMemberCreated MemberCreated;
        public event delMemberUpdated MemberUpdated;
        public event delMemberCanceled MemberCanceled;

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
                            .Find(l => l.ID == _member.LocalityID);

                        _tboxMBRZipCode.Text = locality.ZipCode;
                        _tboxMBRID.Text = _member.ID.Value.ToString();
                        _gboxPIL.Visible = _member.IsPilot;

                        _labelLICExpirationDte.ForeColor = _member.IsPilot && !_member.HasValidLicence(DateTime.Now)
                            ? Color.Red
                            : Color.Black;

                        _btnOpenLicenceManagementForm.BackColor =
                            WithdrawalService.HasWithdrawalByDate(_member.ID.Value, DateTime.Now)
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

        private bool DetectUnfilledFields()
        {
            bool isLastNameNotFilled = string.IsNullOrWhiteSpace(_tboxMBRLastName.Text);
            bool isFirstNameNotFilled = string.IsNullOrWhiteSpace(_tboxMBRFirstName.Text);
            bool isSexNotFilled = _cboxMBRSex.SelectedIndex == -1;
            bool isEmailNotFilled = string.IsNullOrWhiteSpace(_tboxMBREmailAddress.Text);
            bool isCellphoneNumberNotFilled = string.IsNullOrWhiteSpace(_tboxMBRCellphoneNumber.Text);
            bool isPostalAddressNotFilled = string.IsNullOrWhiteSpace(_tboxMBRPostalAddress.Text);
            bool isBoxNumberNotFilled = string.IsNullOrWhiteSpace(_tboxMBRBoxNumber.Text);
            bool isZipCodeNotFilled = string.IsNullOrWhiteSpace(_tboxMBRZipCode.Text);
            bool isLocalityNotFilled = string.IsNullOrWhiteSpace(_cboxMBRLocality.Text);

            bool isLicenceNumberNotFilled = string.IsNullOrWhiteSpace(_tboxLICNum.Text);
            bool isLicenceStartDateNotFilled = string.IsNullOrWhiteSpace(_dtpLICObtentionDte.Text);
            bool isLicenceEndDateNotFilled = string.IsNullOrWhiteSpace(_dtpLICExpirationDte.Text);
            bool isLicenceCountryNotFilled = string.IsNullOrWhiteSpace(_tboxLICCountry.Text);

            bool isAtLeastOnePilotFieldFilled =
                !isLicenceNumberNotFilled || !isLicenceStartDateNotFilled
                || !isLicenceEndDateNotFilled || !isLicenceCountryNotFilled;

            bool isAllLicenceFieldsNotFilled =
                isLicenceNumberNotFilled || isLicenceStartDateNotFilled
                || isLicenceEndDateNotFilled || isLicenceCountryNotFilled;

            bool isLicenceDatasIncomplete = isAtLeastOnePilotFieldFilled && isAllLicenceFieldsNotFilled;

            return isLastNameNotFilled || isFirstNameNotFilled
                || isSexNotFilled || isEmailNotFilled || isCellphoneNumberNotFilled
                || isPostalAddressNotFilled || isBoxNumberNotFilled
                || isZipCodeNotFilled || isLocalityNotFilled
                || isLicenceDatasIncomplete;
        }

        private void ShowMandatoryAsterisks()
        {
            _labelMBRLastNameMandatory.Visible = true;
            _labelMBRFirstNameMandatory.Visible = true;
            _labelMBRSexMandatory.Visible = true;
            _labelMBRDteOfBirthMandatory.Visible = true;
            _labelMBREmailMandatory.Visible = true;
            _labelMBRCellphoneMandatory.Visible = true;
            _labelMBRStreetMandatory.Visible = true;
            _labelMBRBoxMandatory.Visible = true;
            _labelMBRLocalityMandatory.Visible = true;
            _labelMBRRegistrationDteMandatory.Visible = true;
            _labelLICNumMandatory.Visible = true;
            _labelLICObtentionDteMandatory.Visible = true;
            _labelLICExpirationDteMandatory.Visible = true;
            _labelLICCountryMandatory.Visible = true;
            _labelQUALMandatory.Visible = true;

            _labelMemberCRUDMandatory.Visible = true;
            _labelMemberCRUDMandatoryIfPilot.Visible = true;
        }

        private void HideMandatoryAsterisks()
        {
            _labelMBRLastNameMandatory.Visible = false;
            _labelMBRFirstNameMandatory.Visible = false;
            _labelMBRSexMandatory.Visible = false;
            _labelMBRDteOfBirthMandatory.Visible = false;
            _labelMBREmailMandatory.Visible = false;
            _labelMBRCellphoneMandatory.Visible = false;
            _labelMBRStreetMandatory.Visible = false;
            _labelMBRBoxMandatory.Visible = false;
            _labelMBRLocalityMandatory.Visible = false;
            _labelMBRRegistrationDteMandatory.Visible = false;
            _labelLICNumMandatory.Visible = false;
            _labelLICObtentionDteMandatory.Visible = false;
            _labelLICExpirationDteMandatory.Visible = false;
            _labelLICCountryMandatory.Visible = false;
            _labelQUALMandatory.Visible = false;

            _labelMemberCRUDMandatory.Visible = false;
            _labelMemberCRUDMandatoryIfPilot.Visible = false;
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
            _btnOpenLicenceManagementForm.Visible = false;

            _panelMBR_CRUD_btn.Visible = false;
            _panelMBR_Create_btn.Visible = true;

            _memberBackup = _member.CreateDeepCopy();

            _dtpLICObtentionDte.Value = DateTime.Now;
            _dtpLICExpirationDte.Value = DateTime.Now;

            _gboxSubscription.Visible = false;

            MemberCreating();

            UnlockControls(false);
            ClearControls();
            ShowMandatoryAsterisks();
        }

        /// <summary>
        /// Finit le processus d'ajout d'un MBR si tout ce passe bien
        /// </summary>
        private void _btnMRBCreateConfirm_Click(object sender, EventArgs e)
        {
            bool hasError = DetectUnfilledFields();
            if (hasError)
            {
                MessageBoxHelper.ShowMandatoryDataError();
            }
            else
            {
                try
                {
                    Member createdMember = MemberService.CreateOne(Member);

                    _memberBackup = null;

                    HideErrorMessage();
                    LockControls();

                    _btnOpenLicenceManagementForm.Visible = true;

                    _panelMBR_CRUD_btn.Visible = true;
                    _panelMBR_Create_btn.Visible = false;

                    _gboxSubscription.Visible = true;

                    MemberCreated();

                    MessageBox.Show(
                        $"Le membre {createdMember.FullName} a bien été créé.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    RefreshData(createdMember.ID.Value);
                    HideMandatoryAsterisks();
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
                HideMandatoryAsterisks();

                _btnOpenLicenceManagementForm.Visible = true;

                _panelMBR_CRUD_btn.Visible = true;
                _panelMBR_Create_btn.Visible = false;

                _gboxSubscription.Visible = true;

                MemberCreated();
            }
        }

        private void _btnMBRUpdate_Click(object sender, EventArgs e)
        {
            _panelMBR_CRUD_btn.Visible = false;
            _panelMBR_Update_btn.Visible = true;

            MemberUpdating();

            UnlockControls(false);
            ShowMandatoryAsterisks();

            _memberBackup = _member.CreateDeepCopy();

            bool ok = MemberService.IsInOrderOfPaiement(_member.ID.Value);

            if (!ok)
                _btnPaiementSubscriptionDate.Visible = true;
        }

        private void _btnMRBUpdateConfirm_Click(object sender, EventArgs e)
        {
            bool hasError = DetectUnfilledFields();
            if (hasError)
            {
                MessageBoxHelper.ShowMandatoryDataError();
            }
            else
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
                    HideMandatoryAsterisks();

                    _dtpPaymentDateSubscription.Visible = false;

                    _btnPaiementSubscriptionDate.Visible = false;

                    _panelMBR_CRUD_btn.Visible = true;
                    _panelMBR_Update_btn.Visible = false;

                    MemberUpdated();

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
                HideMandatoryAsterisks();

                _dtpPaymentDateSubscription.Visible = false;

                _btnPaiementSubscriptionDate.Visible = false;

                _panelMBR_CRUD_btn.Visible = true;
                _panelMBR_Update_btn.Visible = false;

                MemberUpdated();
            }
        }

        /// <summary>
        /// Commence le processus de suppression d'un MBR
        /// </summary>
        private void _btnMBRDelete_Click(object sender, EventArgs e)
        {
            MemberCanceling();

            LockControls();

            DialogResult dialogResult = MessageBox.Show(
                $"Voulez-vous supprimer le membre { _member.FullName }?",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            try
            {
                if (dialogResult == DialogResult.OK)
                {
                    MemberService.DeleteOne(_member.ID.Value);
                    MemberCanceled();
                }

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
            LicenceManagementForm form = new LicenceManagementForm(_member)
            {
                Text = $"Gestion des retraits de licence de {_member.FullName}"
            };

            form.ShowDialog(this);
        }
    }
}
