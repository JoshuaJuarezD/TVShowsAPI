using Microsoft.EntityFrameworkCore;
using TVShowsAPI.Domain;

namespace TVShowsAPI.Infrastructure.Data
{
    //Inicio del contexto para la conexion con base de datos en memoria
    public class TvShowContext(DbContextOptions<TvShowContext> options) : DbContext(options)
    {
        public DbSet<TvShow> TvShows { get; set; }
        /*Insercion de elementos*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TvShow>().HasData(
                new TvShow { Id = 1, Name = "Breaking Bad", Favorite = true },
                new TvShow { Id = 2, Name = "Game of Thrones", Favorite = false },
                new TvShow { Id = 3, Name = "The Office", Favorite = true }
            );
        }
    }
}
