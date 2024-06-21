using MediatR;
using TVShowsAPI.Aplication.DTOs;

namespace TVShowsAPI.Infrastructure.Queries
{
    public class GetAllTvShowQuery : IRequest<IEnumerable<TvShowDto>>
    {
    }
}
