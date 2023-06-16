using DoaseApp.Shared;
using DoaseApp.Shared.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoaseApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _repository;

        public ItemController(IItemRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("all")]
        public IEnumerable<Item> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("byName")]
        public Item GetItemByName(string name)
        {
            return _repository.GetItemByName(name);
        }

        [HttpPost]
        public void Post([FromBody] Item name)
        {
            _repository.AddItem(name);
        }
    }
}