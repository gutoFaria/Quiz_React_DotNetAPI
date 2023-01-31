using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Services
{
    public class TemaService : ITemaService
    {
        private readonly AppDbContext _db;

        public TemaService(AppDbContext db)
        {
            _db = db;
        }
        public async Task<Tema> CreateTema(Tema tema)
        {
            await _db.Temas.AddAsync(tema);
            await _db.SaveChangesAsync();
            return tema;
        }

        public async Task<bool> DeleteTema(int id)
        {
            var tema = await _db.Temas.FindAsync(id);
            if(tema != null)
            {
                _db.Temas.Remove(tema);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Tema>> GetAllTemas()
        {
            return await _db.Temas.ToListAsync();
        }

        public async Task<Tema> GetTemaById(int id)
        {
            var tema = await _db.Temas.FindAsync(id);
            if(tema != null)
            {
                return tema;
            }

            return null!;
        }

        public async Task<Tema> UpdateTema(Tema tema)
        {
            if(tema.Id != 0)
            {
                var c = await _db.Temas.FindAsync(tema.Id);
                if(c != null)
                {
                    c.Title = tema.Title;
                    await _db.SaveChangesAsync();
                    return tema;
                }
            }

            return null!;
        }
    }
}