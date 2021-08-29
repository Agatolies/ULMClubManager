using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULMClubManger.Forms
{
    public static class MessageBoxHelper
    {
        public static void ShowMandatoryDataError()
        {
            MessageBox.Show(
                $"Toutes les données obligatoires doivent être complétées.",
                "Erreur",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static void ShowDeleteQualificationWarning()
        {
            MessageBox.Show(
                "La suppression d'une qualification entraine automatiquement " +
                    "la suppression des réservations pour les ULM qui y sont liés.",
                "Attention",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
