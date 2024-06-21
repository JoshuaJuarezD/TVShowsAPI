using AutoMapper;
using TVShowsAPI.Aplication.DTOs;
using TVShowsAPI.Domain;
using TVShowsAPI.Infrastructure.Commands;

namespace TVShowsAPI.Infrastructure.Data
{
    /*Mapeo entre objetos*/
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TvShow, TvShowDto>();
            CreateMap<CreateTvShowCommand, TvShow>();
            CreateMap<UpdateTvShowCommand, TvShow>();
            CreateMap<TvShowDto, TvShow>();
        }
    }
}

