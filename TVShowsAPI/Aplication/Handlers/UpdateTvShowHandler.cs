using AutoMapper;
using MediatR;
using TVShowsAPI.Aplication.DTOs;
using TVShowsAPI.Domain;
using TVShowsAPI.Infrastructure.Commands;
using TVShowsAPI.Infrastructure.Repositories;

namespace TVShowsAPI.Aplication.Handlers
{
    /*Handles para actualizar un registro por id*/
    public class UpdateTvShowHandler : IRequestHandler<UpdateTvShowCommand, TvShowDto>
    {
        private readonly ITvShowRepository _repository;
        private readonly IMapper _mapper;
        public UpdateTvShowHandler(ITvShowRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TvShowDto> Handle(UpdateTvShowCommand request, CancellationToken cancellationToken)
        {
            TvShow tvShow = _mapper.Map<TvShow>(request);
            var response = await _repository.UpdateAsync(tvShow);
            return _mapper.Map<TvShowDto>(response);

        }
    }
}
