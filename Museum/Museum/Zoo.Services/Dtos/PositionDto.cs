using Museum.Entities;
using Museum.Services.Mapper;

namespace Museum.Services.Dtos
{
    public class PositionDto : IMapFrom<Position>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long WorkerId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string? Title { get; set; }
    }
}