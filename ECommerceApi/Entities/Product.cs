using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApi.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal RegularPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiscountedPrice { get; set; }
        public string? CoverImageUrl { get; set; }


        public Product()
        {
        }
    }
}

