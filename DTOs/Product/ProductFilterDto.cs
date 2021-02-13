namespace NetCoreAPI.DTOs
{
    public class ProductFilterDto : PaginationDto
    {
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public int ProductGroupId { get; set; }
        //Ordering
        public string OrderingField { get; set; }
        public bool AscendingOrder { get; set; } = true;
    }
}