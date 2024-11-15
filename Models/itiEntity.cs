using Microsoft.EntityFrameworkCore;

namespace coursewepapi.Models
{
    public class itiEntity: DbContext
    {
        public itiEntity():base()
        {

        }
        public itiEntity(DbContextOptions options) : base(options)
        {

        }
        public DbSet<book> books { get; set; }
        public DbSet<customer> customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-PFKAJN7/SQLEXPRESS; Initial Catalog = thirdproject; Integrated Security = True");


                base.OnConfiguring(optionsBuilder);
        }
    }
}
