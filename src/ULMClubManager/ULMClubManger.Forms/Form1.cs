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

namespace ULMClubManger.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCharger_Click(object sender, EventArgs e)
        {
            Pilot pilot = PilotService.ReadOne(Convert.ToInt32(tbDEB_NOM.Text));
            _dgvPIL.DataSource = new List<Pilot>() { pilot };
        }
    }
}
