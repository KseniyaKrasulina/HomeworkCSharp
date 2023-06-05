using Museum.Entities;
using Museum.Services.Mapper;

namespace Museum.Services.Dtos
{
    public class GetExhibitsDto : IMapFrom<Exhibit>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Экспонаты
        /// </summary>
        public  ICollection<ExhibitCreateDto>? Exhibits { get; set; }
    }
}