
namespace DatabaseCatalog.Models
{
    /// <summary>
    /// Модель заказа
    /// </summary>
    public class Order : Base
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
        /// Тираж
        /// </summary>
        public int Volume { get; set; }

        /// <summary>
        /// Идентификатор материала
        /// </summary>
        public int MaterialId { get; set; }

        /// <summary>
        /// Идентификатор менеджера
        /// </summary>
        public int ManagerId { get; set; }

        /// <summary>
        /// Материал
        /// </summary>
        public Material? Material { get; set; }

        /// <summary>
        /// Менеджер
        /// </summary>
        public Manager? Manager { get; set; }
    }
}
