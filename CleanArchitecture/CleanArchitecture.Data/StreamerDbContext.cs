using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Data
{
    public class StreamerDbContext : DbContext
    {
        //Cadena de conexion a sql server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\sqlexpress; 
                                    Initial Catalog = Streamer; 
                                    Integrated Security=True;
                                    TrustServerCertificate=True");
        }

        //Convierte clases en entidades
        public DbSet<Streamer>? Streamers { get; set; }

        public DbSet<Video>? Videos { get; set; }
    }
}
