using System;
using System.Collections.Generic;

namespace NetCoreAPI.DTOs
{
    public class GetProductGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public UserDto User { get; set; }
        public List<GetProductDto> Product { get; set; }
    }
}