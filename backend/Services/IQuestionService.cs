using backend.Models;

namespace backend.Services
{
    public interface IQuestionService
    {
        Task<IEnumerable<Question>> GetAllQuestions();
        Task<Question> GetQuestionById(int id);
        Task<IEnumerable<Question>> GetQuestions(int id);
        Task<Question> CreateQuestion(Question question);
        Task<Question> UpdateQuestion(Question question);
        Task<bool> DeleteQuestion(int id);
    }
}