using System.ComponentModel.DataAnnotations;

namespace DemoContentGit.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string Decripstion { get; set; }
        public string PathImage { get; set; }
        public decimal Price { get; set; }
        public decimal LastPrice { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
