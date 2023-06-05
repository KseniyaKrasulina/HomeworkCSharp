using Microsoft.AspNetCore.Mvc;
using Museum.Services;
using Museum.Services.Dtos;

namespace Museum.Api.Controllers
{
    [ApiController]
    [Route("api/WorkerAPI")]
    public class WorkersController : ControllerBase
    {
        private readonly IWorkerService _service;

        public WorkersController(IWorkerService service)
        {
            _service = service;
        }

        [HttpGet("get_workers")]
        public Task<List<WorkerDto>> Get()
        {
            return _service.GetAll();
        }

        [HttpPost("create_worker")]
        public Task<long> Create([FromBody] WorkerDto dto)
        {
            return _service.Create(dto);
        }
        [HttpPost("{Id:long}/audit")]
        public Task<List<Position_of_workerDto>> GetPositions([FromQuery] long Id)
        {
            return _service.GetPositions(Id);
        }

        [HttpPost("{Id:long}/auditor")]
        public Task<List<GetLevelsofEducationDto>> GetLevelsofEducation([FromQuery] long Id)
        {
            return _service.GetLevelsofEducation(Id);
        }
    }
}