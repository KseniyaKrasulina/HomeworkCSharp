using Museum.Entities;
using Museum.Services.Mapper;

namespace Museum.Services.Dtos
{
    public class HallDto : IMapFrom<Hall>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string? Title { get; set; }
    }
}