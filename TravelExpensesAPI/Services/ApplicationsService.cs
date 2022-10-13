using Microsoft.EntityFrameworkCore;
using TravelExpensesAPI.Data;
using TravelExpensesAPI.Models;

namespace TravelExpensesAPI.Services
{
    public class ApplicationsService
    {
        private readonly DataContext _context;
        public ApplicationsService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Application>> GetApplications()
        {
            return await _context.Applications
                .Include(x => x.User)
                .ToListAsync();
        }
    }
}
