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

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCBookingPickerByRunway : UserControl
    {
        public event delSelect SelectRunwayID;

        private List<Runway> _allRunways;

        public UCBookingPickerByRunway()
        {
            InitializeComponent();
        }

        private void InitializeData()
        {
            try
            {
                _allRunways = AircraftService.ReadAllRunways();

                _lbRunwayID.DataSource = _allRunways;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCBookingPickerByPist_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void _lbRunwayID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lbRunwayID.DataSource != null && this.SelectRunwayID != null)
                this.SelectRunwayID(((Runway)_lbRunwayID.SelectedItem).ID.Value);
        }
    }
}
