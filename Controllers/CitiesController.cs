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
//    public class CitiesController : ControllerBase
//    {
//        private readonly TradingWarehouseDataBase _context;
//        private readonly IMapper _mapper;

//        public CitiesController(TradingWarehouseDataBase context, IMapper mapper)
//        {
//            _context = context;
//            _mapper = mapper;
//        }

//        // GET: api/Cities
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<City>>> GetCitiess()
//        {
//            if (_context.Cities == null)
//            {
//                return NotFound();
//            }
//            var cities = await _context.Cities.ToListAsync();
//            return Ok(cities.Select(c => _mapper.Map<CityDTO>(c)).ToList());
//        }

//        // GET: api/Cities/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<City>> GetCity(int id)
//        {
//            if (_context.Cities == null)
//            {
//                return NotFound();
//            }
//            var city = await _context.Cities.FindAsync(id);

//            if (city == null)
//            {
//                return NotFound();
//            }

//            return Ok(_mapper.Map<CityDTO>(city));
//        }

//        // PUT: api/City/5
//        [HttpPut("{id}")]
//        public async Task<IActionResult> UpdateCity(int id, City city)
//        {
//            if (id != city.Id)
//            {
//                return BadRequest();
//            }

//            _context.Cities.Add(city);

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (Exception)
//            {
//                if (!CityExists(id))
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

//        // POST: api/City
//        [HttpPost]
//        public async Task<ActionResult<City>> CreateCity(CityDTO city)
//        {
//            if (_context.Cities == null)
//            {
//                return Problem("Entity is null.");
//            }
//            var ct = _mapper.Map < City > (city);
//            _context.Cities.Add(ct);
//            await _context.SaveChangesAsync();
//            return CreatedAtAction("GetCity", ct);
          
//        }

//        // DELETE: api/City/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteCity(int id)
//        {
//            if (_context.Cities == null)
//            {
//                return NotFound();
//            }
//            var city = await _context.Cities.FindAsync(id);
//            if (city == null)
//            {
//                return NotFound();
//            }

//            _context.Cities.Remove(city);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        private bool CityExists(int id)
//        {
//            return (_context.Cities?.Any(e => e.Id == id)).GetValueOrDefault();
//        }
//    }
//}
