namespace NetCoreAPI.DTOs
{
    public class AddStockCardDto
    {
        public string Remark { get; set; }
        public int Qty { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public int ProductId { get; set; }
        public int StockCardType { get; set; }

    }
}