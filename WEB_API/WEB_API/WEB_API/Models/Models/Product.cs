using System.ComponentModel.DataAnnotations;

namespace WEB_API.Controllers.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
