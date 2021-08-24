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
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();

#if DEBUG
            // connexion automatique en DEBUG
            //_tboxUserName.Text = "agateau136";
            //_tboxPassword.Text = "04198504";
            //_btnLogin_Click(null, null);
#endif
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            string userName = _tboxUserName.Text.Trim();
            string password = _tboxPassword.Text.Trim();

            try
            {
                UserService.Login(userName, password);
                this.Visible = false;
            }
            catch (LoginException ex)
            {
                MessageBox.Show(
                    Rules.MessageDecoder(ex),
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (LoginAdminException ex)
            {
                MessageBox.Show(
                    Rules.MessageDecoder(ex),
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
