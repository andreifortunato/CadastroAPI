using CadastroAPI.Clients;
using CadastroAPI.Domain;
using Microsoft.AspNetCore.Mvc;


namespace CadastroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("Product")]
        public IActionResult SearchProduct([FromQuery] TypeProduct typeProduct)
        {
            var productClient = ProductClient.CreateProductClient(typeProduct);

            var products = productClient.SearchProduct();

            if (products == null)
            {
                return BadRequest();
            }

            return Ok(products);

        }

        [HttpPost("Product")]
        public IActionResult CreateProduct([FromQuery] TypeProduct typeProduct)
        {
            var productClient = ProductClient.CreateProductClient(typeProduct);

            var products = productClient.SearchProduct();

            return Ok(products);

        }

        [HttpPut("Product")]
        public IActionResult PutProduct([FromQuery] TypeProduct typeProduct)
        {
            var productClient = ProductClient.CreateProductClient(typeProduct);

            var products = productClient.SearchProduct();

            if (products != products)
            {
                return BadRequest();
            }


            return Ok( products);

        }

        [HttpDelete("Product")]
        public IActionResult DeleteProduct([FromQuery] TypeProduct typeProduct)
        {
            var productClient = ProductClient.CreateProductClient(typeProduct);

            var products = productClient.SearchProduct();

            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);

        }

        [HttpGet("Category")]
        public IActionResult SearchCategory([FromQuery] TypeProduct typeCategory)
        {
            var productClient = ProductClient.CreateProductClient(typeCategory);

            var categories = productClient.SearchCategory();

            if (categories == null)
            {
                return BadRequest();
            }

            return Ok(categories);
        }
    }
}
