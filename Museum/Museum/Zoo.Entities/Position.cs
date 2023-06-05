using Museum.Entities;

namespace Museum.Entities
{
    /// <summary>
    /// Должность
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Работники
        /// </summary>
        public virtual ICollection<Position_of_worker>? Workers { get; set; }
    }
}