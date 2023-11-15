using AutoMapper;
using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Resources;
using CargaSinEstres.API.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CargaSinEstres.API.CargaSinEstres.Controllers
{
    /// <summary>
    /// Controlador para manejar las operaciones relacionadas con los trabajadores.
    /// </summary>
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class WorkersController : ControllerBase
    {
        private readonly IWorkerService _workerService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor del controlador de trabajadores.
        /// </summary>
        /// <param name="workerService">Servicio de trabajadores.</param>
        /// <param name="mapper">Instancia de AutoMapper para el mapeo de objetos.</param>
        public WorkersController(IWorkerService workerService, IMapper mapper)
        {
            _workerService = workerService;
            _mapper = mapper;
        }

        /// <summary>
        /// Obtiene la información de un trabajador por su identificador.
        /// </summary>
        /// <param name="id">Identificador del trabajador.</param>
        /// <returns>Información del trabajador.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorkerById(int id)
        {
            var workers = await _workerService.ListByWorkerIdAsync(id);
            var resource = _mapper.Map<Worker, WorkerResource>(workers);
            return Ok(resource);
        }

        /// <summary>
        /// Actualiza los comentarios de un trabajador mediante la operación PATCH.
        /// </summary>
        /// <param name="id">Identificador del trabajador.</param>
        /// <param name="updateCommentResource">Recursos para la actualización de comentarios.</param>
        /// <returns>Resultado de la operación y recursos actualizados del trabajador.</returns>
        [HttpPatch("{id}/comments")]
        public async Task<IActionResult> PatchWorkerComments(int id, [FromBody] UpdateCommentResource updateCommentResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var result = await _workerService.UpdateCommentsAsync(id, updateCommentResource);

            if (!result.Success)
                return BadRequest(result.Message);

            var workerResource = _mapper.Map<Worker, WorkerResource>(result.Resource);
            return Ok(workerResource);
        }
    }
}
