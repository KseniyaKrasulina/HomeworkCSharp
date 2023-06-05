using Museum.Entities;
using Museum.Services.Mapper;

namespace Museum.Services.Dtos
{
    public class WorkerDto : IMapFrom<Worker>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Birth { get; set; }

        /// <summary>
        /// Идентификатор зала
        /// </summary>
        public long HallId { get; set; }

        public HallDto? Hall { get; set; }
    }
}