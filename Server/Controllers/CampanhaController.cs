using DoaseApp.Shared;
using DoaseApp.Shared.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoaseApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CampanhaController : ControllerBase
    {
        private readonly ICampanhaRepository _repository;

        public CampanhaController(ICampanhaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Campanha> Get()
        {
            return _repository.GetAll().ToList();
        }

        [HttpGet("CampanhaByUser")]
        public Campanha GetCampanhaByUser(string email)
        {
            return _repository.GetCampanhaByUser(email);
        }

        [HttpPost]
        public void Post(Campanha campanha)
        {
            _repository.AddCampanha(campanha);
        }
    }
}