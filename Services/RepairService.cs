using GMMWorkshopApp.Data;
using GMMWorkshopApp.Interfaces;
using GMMWorkshopApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GMMWorkshopApp.Services
{
    public class RepairService : IRepairService
    {
        private readonly IDbContextFactory<ApplicationDbContext> dbFactory;

        public RepairService(IDbContextFactory<ApplicationDbContext> dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public async Task<IEnumerable<Repair>> GetAllRepairsAsync()
        {
            using var context = await dbFactory.CreateDbContextAsync();

            return await context.Repairs
                .Include(r => r.Vehicle)
                .Include(r => r.Parts)
                .ToListAsync();
        }
    }

}
