namespace NetCoreAPI.DTOs
{
    public class ProductGroupFilterDto : PaginationDto
    {
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        //Ordering
        public string OrderingField { get; set; }
        public bool AscendingOrder { get; set; } = true;
    }
}