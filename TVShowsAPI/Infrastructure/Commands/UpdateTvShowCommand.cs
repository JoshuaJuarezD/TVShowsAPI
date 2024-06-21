using MediatR;
using TVShowsAPI.Aplication.DTOs;

namespace TVShowsAPI.Infrastructure.Commands
{
    public record UpdateTvShowCommand :IRequest<TvShowDto>
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public bool Favorite { get; set; }
    }
}
