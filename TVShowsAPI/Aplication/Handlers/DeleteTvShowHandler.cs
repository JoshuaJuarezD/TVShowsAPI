using AutoMapper;
using MediatR;
using TVShowsAPI.Aplication.DTOs;
using TVShowsAPI.Infrastructure.Commands;
using TVShowsAPI.Infrastructure.Repositories;

namespace TVShowsAPI.Aplication.Handlers
{ 
    /*Handles para eliminar un registro*/
    public class DeleteTvShowHandler : IRequestHandler<DeleteTvShowCommand, bool>
    {
        private readonly ITvShowRepository _repository;
        public DeleteTvShowHandler(ITvShowRepository repository)
        {
            _repository = repository; //repositorio
        }
        public Task<bool> Handle(DeleteTvShowCommand request, CancellationToken cancellationToken)
        {
            var response = _repository.DeleteAsync(request.Id);
            return response;
        }
    }
}
