using FizyoterapiAPI.Models;
using FizyoterapiAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FizyoterapiAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TherapistProfilesController : ControllerBase
    {
        private readonly ITherapistProfileService _therapistProfileService;

        public TherapistProfilesController(ITherapistProfileService therapistProfileService)
        {
            _therapistProfileService = therapistProfileService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TherapistProfile>>> GetAll()
        {
            var profiles = await _therapistProfileService.GetAllAsync();
            return Ok(profiles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TherapistProfile>> GetById(int id)
        {
            var profile = await _therapistProfileService.GetByIdAsync(id);
            if (profile == null) return NotFound();
            return Ok(profile);
        }

        [HttpPost]
        public async Task<ActionResult<TherapistProfile>> Create(TherapistProfile profile)
        {
            var created = await _therapistProfileService.CreateAsync(profile);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TherapistProfile>> Update(int id, TherapistProfile profile)
        {
            var updated = await _therapistProfileService.UpdateAsync(id, profile);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _therapistProfileService.DeleteAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}