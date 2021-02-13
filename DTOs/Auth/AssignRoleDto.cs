using System.Collections.Generic;

namespace NetCoreAPI.DTOs
{
    public class AssignRoleDto
    {
        public string Username { get; set; }
        public List<RoleDtoAdd> Roles { get; set; }
    }
}