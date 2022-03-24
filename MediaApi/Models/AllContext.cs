using Microsoft.EntityFrameworkCore;

namespace MediaApi.Models
{
    public class AllContext : DbContext
    {

        public AllContext(DbContextOptions<AllContext> options) : base(options) { 
        
        }


        public DbSet<Series> Series { get; set; }
        public DbSet<CreatingProperty> CreatingProperties { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Theme> Themes { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        public DbSet<Show> Shows { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        
        public DbSet<ReccomendingResource>  ReccomendingResources { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Person> Persons { get; set; }

        public DbSet<MediaPerson> MediaPersons { get; set; }
        
    }
}
