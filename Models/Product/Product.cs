using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreAPI.Models
{
    [Table("Product")]

    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }

        public bool IsActive { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public int ProductGroupId { get; set; }
        public ProductGroup ProductGroup { get; set; }
        public User User { get; set; }
    }
}