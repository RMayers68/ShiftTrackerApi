using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ShiftTrackerApi.Models
{
    public class ShiftContext : DbContext
    {
        public ShiftContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Shift> Shifts { get; set; } = null!;

    }

    
}