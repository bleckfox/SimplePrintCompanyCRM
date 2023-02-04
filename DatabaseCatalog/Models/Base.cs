using System.ComponentModel.DataAnnotations;

namespace DatabaseCatalog.Models
{
    /// <summary>
    /// Базовая модель
    /// </summary>
    public class Base
    {
        /// <summary>
        /// Идентификатор (sql не поддерживает Guid по умолчанию)
        /// </summary>
        [Key]
        [MinLength(1)]
        public int Id { get; set; }
    }
}
