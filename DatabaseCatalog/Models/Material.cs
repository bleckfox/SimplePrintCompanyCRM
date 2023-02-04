
namespace DatabaseCatalog.Models
{
    public class Material : Base
    {
        /// <summary>
        /// Название
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Тип/Вид
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Размер листа
        /// </summary>
        public string? PaperSettings { get; set; }

        /// <summary>
        /// В каких заказах используется материал
        /// </summary>
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
