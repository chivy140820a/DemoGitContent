using System.ComponentModel.DataAnnotations;

namespace DemoContentGit.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
       [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public decimal LastPrice { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
