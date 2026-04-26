using GMMWorkshopApp.Models;    

namespace GMMWorkshopApp.Interfaces
{
    public interface IPartService
    {
        Task<IEnumerable<Part>> GetAllPartsAsync();
    }
}
