using System.Windows.Forms;

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
