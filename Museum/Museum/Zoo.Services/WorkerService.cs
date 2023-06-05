using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Museum.Entities;
using Museum.Infrastructure;
using Museum.Services.Dtos;

namespace Museum.Services
{
    public interface IWorkerService
    {
        Task<List<WorkerDto>> GetAll();
        Task<long> Create(WorkerDto dto);
        Task<List<Position_of_workerDto>> GetPositions(long Id);
        Task<List<GetLevelsofEducationDto>> GetLevelsofEducation(long Id);
    }

    public class WorkerService : IWorkerService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public WorkerService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Task<List<WorkerDto>> GetAll()
        {
            return _dbContext.Workers.ProjectTo<WorkerDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<long> Create(WorkerDto dto)
        {
            var entity = _mapper.Map<Worker>(dto);
            _dbContext.Workers.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity.Id;
        }
        public async Task<List<Position_of_workerDto>> GetPositions(long Id)
        {
            var preresult = await _dbContext.Position_of_worker.Where(p => p.WorkerID == Id).ToListAsync();
            var result = _mapper.Map<List<Position_of_workerDto>>(preresult);
            return result;
        }
        public async Task<List<GetLevelsofEducationDto>> GetLevelsofEducation(long Id)
        {
            var preresult = await _dbContext.Levels_of_education.Where(p => p.WorkerID == Id).ToListAsync();
            var result = _mapper.Map<List<GetLevelsofEducationDto>>(preresult);
            return result;
        }
    }
}