using System;
using System.Collections.Generic;

namespace NetCoreAPI.DTOs
{
    public class GetProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }

        public bool IsActive { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ProductGroupId { get; set; }
        public GetProductGroupDto ProductGroup { get; set; }
        public UserDto User { get; set; }

    }
}