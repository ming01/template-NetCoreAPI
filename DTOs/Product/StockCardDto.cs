using System;
using System.Collections.Generic;
namespace NetCoreAPI.DTOs
{
    public class StockCardDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public GetProductDto Product { get; set; }
        public int Add { get; set; }
        public int Del { get; set; }
        public int Stock { get; set; }
        public UserDto User { get; set; }
        public string Remark { get; set; }

    }
}