using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using People.Application;

namespace People.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProspectController : ControllerBase
    {
        private ProspectApplicationService _service;

        public ProspectController(ProspectApplicationService service)
        {
            _service = service;
        }


        [HttpPost]
        public IActionResult Post()
    }
}
