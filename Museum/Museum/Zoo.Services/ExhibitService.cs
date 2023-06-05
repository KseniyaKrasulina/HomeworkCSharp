using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Museum.Entities;
using Museum.Infrastructure;
using Museum.Services.Dtos;

namespace Museum.Services
{
    public interface IExhibitService
    {
        Task<List<ExhibitDto>> GetAll();
        Task<long> Create(ExhibitCreateDto dto);
    }

    public class ExhibitService : IExhibitService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public ExhibitService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Task<List<ExhibitDto>> GetAll()
        {
            return _dbContext.Exhibits.ProjectTo<ExhibitDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<long> Create(ExhibitCreateDto dto)
        {
            var entity = _mapper.Map<Exhibit>(dto);
            _dbContext.Exhibits.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity.Id;
        }

    }
}