using Microsoft.AspNetCore.Mvc;
using TDD_WebApi_Example.Interfaces;

namespace TDD_WebApi_Example.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_service.GetById(id));
        }
    }
}
