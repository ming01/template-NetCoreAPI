using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPI.DTOs;
using NetCoreAPI.Services;

namespace NetCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productservice;
        public ProductController(IProductService productservice)
        {
            _productservice = productservice;
        }

        [HttpGet("getallproducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await _productservice.GetAllProducts());
        }

        [HttpGet("getallproductgroups")]
        public async Task<IActionResult> GetAllGroupProducts()
        {
            return Ok(await _productservice.GetAllGroupProducts());
        }
        [HttpPost("addproductrs")]
        public async Task<IActionResult> AddProductr(AddProductDto newProduc)
        {
            return Ok(await _productservice.AddProductr(newProduc));
        }
        [HttpPost("addproductgroups")]
        public async Task<IActionResult> AddProductGroup(AddProductGroupDto newProducGroup)
        {
            return Ok(await _productservice.AddProductGroup(newProducGroup));
        }
        [HttpPut("editproduct")]
        public async Task<IActionResult> EditProduct(EditProductDto editProduc)
        {
            return Ok(await _productservice.EditProductr(editProduc));
        }
        [HttpPut("editproductgroups")]
        public async Task<IActionResult> EditProductGroup(EditProductGroupDto editProductGroup)
        {
            return Ok(await _productservice.EditProductGroup(editProductGroup));
        }
        [HttpGet("productgroups/filter")]
        public async Task<IActionResult> GetProductGroupFilter([FromQuery] ProductGroupFilterDto filter)
        {
            return Ok(await _productservice.GetProductGroupFilter(filter));
        }
        [HttpGet("products/filter")]
        public async Task<IActionResult> GetProductFilter([FromQuery] ProductFilterDto filter)
        {
            return Ok(await _productservice.GetProductFilter(filter));
        }


        [HttpGet("getproductByid/{id}")]
        public async Task<IActionResult> GetProductrById(int id)
        {
            return Ok(await _productservice.GetProductrById(id));
        }


        [HttpGet("getproductgroupByid/{id}")]
        public async Task<IActionResult> GetProductrGroupById(int id)
        {
            return Ok(await _productservice.GetProductGroupById(id));
        }


        [HttpGet("productrbyproductgroupid/{id}")]


        public async Task<IActionResult> ProductrByProductGroupId(int id)
        {
            return Ok(await _productservice.ProductrByProductGroupId(id));
        }


    }
}