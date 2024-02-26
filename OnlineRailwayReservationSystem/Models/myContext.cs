using Microsoft.EntityFrameworkCore;

namespace OnlineRailwayReservationSystem.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base (options)
        {

        }
        public DbSet<StationMaster> tbl_StationMaster { get; set; }
    }
}
