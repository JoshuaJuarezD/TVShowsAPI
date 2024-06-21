using System.Collections.Generic;
using TVShowsAPI.Domain;

namespace TVShowsAPI.Infrastructure.Repositories
{
    /*Metodos para la implementacion de repository*/
    public interface ITvShowRepository
    {
        Task<IEnumerable<TvShow>> GetAllAsync(); // traer todos los registros
        Task<TvShow> GetByIdAsync(int id); // Traer uno por id
        Task<TvShow> AddAsync(TvShow tvShow); // Insertar un registro
        Task<TvShow> UpdateAsync(TvShow tvShow); //actualizar un registro
        Task<bool> DeleteAsync(int id); //eliminar un registro
    }
}
