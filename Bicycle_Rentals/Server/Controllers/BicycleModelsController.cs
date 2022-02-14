using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bicycle_Rentals.Server.Data;
using Bicycle_Rentals.Shared.Domain;

namespace Bicycle_Rentals.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BicycleModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BicycleModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BicycleModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BicycleModel>>> GetBicycleModels()
        {
            return await _context.BicycleModels.ToListAsync();
        }

        // GET: api/BicycleModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BicycleModel>> GetBicycleModel(int id)
        {
            var bicycleModel = await _context.BicycleModels.FindAsync(id);

            if (bicycleModel == null)
            {
                return NotFound();
            }

            return bicycleModel;
        }

        // PUT: api/BicycleModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBicycleModel(int id, BicycleModel bicycleModel)
        {
            if (id != bicycleModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(bicycleModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BicycleModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BicycleModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BicycleModel>> PostBicycleModel(BicycleModel bicycleModel)
        {
            _context.BicycleModels.Add(bicycleModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBicycleModel", new { id = bicycleModel.Id }, bicycleModel);
        }

        // DELETE: api/BicycleModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBicycleModel(int id)
        {
            var bicycleModel = await _context.BicycleModels.FindAsync(id);
            if (bicycleModel == null)
            {
                return NotFound();
            }

            _context.BicycleModels.Remove(bicycleModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BicycleModelExists(int id)
        {
            return _context.BicycleModels.Any(e => e.Id == id);
        }
    }
}
