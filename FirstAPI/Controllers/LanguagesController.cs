using FirstAPI.DAL;
using FirstAPI.DTOs.Languages;
using FirstAPI.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController(ILanguageService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post(LanguageCreateDTO dto)
        {
            await _service.CreateAsync(dto);
            return Created();

        }

        [HttpPut]
        [Route("{code}")]
        public async Task<IActionResult> Update(string code, LanguageCreateDTO dto)
        {
            await _service.UpdateAsync(code, dto);
            return Ok();
        }

        [HttpDelete]
        [Route("{code}")]
        public async Task<IActionResult> Delete(string code)
        {
            return NoContent();
        }

    }
}
