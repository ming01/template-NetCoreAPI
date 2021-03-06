using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPI.DTOs;
using NetCoreAPI.Services;

namespace NetCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockservice;
        public StockController(IStockService stockservice)
        {
            _stockservice = stockservice;
        }


        [HttpGet("stockcardtype")]
        public async Task<IActionResult> StockCardType()
        {
            return Ok(await _stockservice.StockCardType());
        }
        [HttpGet("stockcard/filter")]
        public async Task<IActionResult> StockCardFilter([FromQuery] StockCardFilterDto filter)
        {
            return Ok(await _stockservice.StockCardFilter(filter));
        }
        [HttpPost("addstockcard")]
        public async Task<IActionResult> AddStockCard(AddStockCardDto newStockCard)
        {
            return Ok(await _stockservice.AddStockCard(newStockCard));
        }


    }
}