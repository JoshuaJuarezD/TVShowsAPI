using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TVShowsAPI.Aplication.DTOs;
using TVShowsAPI.Infrastructure.Commands;
using TVShowsAPI.Infrastructure.Queries;
using TVShowsAPI.Infrastructure.Repositories;


namespace TVShowsAPI.Application.Handlers
{
    /*Handles para traer todos los registro*/
    public class GetAllTvShowHandler : IRequestHandler<GetAllTvShowQuery, IEnumerable<TvShowDto>>
    {
        private readonly ITvShowRepository _repository;
        private readonly IMapper _mapper;

        public GetAllTvShowHandler(ITvShowRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TvShowDto>> Handle(GetAllTvShowQuery request, CancellationToken cancellationToken)
        {
            var response = await _repository.GetAllAsync(); // Espera a que la tarea se complete
            return _mapper.Map<IEnumerable<TvShowDto>>(response); // Mapea el resultado
        }
    }
}

