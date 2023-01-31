using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly AppDbContext _db;

        public QuestionService(AppDbContext db)
        {
            _db = db;
        }
        public Task<Question> CreateQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteQuestion(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Question>> GetAllQuestions()
        {
            throw new NotImplementedException();
        }

        public Task<Question> GetQuestionById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Question>> GetQuestions(int id)
        {
            var questions = await _db.Questions.Where(c => c.TemaId == id).ToListAsync();
            return questions;
        }

        public Task<Question> UpdateQuestion(Question question)
        {
            throw new NotImplementedException();
        }
    }
}