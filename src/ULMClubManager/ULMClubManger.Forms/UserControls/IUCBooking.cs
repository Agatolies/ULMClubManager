using ULMClubManager.DTO;
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManger.Forms.UserControls
{
    public interface IUCBooking
    {
        void ShowErrorMessage(BusinessException ex);
        void ShowErrorMessage(Exception ex);
        void HideErrorMessage();
        void RefreshTimeSlotsEnd();
        void RefreshDetailsForm();
        void ClearControls();
        void LockControls();
        void UnlockControls();
        Booking GetCreatingBooking();
    }
}
