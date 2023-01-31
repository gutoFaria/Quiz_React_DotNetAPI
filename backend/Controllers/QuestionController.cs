using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _service;

        public QuestionController(IQuestionService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("/getquestions/{id}")]
        public async Task<IActionResult> GetQuestions(int id)
        {
            var res = await _service.GetQuestions(id);
            return Ok(res);
        }
    }
}