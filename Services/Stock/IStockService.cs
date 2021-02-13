using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreAPI.DTOs;
using NetCoreAPI.Models;
namespace NetCoreAPI.Services
{
    public interface IStockService
    {
        Task<ServiceResponse<List<StockCardTypeDto>>> StockCardType();
    }
}