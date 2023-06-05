using Microsoft.AspNetCore.Mvc;
using Museum.Services;
using Museum.Services.Dtos;

namespace Museum.Api.Controllers
{
    [ApiController]
    [Route("api/ExhibitAPI")]
    public class ExhibitsController : ControllerBase
    {
        private readonly IExhibitService _service;

        public ExhibitsController(IExhibitService service)
        {
            _service = service;
        }

        [HttpGet("get_all_exhibits")]
        public Task<List<ExhibitDto>> Get()
        {
            return _service.GetAll();
        }

        [HttpPost("create_exhibit")]
        public Task<long> Create([FromBody] ExhibitCreateDto dto)
        {
            return _service.Create(dto);
        }
    }
}