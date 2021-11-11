using ULMClubManager.DAL;
using ULMClubManager.DTO;

namespace ULMClubManager.BL.Services;

public static class AircraftService
{
    public static List<Aircraft> ReadAll()
    {
        using DalSession dalSession = new DalSession();
        return dalSession.Aircrafts.ReadAll().ToList();
    }

    public static Aircraft ReadOne(int aircraftID)
    {
        using DalSession dalSession = new DalSession();
        return dalSession.Aircrafts.ReadOne(aircraftID);
    }

    public static List<AircraftCategory> ReadAllCategories()
    {
        using DalSession dalSession = new DalSession();
        return dalSession.AircraftCategories.ReadAll().ToList();
    }

    public static List<Runway> ReadAllRunways()
    {
        using DalSession dalSession = new DalSession();
        return dalSession.Runways.ReadAll().ToList();
    }

    public static List<AircraftCategory> ReadAllAvailableCategories()
    {
        return AircraftService
            .ReadAllCategories()
            .Where(category => category.ID.Value < 4)
            .ToList();
    }
}