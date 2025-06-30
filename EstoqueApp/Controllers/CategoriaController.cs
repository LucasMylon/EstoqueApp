using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstoqueApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
