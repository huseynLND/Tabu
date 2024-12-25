using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.DTOs.Languages
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageCreateDTO : ControllerBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string IconUrl { get; set; }
    }
}
