using backend.Data;
using backend.Models;
using backend.Repositories;
using backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/establishments")]
    [ApiController]
    public class EstablishmentController : ControllerBase
    {
        private readonly AppDbContext _context;

        private readonly EstablishmentService establishmentService;
        public EstablishmentController(AppDbContext context) 
        {
            _context = context;
            this.establishmentService = new(new EstablishmentRepository(context));
        }

        [HttpGet("/getAll")]
        [ProducesResponseType(200, Type=typeof(IEnumerable<Establishment>))]
        public IActionResult GetAll()
        {
            var establishments = establishmentService.GetAll();

            return Ok(establishments);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Establishment))]
        public IActionResult GetById([FromRoute]int id) 
        { 
            var establishment = establishmentService.GetById(id);

            if(establishment == null)
            {
                return NotFound();
            }

            return Ok(establishment);
        }
    }
}
