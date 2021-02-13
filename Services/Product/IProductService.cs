using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreAPI.DTOs;
using NetCoreAPI.Models;

namespace NetCoreAPI.Services
{
    public interface IProductService
    {
        Task<ServiceResponse<List<GetProductDto>>> GetAllProducts();
        Task<ServiceResponse<List<GetProductGroupDto>>> GetAllGroupProducts();
        Task<ServiceResponse<GetProductDto>> AddProductr(AddProductDto newProduct);
        Task<ServiceResponse<GetProductGroupDto>> AddProductGroup(AddProductGroupDto newProductGroup);
        Task<ServiceResponse<GetProductDto>> EditProductr(EditProductDto editProduct);
        Task<ServiceResponse<GetProductGroupDto>> EditProductGroup(EditProductGroupDto editProductGroup);
        Task<ServiceResponseWithPagination<List<GetProductGroupDto>>> GetProductGroupFilter(ProductGroupFilterDto filter);
        Task<ServiceResponseWithPagination<List<GetProductDto>>> GetProductFilter(ProductFilterDto filter);
        Task<ServiceResponse<GetProductDto>> GetProductrById(int productrId);
        Task<ServiceResponse<GetProductGroupDto>> GetProductGroupById(int productrgroupId);

        Task<ServiceResponse<List<GetProductDto>>> ProductrByProductGroupId(int productGroupId);
    }
}