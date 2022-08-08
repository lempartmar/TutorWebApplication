using Microsoft.AspNetCore.Mvc;
using TutorApp.DAL;
using TutorApp.Repositories.Interfaces;
using TutorApp.ViewModels;

namespace TutorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetTutorController : ControllerBase
    {


        private readonly ILogger<GetTutorController> _logger;
        private readonly DbWebContext _context;
        private readonly ITutorRepository _tutorRepository;

        public GetTutorController(ILogger<GetTutorController> logger, DbWebContext context, ITutorRepository tutorRepository)
        {
            _logger = logger;
            _context = context;
            _tutorRepository = tutorRepository;
        }

        [HttpGet(Name = "GetTutorId")]
        public IEnumerable<TutorVM> GetTutorId()
        {

            var result = _tutorRepository.GetTutorsDataByID(1).ToArray();
            return result;

        }
    }
}