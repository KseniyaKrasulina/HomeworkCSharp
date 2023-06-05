using Museum.Entities;
using Museum.Services.Mapper;

namespace Museum.Services.Dtos
{
    public class Position_of_workerDto : IMapFrom<Position_of_worker>
    {
        /// <summary>
        /// Экспонаты
        /// </summary>
        public ICollection<PositionDto>? Positions { get; set; }

    }
}