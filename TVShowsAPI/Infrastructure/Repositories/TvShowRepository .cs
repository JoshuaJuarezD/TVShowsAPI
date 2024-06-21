using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TVShowsAPI.Domain;
using TVShowsAPI.Infrastructure.Data;

namespace TVShowsAPI.Infrastructure.Repositories
{
    /*Repository Logica de negocios implementacion de Crud*/
    public class TvShowRepository : ITvShowRepository
    {
        private readonly TvShowContext _context;

        public TvShowRepository(TvShowContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TvShow>> GetAllAsync()
        {
            var aux = await _context.TvShows.ToListAsync();
            return aux;
        }

        public async Task<TvShow> GetByIdAsync(int id)
        {
            return await _context.TvShows.FindAsync(id);
        }

        public async Task<TvShow> AddAsync(TvShow tvShow)
        {
            _context.TvShows.Add(tvShow);
            await _context.SaveChangesAsync();
            return tvShow;
        }

        public async Task<TvShow> UpdateAsync(TvShow tvShow)
        {
            _context.Entry(tvShow).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return tvShow;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var tvShow = await _context.TvShows.FindAsync(id);
            if (tvShow != null)
            {
                _context.TvShows.Remove(tvShow);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
