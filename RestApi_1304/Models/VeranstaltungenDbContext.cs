using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
namespace RestApi_1304.Models
{
    public class VeranstaltungenDbContext : DbContext
    {
        public VeranstaltungenDbContext(DbContextOptions<VeranstaltungenDbContext> options) : base(options)
        {
            try
            {
                var databaseCreator = Database.GetService<IRelationalDatabaseCreator>() as RelationalDatabaseCreator;

                if (databaseCreator != null)
                {
                    if (!databaseCreator.CanConnect()) databaseCreator.Create();
                    if (!databaseCreator.HasTables()) databaseCreator.CreateTables();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public DbSet<Veranstaltungen> Veranstaltungen { get; set; }

        
    }
 }

