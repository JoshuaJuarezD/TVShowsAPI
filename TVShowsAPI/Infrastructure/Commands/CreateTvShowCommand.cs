using MediatR;
using TVShowsAPI.Aplication.DTOs;

namespace TVShowsAPI.Infrastructure.Commands
{
    //Implementacion de comando para crear, Utilizando mediator 
    public record CreateTvShowCommand : IRequest<TvShowDto>
    {
        public required string Name { get; set; }
        public bool Favorite { get; set; }
    }
}
