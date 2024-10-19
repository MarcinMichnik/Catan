using Microsoft.AspNetCore.Mvc;
using ProjectCatan.Models;

namespace ProjectCatan.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FieldController : ControllerBase
    {
        private readonly ILogger<FieldController> _logger;

        public FieldController(ILogger<FieldController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetField")]
        public IEnumerable<Field> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Field
            {
                Value = index,
                FieldType = "Earth"
            })
            .ToArray();
        }
    }
}