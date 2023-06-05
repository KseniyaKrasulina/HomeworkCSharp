using Microsoft.AspNetCore.Mvc;
using Museum.Services;
using Museum.Services.Dtos;

namespace Museum.Api.Controllers
{
    [ApiController]
    [Route("api/HallAPI")]
    public class HallController : ControllerBase
    {
        private readonly IHallService _service;

        public HallController(IHallService service)
        {
            _service = service;
        }

        [HttpGet("get_hall")]
        public Task<List<HallDto>> Get()
        {
            return _service.GetAll();
        }

        [HttpPost("create_halls")]
        public Task<long> Create([FromBody] HallDto dto)
        {
            return _service.Create(dto);
        }

        [HttpPost("{Id:long}/audit")]
        public Task<List<GetExhibitsDto>> GetExhibits([FromQuery] long Id)
        {
            return _service.GetExhibits(Id);
        }
    }
}