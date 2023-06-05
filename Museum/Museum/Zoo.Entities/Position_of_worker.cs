using Museum.Entities;

namespace Museum.Entities
{
    /// <summary>
    /// Работник в должности
    /// </summary>
    public class Position_of_worker
    {
        /// <summary>
        /// ID 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// ID Работникa
        /// </summary>
        public int WorkerID { get; set; }
        /// <summary>
        /// Работник
        /// </summary>
        public virtual Worker? Worker { get; set; }

        /// <summary>
        /// ID Должности
        /// </summary>
        public int PositionID { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public virtual Position? Position { get; set; }
    }
}