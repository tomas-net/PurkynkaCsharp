using Microsoft.EntityFrameworkCore.Design;

namespace Purkynka.DAL
{
    public partial class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            return new DatabaseContext();
        }
    }
}