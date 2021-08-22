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
        private List<Locality> _localities;
        private IMember _member;

        public UCMemberCRUD()
        {
            InitializeComponent();

            _cboxMBRSex.DisplayMember = "Description";
            _cboxMBRSex.ValueMember = "Key";
            _cboxMBRLocality.DisplayMember = "Name";
            _cboxMBRLocality.ValueMember = "ID";

            _cboxMBRSex.DataSource = Gender.GetGenders();
            _localities = LocalityService.ReadAll();
        }

        public IMember Member
        {
            get { return _member; }
            private set 
            {
                _member = value;

                if (_member != null)
                {
                    _tboxMBRID.Text = _member.ID.Value.ToString();

                    _bsMember.DataSource = _member;

                    Locality locality = _localities.FirstOrDefault(l => l.ID == _member.LocalityID);
                    _tboxMBRZipCode.Text = locality.ZipCode;

                    _gboxPIL.Visible = IsPilot;

                    if (IsPilot)
                    {
                        Pilot pilot = (Pilot)_member;
                        _tboxLICNum.Text = pilot.LicenceNumber;
                        _dtpLICObtentionDte.Value = pilot.ObtentionDate;
                        _dtpLICExpirationDte.Value = pilot.ExpirationDate;
                        _tboxLICCountry.Text = pilot.Country;
                    }
                    else
                    {
                        _tboxLICNum.Text = null;
                        _dtpLICObtentionDte.Value = DateTime.Now;
                        _dtpLICExpirationDte.Value = DateTime.Now;
                        _tboxLICCountry.Text = null;
                    }

                    _cboxMBRQual1.Checked = _member.Qualification.Type1;
                    _cboxMBRQual2.Checked = _member.Qualification.Type2;
                    _cboxMBRQual3.Checked = _member.Qualification.Type3;
                    _cboxMBRQual4.Checked = _member.Qualification.Type4;
                    _cboxMBRQual5.Checked = _member.Qualification.Type5;
                    _cboxMBRQual6.Checked = _member.Qualification.Type6;
                }
            }
        }

        public bool IsPilot => Member is Pilot;

        public void RefreshData(int memberID)
        {
            Member = UserService.ReadOne(memberID);
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
    }
}
