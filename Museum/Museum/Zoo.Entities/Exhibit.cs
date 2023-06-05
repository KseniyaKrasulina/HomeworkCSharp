using Museum.Entities;

namespace Museum.Entities
{
    /// <summary>
    /// Экспонат
    /// </summary>
    public class Exhibit
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Идентификатор зала
        /// </summary>

        public long HallID { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Зал
        /// </summary>
        public virtual Hall? Hall { get; set; }

    }
}