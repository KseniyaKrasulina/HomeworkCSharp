using Museum.Entities;
using Museum.Services.Mapper;

namespace Museum.Services.Dtos
{
    public class GetLevelsofEducationDto : IMapFrom<Level_of_education>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Образование
        /// </summary>
        public ICollection<Level_of_educationDto>? Levels_of_education { get; set; }
    }
}