using NetCoreAPI.Validations;

namespace NetCoreAPI.DTOs
{
    public class RoleDtoAdd
    {
        [FirstLetterUpperCase]
        public string RoleName { get; set; }
    }
}