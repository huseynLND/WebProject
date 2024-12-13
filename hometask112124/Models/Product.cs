using System.ComponentModel.DataAnnotations;

namespace hometask112124.Models
{
    public class Product : BaseEntity
    {
        [MaxLength(32), Required]
        public string Name { get; set; }
        [MaxLength(512), Required]
        public string Description { get; set; }
        public string CoverImage { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        [DataType("decimal(18,2)")]
        public decimal CostPrice { get; set; }
        [DataType("decimal(18,2)")]
        public decimal SellPrice { get; set; }
        [Range (0, 100)]
        public int Discount { get; set; }
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }
    }
}
