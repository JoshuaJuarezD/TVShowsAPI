using MediatR;
using TVShowsAPI.Aplication.DTOs;

namespace TVShowsAPI.Infrastructure.Commands
{
    //Implementacion de comando para eliminar un registro, utlizando midiator para el handler
    public class DeleteTvShowCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
