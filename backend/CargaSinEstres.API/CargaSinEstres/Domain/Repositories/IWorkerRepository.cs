using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using System.Threading.Tasks;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Repositories
{
    /// <summary>
    /// Interfaz que define las operaciones permitidas en el repositorio de trabajadores.
    /// </summary>
    public interface IWorkerRepository
    {
        /// <summary>
        /// Encuentra un trabajador por su identificador asincrónicamente.
        /// </summary>
        /// <param name="workerId">Identificador del trabajador.</param>
        /// <returns>Una tarea que representa la operación y contiene el trabajador encontrado.</returns>
        Task<Worker> FindByIdAsync(int workerId);

        /// <summary>
        /// Actualiza la información de un trabajador.
        /// </summary>
        /// <param name="worker">Instancia del trabajador que se actualizará.</param>
        void Update(Worker worker);
    }
}