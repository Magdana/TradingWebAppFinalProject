//using AutoMapper;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.IdentityModel.Tokens;
//using TradingWebAppFinalProject.Data;
//using TradingWebAppFinalProject.Data.DTO;
//using TradingWebAppFinalProject.Migrations;

//namespace TradingWebAppFinalProject.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CountriesController : ControllerBase
//    {
//        private readonly TradingWarehouseDataBase _context;
//        private readonly IMapper _mapper;

//        public CountriesController(TradingWarehouseDataBase context, IMapper mapper)
//        {
//            _context = context;
//            _mapper = mapper;
//        }

//        // GET: api/countries
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Country>>> GetCountries()
//        {
//            if (_context.Countries == null)
//            {
//                return NotFound();
//            }
//            var countries = await _context.Countries.ToListAsync();
//            return Ok(countries.Select(c => _mapper.Map<CountryDTO>(c)).ToList());
//        }

//        // GET: api/Country/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<Country>> GetCountry(int id)
//        {
//            if (_context.Countries == null)
//            {
//                return NotFound();
//            }
//            var country = await _context.Countries.FindAsync(id);

//            if (country == null)
//            {
//                return NotFound();
//            }

//            return Ok(_mapper.Map<CountryDTO>(country));
//        }

//        // PUT: api/Country/5
//        [HttpPut("{id}")]
//        public async Task<IActionResult> UpdateCountry(int id, Country country)
//        {
//            if (id != country.Id)
//            {
//                return BadRequest();
//            }

//            _context.Countries.Add(country);

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (Exception)
//            {
//                if (!CountryExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/Country
//        [HttpPost]
//        public async Task<ActionResult<Country>> CreateCountry(Country country)
//        {
//            if (_context.Countries == null)
//            {
//                return Problem("Entity is null.");
//            }
//            _context.Countries.Add(country);
//            await _context.SaveChangesAsync();
//            return CreatedAtAction("GetCountry", new { id = country.Id }, country);
//        }


//        // DELETE: api/Country/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteCountry(int id)
//        {
//            if (_context.Countries == null)
//            {
//                return NotFound();
//            }
//            var country = await _context.Countries.FindAsync(id);
//            if (country == null)
//            {
//                return NotFound();
//            }

//            _context.Countries.Remove(country);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        private bool CountryExists(int id)
//        {
//            return (_context.Countries?.Any(e => e.Id == id)).GetValueOrDefault();
//        }
//    }
//}
