using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TradingWebAppFinalProject.Data;
using TradingWebAppFinalProject.Data.DTO;
namespace TradingWebAppFinalProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly TradingWarehouseDataBase _context;
        private readonly IMapper _mapper;

        public CustomerController(TradingWarehouseDataBase context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerGetDTO>>> GetCustomers()
        {
            try
            {
                if (_context.Customers.Count() == 0)
                {
                    return NotFound();
                }
                var customers = await _context.Customers
                    .Include(c => c.PhoneNumbersList).Where((e) => e.PhoneNumbersList != null && e.PhoneNumbersList.IsMain)
                    .ToListAsync();
                return Ok(customers.Select(c => _mapper.Map<CustomerGetDTO>(c)).ToList());
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }

        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerGetDTO>> GetCustomer(int id)
        {
            if (_context.Customers.Count() == 0)
            {
                return NotFound();
            }
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CustomerGetDTO>(customer));
        }

        // GET: api/SortedCustomers
        [HttpGet("sorted-customers")]
        public ActionResult<IEnumerable<CustomerGetDTO>> GetSortedCustomers()
        {
            try
            {
                var customers = _context.Customers
                    .Where(c => c.Orders!=null&& c.Orders.Count <= 2)
                    .OrderByDescending(c => c.BirthDate)
                    .ToList();

                var cust = customers.Select(c => _mapper.Map<CustomerGetDTO>(c)).ToList();

                return Ok(cust);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        // GET:/api/customersFilering
        [HttpGet("filtered-customers")]
        public IActionResult GetCustomers(
                string? firstName ,
                string? lastName,
                string? city,
                string? country,
                string? personalNumber,
                DateTime? birthdate,
                int page = 1,
                int pageSize = 10)
        {
            try
            {


                IQueryable<Customer> query = _context.Customers.Include(c => c.City).Include(c => c.Country);

                if (!string.IsNullOrWhiteSpace(firstName))
                {
                    query = query.Where(c => c.FirstName.Contains(firstName));
                }

                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    query = query.Where(c => c.LastName.Contains(lastName));
                }

                if (!string.IsNullOrWhiteSpace(city))
                {
                    query = query.Where(c => c.City.Name.Contains(city));
                }

                if (!string.IsNullOrWhiteSpace(country))
                {
                    query = query.Where(c => c.Country.CountryName.Contains(country));
                }

                if (!string.IsNullOrWhiteSpace(personalNumber))
                {
                    query = query.Where(c => c.PersonalNumber.Contains(personalNumber));
                }

                if (birthdate != null)
                {
                    query = query.Where(c => c.BirthDate == birthdate);
                }

                int totalItems = query.Count();
                int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

                var customers = query
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .Select(c => _mapper.Map<CustomerGetDTO>(c))
                    .ToList();

                var result = new
                {
                    TotalItems = totalItems,
                    TotalPages = totalPages,
                    Page = page,
                    PageSize = pageSize,
                    Customers = customers
                };

                return Ok(result);
            }
            catch  (Exception ex)
            {
                return StatusCode(500,  ex.Message);
            }
        }


        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, CustomerUpdateAndRegistrartionDTO customer)
        {
            var existingCustomer = await _context.Customers.FindAsync(id);

            if (existingCustomer == null)
            {
                return NotFound("Customer not found.");
            }

            _mapper.Map(customer, existingCustomer);

            try
            {
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (DbUpdateConcurrencyException e)
            {
                if (!CustomerExists(id))
                {
                    return NotFound("Customer not found.");
                }
                else
                {
                    return BadRequest(e.Message);
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }

            
        }

        // POST: api/Customer
        [HttpPost]
        public async Task<ActionResult<CustomerUpdateAndRegistrartionDTO>> CreateCustomer(CustomerUpdateAndRegistrartionDTO customer)
        {
            if (_context.Customers == null)
            {
                return Problem("Entity is null.");
            }
            var ct = _mapper.Map<Customer>(customer);
            _context.Customers.Add(ct);

            await _context.SaveChangesAsync();
            return Ok();

        }


        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {

            if (_context.Customers.Count() == 0)
            {
                return NotFound();
            }
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool CustomerExists(int id)
        {
            return (_context.Customers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

