using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TradingWebAppFinalProject.Data;
using TradingWebAppFinalProject.Data.DTO;
using TradingWebAppFinalProject.Models;

namespace TradingWebAppFinalProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly TradingWarehouseDataBase _context;
        private readonly IMapper _mapper;

        public ProductsController(TradingWarehouseDataBase context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            if (_context.Products.Count() == 0)
            {
                return NotFound();
            }
            var products = await _context.Products.ToListAsync();
            return Ok(products.Select(p => _mapper.Map<ProductDTO>(p)).ToList());
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProducts(int id)
        {
            if (_context.Products.Count() == 0)
            {
                return NotFound();
            }
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProductDTO>(product));
        }
        
         

    // PUT: api/Product/5
    [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductDTO product)
        {
            var existingProduct = await _context.Products.FindAsync(id);

            if (existingProduct == null)
            {
                return NotFound("Product not found.");
            }

            _mapper.Map(product, existingProduct);

            try
            {
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (DbUpdateConcurrencyException e)
            {
                if (!ProductExists(id))
                {
                    return NotFound("Product not found.");
                }
                else
                {
                    return BadRequest(e.Message);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST: api/Product
        [HttpPost]
        public async Task<ActionResult<ProductDTO>> CreateProduct(ProductDTO product)
        {
            if (_context.Products == null)
            {
                return Problem("Entity is null.");
            };
           
            var pr = _mapper.Map<Product>(product);
            _context.Products.Add(pr);


            await _context.SaveChangesAsync();
            return Ok(product);

        }


        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (_context.Products.Count() == 0)
            {
                return NotFound();
            }
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Ok();
        }
            private bool ProductExists(int id)
            {
                return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
            }
        }
    }

