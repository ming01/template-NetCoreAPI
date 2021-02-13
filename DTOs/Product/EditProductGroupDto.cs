using System;

namespace NetCoreAPI.DTOs
{
    public class EditProductGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}