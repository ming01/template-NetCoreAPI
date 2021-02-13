using System;

namespace NetCoreAPI.DTOs
{
    public class AddProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        //   public bool IsActive { get; set; }
        public int ProductGroupId { get; set; }
    }
}