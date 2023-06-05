using Museum.Entities;
using Museum.Services.Mapper;

namespace Museum.Services.Dtos
{
    public class ExhibitCreateDto : IMapTo<Exhibit>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Идентификатор холла
        /// </summary>
        public long HallID { get; set; }

        /// <summary>
        /// Название экспоната
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Описание экспоната
        /// </summary>
        public string? Description { get; set; }
    }
}