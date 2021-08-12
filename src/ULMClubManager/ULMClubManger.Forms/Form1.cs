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
        private readonly PilotService _pilotService;

        public Form1()
        {
            InitializeComponent();

            _pilotService = new PilotService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Pilot> pilots = _pilotService.ReadAll();

            //var query = pilots.Select(pilot => new { Fullname = pilot.FullName }).ToList();

            _dgvMembers.DataSource = pilots;
            _dgvMembers.Columns["ID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _splitContainerLayout.SplitterDistance = 900;
        }
    }
}
