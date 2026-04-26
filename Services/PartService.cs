using GMMWorkshopApp.Interfaces;
using GMMWorkshopApp.Models;
using Microsoft.EntityFrameworkCore;
using GMMWorkshopApp.Data;


namespace GMMWorkshopApp.Services
{
    public class PartService : IPartService
    {
        private readonly IDbContextFactory<ApplicationDbContext> dbFactory;

        public PartService(IDbContextFactory<ApplicationDbContext> dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public async Task<IEnumerable<Part>> GetAllPartsAsync()
        {
            using var dbContext = await dbFactory.CreateDbContextAsync();
            
            return await dbContext.Parts
                .Include(p => p.Repair)
                .ThenInclude(r => r.Vehicle)              
                .ToListAsync();
        }
    }
}
