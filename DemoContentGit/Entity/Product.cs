using System.ComponentModel.DataAnnotations;

namespace DemoContentGit.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
