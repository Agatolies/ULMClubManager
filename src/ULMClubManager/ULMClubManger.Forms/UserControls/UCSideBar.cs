using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULMClubManger.Forms.Pages;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCSideBar : UserControl
    {
        private Form _activeForm = null;

        public UCSideBar()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        public UCLayout ParentLayout => this.Parent as UCLayout;
        public Form1 OverallWindow => ParentLayout.Parent as Form1;

        private void CustomizeDesign()
        {
            _panelMembersSubmenu.Visible = false;
            _panelBookingsSubmenu.Visible = false;
            _panelSubscriptionsSubmenu.Visible = false;
            _panelClubManagementSubmenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (_panelMembersSubmenu.Visible)
                _panelMembersSubmenu.Visible = false;

            if (_panelBookingsSubmenu.Visible)
                _panelBookingsSubmenu.Visible = false;

            if (_panelSubscriptionsSubmenu.Visible)
                _panelSubscriptionsSubmenu.Visible = false;

            if (_panelClubManagementSubmenu.Visible)
                _panelClubManagementSubmenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void _btnMembers_Click(object sender, EventArgs e)
        {
            ShowSubMenu(_panelMembersSubmenu);
        }

        private void _btnBookings_Click(object sender, EventArgs e)
        {
            ShowSubMenu(_panelBookingsSubmenu);
        }

        private void _btnMembersInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMembersInfo());
        }

        private void _btnSubscriptions_Click(object sender, EventArgs e)
        {
            ShowSubMenu(_panelSubscriptionsSubmenu);
        }

        private void _btnClubManagement_Click(object sender, EventArgs e)
        {
            ShowSubMenu(_panelClubManagementSubmenu);
        }

        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
                _activeForm.Close();

            _activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            ParentLayout.PanelChildForm.Controls.Add(childForm);
            ParentLayout.PanelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

    }
}
