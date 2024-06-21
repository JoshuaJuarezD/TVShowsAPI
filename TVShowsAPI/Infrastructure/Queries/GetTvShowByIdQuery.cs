using MediatR;
using TVShowsAPI.Aplication.DTOs;

namespace TVShowsAPI.Infrastructure.Queries
{
    public class GetTvShowByIdQuery : IRequest<TvShowDto>
    {
        public int Id { get; set; }
    }
}
