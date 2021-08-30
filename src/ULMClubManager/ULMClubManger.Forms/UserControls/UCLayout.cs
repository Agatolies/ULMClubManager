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
    }
}
