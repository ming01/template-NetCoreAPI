using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreAPI.Models
{
    public class Bulk
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BulkId { get; set; }
        [StringLength(20)]
        public string BulkName { get; set; }

        [StringLength(20)]
        public string BulkCode { get; set; }
    }
}