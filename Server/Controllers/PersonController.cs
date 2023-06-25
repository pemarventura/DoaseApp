using DoaseApp.Shared;
using DoaseApp.Shared.Classes;
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

        [HttpGet("all")]
        public IEnumerable<Person> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("byEmail")]
        public Person GetUserByEmail(string email)
        {
            return _repository.GetUserByEmail(email);
        }

        [HttpPost]
        public void Post([FromBody] Person person)
        {
            _repository.AddPerson(person);
        }

        [HttpPut("{update}")]
        public IActionResult Put([FromBody] Person updatedPerson)
        {
            _repository.UpdatePerson(updatedPerson);

            return NoContent();
        }
    }
}