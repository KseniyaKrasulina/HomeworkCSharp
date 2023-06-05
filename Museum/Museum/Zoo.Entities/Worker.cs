using Museum.Entities;

namespace Museum.Entities
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Worker
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

        /// <summary>
        /// Зал
        /// </summary>
        public virtual Hall? Hall { get; set; }

        /// <summary>
        /// Образование
        /// </summary>
        public virtual ICollection<Level_of_education>? Levels_of_education { get; set; }

        /// <summary>
        /// Должности
        /// </summary>
        public virtual ICollection<Position_of_worker>? Positions { get; set; }
    }
}