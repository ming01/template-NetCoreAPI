using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NetCoreAPI.Data;
using NetCoreAPI.DTOs;
using NetCoreAPI.Helpers;
using NetCoreAPI.Models;
using System.Linq.Dynamic.Core;

namespace NetCoreAPI.Services
{
    public class StockService : ServiceBase, IStockService
    {
        private readonly AppDBContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger _log;
        private readonly IHttpContextAccessor _httpContext;

        public StockService(IHttpContextAccessor httpContext
        , AppDBContext dbContext
        , IMapper mapper
        , ILogger<ProductService> log) : base(dbContext, mapper, httpContext)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
            this._log = log;
            _httpContext = httpContext;

        }

        public async Task<ServiceResponse<StockCardDto>> AddStockCard(AddStockCardDto newStockCard)
        {
            var stockcard = new StockCard();
            stockcard.Remark = newStockCard.Remark;

            if (newStockCard.StockCardType == 1)
            {
                stockcard.Add = newStockCard.Qty;
                stockcard.Del = 0;
            }
            else
            {
                stockcard.Add = 0;
                stockcard.Del = newStockCard.Qty;
            }
            stockcard.Stock = newStockCard.Stock;
            stockcard.IsActive = true;
            stockcard.CreatedDate = Now();
            stockcard.UserId = Guid.Parse(GetUserId());
            stockcard.ProductId = newStockCard.ProductId;
            _dbContext.StockCards.Add(stockcard);
            await _dbContext.SaveChangesAsync();
            var dto = _mapper.Map<StockCardDto>(stockcard);
            return ResponseResult.Success(dto);
        }

        public async Task<ServiceResponseWithPagination<List<StockCardDto>>> StockCardFilter(StockCardFilterDto filter)
        {
            var queryable = _dbContext.StockCards.Include(x => x.User).Include(x => x.Product).ThenInclude(x => x.ProductGroup).AsQueryable();
            //var queryable = _dbContext.StockCards.AsQueryable();
            //Filter
            if (!string.IsNullOrWhiteSpace(filter.Name) && filter.Name != "")
            {
                queryable = queryable.Where(x => x.Product.Name.Contains(filter.Name));
            }
            if (filter.IsActive != null)
            {
                queryable = queryable.Where(x => x.IsActive.Equals(filter.IsActive));
            }
            //Ordering
            if (!string.IsNullOrWhiteSpace(filter.OrderingField))
            {
                try
                {
                    queryable = queryable.OrderBy($"{filter.OrderingField} {(filter.AscendingOrder ? "ascending" : "descending")}");
                }
                catch
                {
                    return ResponseResultWithPagination.Failure<List<StockCardDto>>($"Could not order by field: {filter.OrderingField}");
                }
            }
            var paginationResult = await _httpContext.HttpContext
    .InsertPaginationParametersInResponse(queryable, filter.RecordsPerPage, filter.Page);
            var StockCard = await queryable.Paginate(filter).ToListAsync();
            var dto = _mapper.Map<List<StockCardDto>>(StockCard);
            return ResponseResultWithPagination.Success(dto, paginationResult);
        }

        public async Task<ServiceResponse<List<StockCardTypeDto>>> StockCardType()
        {
            var stockcardtype = await _dbContext.StockCardTypes.Where(x => x.IsActive == true).ToListAsync();

            var dto = _mapper.Map<List<StockCardTypeDto>>(stockcardtype);

            return ResponseResult.Success(dto);
        }
    }
}