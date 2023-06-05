using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Museum.Entities;
using Museum.Infrastructure;
using Museum.Services.Dtos;

namespace Museum.Services
{
    public interface IHallService
    {
        Task<List<HallDto>> GetAll();
        Task<long> Create(HallDto dto);
        Task<List<GetExhibitsDto>> GetExhibits(long Id);
    }

    public class HallService : IHallService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public HallService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Task<List<HallDto>> GetAll()
        {
            return _dbContext.Halls.ProjectTo<HallDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<long> Create(HallDto dto)
        {
            var entity = _mapper.Map<Hall>(dto);
            _dbContext.Halls.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity.Id;
        }
        public async Task<List<GetExhibitsDto>> GetExhibits(long Id)
        {
            var preresult = await _dbContext.Exhibits.Where(p => p.HallID == Id).ToListAsync();
            var result = _mapper.Map<List<GetExhibitsDto>>(preresult);
            return result;
        }

    }
}