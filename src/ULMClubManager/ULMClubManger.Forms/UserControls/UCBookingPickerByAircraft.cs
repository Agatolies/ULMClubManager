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
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCBookingPickerByAircraft : UserControl
    {
        public event delSelect SelectAircraftCategoryID;

        private List<Aircraft> _allAircrafts;
        private List<AircraftCategory> _allAircraftCategories;

        public UCBookingPickerByAircraft()
        {
            InitializeComponent();

            _cboxSearchAircraftCategory.DisplayMember = "Name";
            _cboxSearchAircraftCategory.ValueMember = "ID";
        }

        public void InitializeData()
        {
            try
            {
                _allAircrafts = AircraftService.ReadAll();
                _allAircraftCategories = AircraftService.ReadAllCategories();

                _lbAircraftID.DataSource = _allAircrafts;
                _cboxSearchAircraftCategory.DataSource = _allAircraftCategories;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterAircrafts()
        {
            AircraftCategory selectedAircraftCategory = (AircraftCategory)_cboxSearchAircraftCategory.SelectedItem;

            List<Aircraft> filteredAircrafts = _allAircrafts
                .Where(aircraft => aircraft.CategoryID == selectedAircraftCategory.ID)
                .ToList();

            _lbAircraftID.DataSource = filteredAircrafts;
        }

        private void UCBookingPickerByAircraft_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void _lbAircraftID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lbAircraftID.DataSource != null && this.SelectAircraftCategoryID != null)
                this.SelectAircraftCategoryID(((Aircraft)_lbAircraftID.SelectedItem).ID.Value);
        }

        private void _cboxSearchAircraftType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAircrafts();
        }
    }
}
