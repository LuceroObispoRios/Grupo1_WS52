using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;
using CargaSinEstres.API.Security.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Resources;

namespace CargaSinEstres.API.CargaSinEstres.Services
{
    public class WorkerService : IWorkerService
    {
        private readonly IWorkerRepository _workerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public WorkerService(IWorkerRepository workerRepository, IUnitOfWork unitOfWork)
        {
            _workerRepository = workerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<WorkerResponse> UpdateCommentsAsync(int id, UpdateCommentResource updateCommentsResource)
        {
            var existingWorker = await _workerRepository.FindByIdAsync(id);

            if (existingWorker == null)
                return new WorkerResponse("El trabajador no fue encontrado.");

            UpdateComments(existingWorker.Comments, updateCommentsResource.Comments);

            try
            {
                _workerRepository.Update(existingWorker);
                await _unitOfWork.CompleteAsync();

                return new WorkerResponse(existingWorker);
            }
            catch (Exception e)
            {
                return new WorkerResponse(
                    $"Un error ocurrió mientras se actualizaba la data del trabajador: {e.Message}");
            }
        }

        private void UpdateComments(IList<Comment> existingComments, IList<CommentUpdatedResource> updatedComments)
        {
            foreach (var updatedComment in updatedComments)
            {
                // Agrega un nuevo comentario
                existingComments.Add(new Comment
                {
                    CommentText = updatedComment.CommentText
                    // Agrega más propiedades según sea necesario
                });
            }
        }


        public async Task<Worker> ListByWorkerIdAsync(int workerId)
        {
            return await _workerRepository.FindByIdAsync(workerId);
        }
    }
}
