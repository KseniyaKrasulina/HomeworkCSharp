using Museum.Entities;

namespace Museum.Entities
{
    /// <summary>
    /// Трудовая книжка
    /// </summary>
    public class Level_of_education
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


        /// <summary>
        /// Сотрудник
        /// </summary>
        public virtual Worker? Worker { get; set; }
    }
}