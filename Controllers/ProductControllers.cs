using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySecondWebApi.Models;

namespace MySecondWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductController(ShopContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();

        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts([FromQuery]QueryParameters queryParameters)
        {
            IQueryable<Product> products = _context.Products;

            //Implementing "Pagination" to skip and take pages

            products = products.Skip((queryParameters.Page - 1) * queryParameters.Size)
                .Take(queryParameters.Size);

            return Ok(await products.ToArrayAsync());
        }


        [HttpGet]
        [Route("id/{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet]
        [Route("sku/{SKU}")]
        public async Task<IActionResult> GetProductBySku(String SKU)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.SKU == SKU);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }


        [HttpGet("available")]
        public async Task<IActionResult> GetProductsIfAvailable()
        {
            //var products = await _context.Products
            //                    .Where(p => p.IsAvailable)
            //                    .ToListAsync();
            var products = await _context.Products.Where(p => p.IsAvailable).ToListAsync();
            if (products == null || products.Count == 0)
            {
                return NotFound();
            }
            return Ok(products);
        }



        [HttpPost]

        public async Task<IActionResult> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }


        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {

            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }


            return NoContent();
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                return BadRequest();
            }

            _context.Products.Remove(product);
            return Ok(product);
        }


        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteMultiple([FromQuery]int[] ids)
        {
            var products = new List<Product>();
            foreach (int id in ids)
            {

                var product = await _context.Products.FindAsync(id);
                if (product == null)
                {
                    return NotFound();
                }
                products.Add(product);

            }

            _context.Products.RemoveRange(products);
            await _context.SaveChangesAsync();
            return Ok(products);
        }





    }
}

  