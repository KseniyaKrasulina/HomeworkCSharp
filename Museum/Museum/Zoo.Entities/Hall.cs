using Museum.Entities;

namespace Museum.Entities
{
    /// <summary>
    /// Зал
    /// </summary>
    public class Hall
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
        /// Сотрудники
        /// </summary>
        public virtual ICollection<Worker>? Workers { get; set; }
        /// <summary>
        /// Экспонаты
        /// </summary>
        public virtual ICollection<Exhibit>? Exhibits { get; set; }
    }
}