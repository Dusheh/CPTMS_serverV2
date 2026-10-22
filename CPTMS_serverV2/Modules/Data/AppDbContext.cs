using Microsoft.EntityFrameworkCore;

namespace CPTMS_serverV2.Modules.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions)
        {

        }
    }
}
