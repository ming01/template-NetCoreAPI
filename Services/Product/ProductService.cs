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
    public class ProductService : ServiceBase, IProductService
    {
        private readonly AppDBContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger _log;
        private readonly IHttpContextAccessor _httpContext;

        public ProductService(IHttpContextAccessor httpContext
        , AppDBContext dbContext
        , IMapper mapper
        , ILogger<ProductService> log) : base(dbContext, mapper, httpContext)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
            this._log = log;
            _httpContext = httpContext;

        }

        public async Task<ServiceResponse<GetProductGroupDto>> AddProductGroup(AddProductGroupDto newProductGroup)
        {
            var productgroup = new ProductGroup();
            productgroup.Name = newProductGroup.Name;
            productgroup.IsActive = true;

            productgroup.UserId = Guid.Parse(GetUserId());
            //productgroup.CreateBy = default(Guid);
            productgroup.CreatedDate = Now();
            _dbContext.ProductGroups.Add(productgroup);
            await _dbContext.SaveChangesAsync();

            var dto = _mapper.Map<GetProductGroupDto>(productgroup);
            return ResponseResult.Success(dto);
        }

        public async Task<ServiceResponse<GetProductDto>> AddProductr(AddProductDto newProductr)
        {
            var productgroup = await _dbContext.ProductGroups.FirstOrDefaultAsync(x => x.Id == newProductr.ProductGroupId);
            if (productgroup == null)
            {
                return ResponseResult.Failure<GetProductDto>("productgroup not found.");
            }
            var product = new Product();
            product.Name = newProductr.Name;
            product.Price = newProductr.Price;
            product.Qty = newProductr.Qty;
            product.IsActive = true;
            product.UserId = Guid.Parse(GetUserId());
            product.CreatedDate = Now();
            product.ProductGroupId = newProductr.ProductGroupId;
            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            var dto = _mapper.Map<GetProductDto>(product);
            return ResponseResult.Success(dto);


        }

        public async Task<ServiceResponse<GetProductGroupDto>> EditProductGroup(EditProductGroupDto editProductGroup)
        {
            var productgroup = await _dbContext.ProductGroups.FirstOrDefaultAsync(x => x.Id == editProductGroup.Id);
            if (productgroup == null)
            {
                return ResponseResult.Failure<GetProductGroupDto>("productgroup not found.");
            }
            productgroup.Name = editProductGroup.Name;
            productgroup.IsActive = editProductGroup.IsActive;
            productgroup.UserId = Guid.Parse(GetUserId());
            productgroup.CreatedDate = Now();
            _dbContext.ProductGroups.Update(productgroup);
            await _dbContext.SaveChangesAsync();

            var dto = _mapper.Map<GetProductGroupDto>(productgroup);

            return ResponseResult.Success(dto);

        }

        public async Task<ServiceResponse<GetProductDto>> EditProductr(EditProductDto editProduct)
        {
            var productgroup = await _dbContext.ProductGroups.FirstOrDefaultAsync(x => x.Id == editProduct.ProductGroupId);
            if (productgroup == null)
            {
                return ResponseResult.Failure<GetProductDto>("productgroup not found.");
            }

            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == editProduct.Id);
            //var characters = await _dBContext.Characters.Include(x => x.Weapon).AsNoTracking().ToListAsync();
            if (product == null)
            {
                return ResponseResult.Failure<GetProductDto>("Product not found.");
            }
            product.Name = editProduct.Name;
            product.Price = editProduct.Price;
            product.Qty = editProduct.Qty;
            product.IsActive = editProduct.IsActive;
            product.UserId = Guid.Parse(GetUserId());
            product.CreatedDate = Now();
            product.ProductGroupId = editProduct.ProductGroupId;
            _dbContext.Products.Update(product);
            await _dbContext.SaveChangesAsync();
            var dto = _mapper.Map<GetProductDto>(product);
            return ResponseResult.Success(dto);
        }

        public async Task<ServiceResponse<List<GetProductGroupDto>>> GetAllGroupProducts()
        {
            var ProductGroup = await _dbContext.ProductGroups.Include(x => x.Product).AsNoTracking().ToListAsync();

            var dto = _mapper.Map<List<GetProductGroupDto>>(ProductGroup);

            return ResponseResult.Success(dto);
        }

        public async Task<ServiceResponse<List<GetProductDto>>> GetAllProducts()
        {
            var Product = await _dbContext.Products.AsNoTracking().ToListAsync();

            var dto = _mapper.Map<List<GetProductDto>>(Product);

            return ResponseResult.Success(dto);
        }


        public async Task<ServiceResponseWithPagination<List<GetProductDto>>> GetProductFilter(ProductFilterDto filter)
        {
            var queryable = _dbContext.Products.Include(x => x.ProductGroup).Include(x => x.User).AsQueryable();
            // var queryable = _dbContext.Products.AsQueryable();
            //Filter
            if (!string.IsNullOrWhiteSpace(filter.Name))
            {
                queryable = queryable.Where(x => x.Name.Contains(filter.Name));
            }
            if (filter.ProductGroupId != 0)
            {
                queryable = queryable.Where(x => x.ProductGroupId.Equals(filter.ProductGroupId));
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
                    return ResponseResultWithPagination.Failure<List<GetProductDto>>($"Could not order by field: {filter.OrderingField}");
                }
            }
            var paginationResult = await _httpContext.HttpContext
         .InsertPaginationParametersInResponse(queryable, filter.RecordsPerPage, filter.Page);

            var Product = await queryable.Paginate(filter).ToListAsync();

            var dto = _mapper.Map<List<GetProductDto>>(Product);

            return ResponseResultWithPagination.Success(dto, paginationResult);

        }

        public async Task<ServiceResponse<GetProductGroupDto>> GetProductGroupById(int productrgroupId)
        {
            var productGroup = await _dbContext.ProductGroups.Include(x => x.User).FirstOrDefaultAsync(x => x.Id == productrgroupId);
            if (productGroup == null)
            {
                return ResponseResult.Failure<GetProductGroupDto>("Product not found.");
            }

            var dto = _mapper.Map<GetProductGroupDto>(productGroup);

            return ResponseResult.Success(dto);
        }

        public async Task<ServiceResponseWithPagination<List<GetProductGroupDto>>> GetProductGroupFilter(ProductGroupFilterDto filter)
        {

            var queryable = _dbContext.ProductGroups.Include(x => x.User).AsQueryable();
            //Filter
            if (!string.IsNullOrWhiteSpace(filter.Name) && filter.Name != "")
            {
                queryable = queryable.Where(x => x.Name.Contains(filter.Name));
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
                    return ResponseResultWithPagination.Failure<List<GetProductGroupDto>>($"Could not order by field: {filter.OrderingField}");
                }
            }

            var paginationResult = await _httpContext.HttpContext
            .InsertPaginationParametersInResponse(queryable, filter.RecordsPerPage, filter.Page);
            var ProductGroup = await queryable.Paginate(filter).ToListAsync();
            var dto = _mapper.Map<List<GetProductGroupDto>>(ProductGroup);

            return ResponseResultWithPagination.Success(dto, paginationResult);

        }

        public async Task<ServiceResponse<GetProductDto>> GetProductrById(int productrId)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == productrId);
            if (product == null)
            {
                return ResponseResult.Failure<GetProductDto>("Product not found.");
            }

            var dto = _mapper.Map<GetProductDto>(product);

            return ResponseResult.Success(dto);
        }

        public async Task<ServiceResponse<List<GetProductDto>>> ProductrByProductGroupId(int productGroupId)
        {

            var product = await _dbContext.Products.Where(x => x.ProductGroupId == productGroupId).ToListAsync();

            var dto = _mapper.Map<List<GetProductDto>>(product);

            return ResponseResult.Success(dto);

        }
    }
}