using Microsoft.AspNetCore.Mvc;

namespace TabCharacterParameter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FunctionsController : ControllerBase
    {
        [HttpGet("Search/{searchText}/{searchPattern}")]
        public IActionResult Search(
            string searchText,
            string searchPattern)
        {
            return Ok(searchText.Contains(searchPattern));
        }
    }
}
