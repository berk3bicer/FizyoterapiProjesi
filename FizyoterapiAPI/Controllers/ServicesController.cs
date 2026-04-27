using FizyoterapiAPI.Models;
using FizyoterapiAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FizyoterapiAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServicesController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        // GET: api/services
        [HttpGet]
        public async Task<ActionResult<List<Service>>> GetAll()
        {
            var services = await _serviceService.GetAllAsync();
            return Ok(services);
        }

        // GET: api/services/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Service>> GetById(int id)
        {
            var service = await _serviceService.GetByIdAsync(id);
            if (service == null) return NotFound();
            return Ok(service);
        }

        // POST: api/services
        [HttpPost]
        public async Task<ActionResult<Service>> Create(Service service)
        {
            var created = await _serviceService.CreateAsync(service);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // PUT: api/services/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Service>> Update(int id, Service service)
        {
            var updated = await _serviceService.UpdateAsync(id, service);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        // DELETE: api/services/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _serviceService.DeleteAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}