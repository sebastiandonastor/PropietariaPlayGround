using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropietariaPlayGround.Database;
using PropietariaPlayGround.Models;

namespace PropietariaPlayGround.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsientosController : ControllerBase
    {
        private readonly AssetsDbContext _dbContext;

        public AsientosController(AssetsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult> AddBulk(IFormFile file)
        {
            var asientos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Asiento>>(await file.ReadAsStringAsync());

            if (asientos.Count == 0)
                return BadRequest("The json file cannot be empty");

            await _dbContext.AddRangeAsync(asientos);
            await _dbContext.SaveChangesAsync();
            return Ok(asientos);
        }
    }
}