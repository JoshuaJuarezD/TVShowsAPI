using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using TVShowsAPI.Aplication.DTOs;
using TVShowsAPI.Domain;
using TVShowsAPI.Infrastructure.Commands;
using TVShowsAPI.Infrastructure.Data;
using TVShowsAPI.Infrastructure.Repositories;

namespace TVShowsAPI.Aplication.Handlers
{
    /*Handles para crear un registro, desacoplando para mayor mantenibilidad*/
    public class CreateTvShowHandler : IRequestHandler<CreateTvShowCommand, TvShowDto>
    {
        private readonly ITvShowRepository _repository; //Logica de negocio
        private readonly IMapper _mapper;//Mapeo de objetos
        public CreateTvShowHandler(ITvShowRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        /*Mapea el objeto lo guarda con repository y lo retorna mapeando nuevamente*/
        public async Task<TvShowDto> Handle(CreateTvShowCommand request, CancellationToken cancellationToken)
        {
            TvShow tvShow = _mapper.Map<TvShow>(request);
            var response = await _repository.AddAsync(tvShow);
            return _mapper.Map<TvShowDto>(response);

        }
    }
}
