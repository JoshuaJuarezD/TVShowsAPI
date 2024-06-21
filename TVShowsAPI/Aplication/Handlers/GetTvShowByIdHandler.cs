using AutoMapper;
using MediatR;
using TVShowsAPI.Aplication.DTOs;
using TVShowsAPI.Infrastructure.Queries;
using TVShowsAPI.Infrastructure.Repositories;

namespace TVShowsAPI.Aplication.Handlers
{
    /*Handles para traer un registro por id un registro*/
    public class GetTvShowByIdHandler : IRequestHandler<GetTvShowByIdQuery, TvShowDto>
    {
        private readonly ITvShowRepository _repository;
        private readonly IMapper _mapper;
        public GetTvShowByIdHandler(ITvShowRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TvShowDto> Handle(GetTvShowByIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<TvShowDto>(response);
        }

    }
}
