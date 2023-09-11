using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace projectmultilingual.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IStringLocalizer<LanguageController> _localizer;
        public LanguageController(IStringLocalizer<LanguageController> localizer)
        {
            _localizer = localizer;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var guid = Guid.NewGuid();
            return Ok(_localizer["RandomGUID {0}", guid.ToString()].Value);
        }
    }
}
