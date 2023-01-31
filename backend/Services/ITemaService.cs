using backend.Models;

namespace backend.Services
{
    public interface ITemaService
    {
        Task<IEnumerable<Tema>> GetAllTemas();
        Task<Tema> GetTemaById(int id);
        Task<Tema> CreateTema(Tema tema);
        Task<Tema> UpdateTema(Tema tema);
        Task<bool> DeleteTema(int id);
    }
}