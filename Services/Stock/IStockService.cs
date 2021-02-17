using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreAPI.DTOs;
using NetCoreAPI.Models;
namespace NetCoreAPI.Services
{
    public interface IStockService
    {
        Task<ServiceResponse<List<StockCardTypeDto>>> StockCardType();
        //StockCardDto
        Task<ServiceResponseWithPagination<List<StockCardDto>>> StockCardFilter(StockCardFilterDto filter);

        Task<ServiceResponse<StockCardDto>> AddStockCard(AddStockCardDto newStockCard);
    }
}