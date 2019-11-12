using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = ###; Initial Catalog = UgurDegirmenci; Persist Security Info = False; User ID = uurde; Password =###; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = True; Connection Timeout = 30;");
        }

        public DbSet<BlogArticle> BlogArticle { get; set; }
        public DbSet<BlogCategory> BlogCategory { get; set; }
        public DbSet<BlogUser> BlogUser { get; set; }
    }
}
