using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreAPI.Models
{
    [Table("StockCard")]
    public class StockCard
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Remark { get; set; }
        public int Add { get; set; }
        public int Del { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}