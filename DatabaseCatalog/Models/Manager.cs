
namespace DatabaseCatalog.Models
{
    public class Manager : Base
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
		/// Фамилия
		/// </summary>
		public string? Surname { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string? Patronymic { get; set; }

        /// <summary>
		/// Должность
		/// </summary>
		public string? Appointment { get; set; }

        /// <summary>
        /// Заказы менеджера
        /// </summary>
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
