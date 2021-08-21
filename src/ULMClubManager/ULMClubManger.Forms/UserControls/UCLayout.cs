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
using ULMClubManager.DTO.Enums;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCLayout : UserControl
    {
        public UCLayout()
        {
            InitializeComponent();
        }

        public Panel PanelChildForm => _panelChildForm;

        //private void Reset(object sender, EventArgs e)
        //{
        //    _dgvPIL.DataSource = null;
        //    _bt_Read.Enabled = false;
        //}

        //private void btRead_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        _dgvPIL.DataSource = PilotService.ReadAllByNameBegin(tb_DEB_PIL_NOM.Text);
        //        _bt_Read.Enabled = false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void _btnInsertPilot_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Pilot newPil = new Pilot(
        //            "713673961128620",
        //            new DateTime(2021, 06, 03),
        //            new DateTime(2024, 06, 01),
        //            "BE",
        //            _tboxLastName.Text,
        //            _tboxFirstName.Text,
        //            _tboxSex.Text,
        //            _dtpBirthday.Value,
        //            _dtpRegistrationDate.Value,
        //            _tboxStreetName.Text,
        //            _tboxResidenceNumber.Text,
        //            _tboxBuildingNumber.Text,
        //            _tboxStreetNumber.Text,
        //            _tboxPhoneNumber.Text,
        //            _tboxMobilePhoneNumber.Text,
        //            _tboxEmailAddress.Text,
        //            _checkAdmin.Checked,
        //            _tboxUserPSD.Text,
        //            _tboxUserPWD.Text,
        //            895);

        //        PilotService.CreateOne(newPil);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("blabla");
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        PilotService.CreateBooking();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(
        //            Rules.MessageDecoder(ContextError.RES, ex.Message),
        //            "Erreur",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }
        //}
    }
}
