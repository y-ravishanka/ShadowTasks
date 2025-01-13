using Microsoft.EntityFrameworkCore;

namespace ShadowTasks_Server.Configs
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
