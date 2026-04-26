using GMMWorkshopApp.Models;

namespace GMMWorkshopApp.Interfaces
{
    public interface IRepairService
    {
        Task<IEnumerable<Repair>> GetAllRepairsAsync();
    }
}
