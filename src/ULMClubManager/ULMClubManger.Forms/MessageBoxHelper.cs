using System.Windows.Forms;

namespace ULMClubManger.Forms
{
    public static class MessageBoxHelper
    {
        public static DialogResult ShowMandatoryDataError()
        {
            return MessageBox.Show(
                "Toutes les données obligatoires doivent être complétées.",
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

        public static DialogResult ShowBookingUpdateSuccess(string memberFullName)
        {
            return MessageBox.Show(
                $"La réservation pour {memberFullName} a bien été mise à jour.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static DialogResult ShowBookingCancel()
        {
            return MessageBox.Show(
                "Voulez-vous vraiment annuler cette réservation ?",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
        }
    }
}
