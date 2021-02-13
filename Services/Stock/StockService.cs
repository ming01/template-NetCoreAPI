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

        public async Task<ServiceResponse<List<StockCardTypeDto>>> StockCardType()
        {
            var stockcardtype = await _dbContext.StockCardTypes.Where(x => x.IsActive == true).ToListAsync();

            var dto = _mapper.Map<List<StockCardTypeDto>>(stockcardtype);

            return ResponseResult.Success(dto);
        }
    }
}