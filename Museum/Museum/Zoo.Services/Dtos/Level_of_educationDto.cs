using Museum.Entities;
using Museum.Services.Mapper;

namespace Museum.Services.Dtos
{
    public class Level_of_educationDto : IMapFrom<Level_of_education>
    {
        /// <summary>
        /// Идентификатор диплома
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Идентификатор Сотрудника
        /// </summary>
        public long WorkerID { get; set; }

        /// <summary>
        /// Уровень образования
        /// </summary>
        public string? Level { get; set; }
    }
}