using DoaseApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoaseApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _repository;

        public PersonController(IPersonRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _repository.GetAll();
        }

        [HttpPost]
        public void Post([FromBody] Person person)
        {
            _repository.AddPerson(person);
        }
    }
}