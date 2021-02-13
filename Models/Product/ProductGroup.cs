using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreAPI.Models
{
    [Table("ProductGroup")]
    public class ProductGroup
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public User User { get; set; }
        public List<Product> Product { get; set; }


    }
}