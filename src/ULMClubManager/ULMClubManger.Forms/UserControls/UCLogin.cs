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

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            string userName = _tboxUserName.Text.Trim();
            string password = _tboxPassword.Text.Trim();

            bool isLoggedIn = UserService.Login(userName, password);

            if (isLoggedIn)
            {
                // Il faut récupérer le PIL ou le SYM sauf qu'on sait pas quelle requête appeler

                // Il faut stocker le MBR dans une propriété statique de notre UserService
            }
            else
            {
                // Afficher un message d'erreur
            }
        }
    }
}
