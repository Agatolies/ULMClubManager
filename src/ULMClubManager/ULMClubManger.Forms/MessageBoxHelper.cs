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
        public static DialogResult ShowMandatoryDataError()
        {
            return MessageBox.Show(
                $"Toutes les données obligatoires doivent être complétées.",
                "Erreur",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static DialogResult ShowDeleteQualificationWarning()
        {
            return MessageBox.Show(
                "La suppression d'une qualification entraine automatiquement " +
                    "la suppression des réservations pour les ULM qui y sont liés.",
                "Attention",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
        }
    }
}
