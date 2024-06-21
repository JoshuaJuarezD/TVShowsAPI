using Microsoft.AspNetCore.Mvc;
using TVShowsAPI.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using TVShowsAPI.Aplication.DTOs;
using MediatR;
using TVShowsAPI.Infrastructure.Queries;
using TVShowsAPI.Infrastructure.Commands;

namespace TVShowsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvShowsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TvShowsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /// <summary>
        /// Obtiene todos los tvShow.
        /// </summary>
        /// <returns>Una lista de tvShow.</returns>
        [HttpGet]
        public async Task<IEnumerable<TvShowDto>> GetAll()
        {
            return await _mediator.Send(new GetAllTvShowQuery());
        }

        /// <summary>
        /// Obtiene un tvShow por su ID.
        /// </summary>
        /// <param name="id">ID del tvShow.</param>
        /// <returns>El tvShow solicitado.</returns>
        /// <response code="200">Retorna el tvShow solicitado.</response>
        /// <response code="404">Si el tvShow no es encontrado.</response>
        [HttpGet("{id}")]
        public async Task<ActionResult<TvShowDto>> GetById(int id)
        {
            var query = new GetTvShowByIdQuery { Id = id};
            var tvShow = await _mediator.Send(query);
            if (tvShow == null)
            {
                return NotFound();
            }
            return Ok(tvShow);
        }
        /// <summary>
        /// crea un tvShow.
        /// </summary>
        /// <param name="name">nombre del tvShow.</param>
        /// <param name="favorite">boleano que indica si es favorito.</param>
        /// <returns>El tvShow solicitado.</returns>
        /// <response code="200">Retorna el tvShow registrado.</response>
        [HttpPost]
        public async Task<ActionResult<TvShowDto>> Create(CreateTvShowCommand command)
        {
            var tvShow = await _mediator.Send(command);
            return Ok(tvShow);
        }
        /// <summary>
        /// Actualiza un tvShow.
        /// </summary>
        /// <param name="id">ID del tvShow.</param>
        /// <param name="name">nombre del tvShow.</param>
        /// <param name="favorite">boleano que indica si es favorito.</param>
        /// <returns>El tvShow Con los cambios.</returns>
        /// <response code="200">Retorna el tvShow Actualizado.</response>
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateTvShowCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            var result = await _mediator.Send(command);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        /// <summary>
        /// Elimina un tvShow por su ID.
        /// </summary>
        /// <param name="id">ID del tvShow.</param>
        /// <returns>empty</returns>
        /// <response code="204">Si se elimina de manera exitosa</response>
        /// <response code="404">Si el tvShow no es encontrado.</response>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteTvShowCommand { Id = id });
            if (result == false)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
