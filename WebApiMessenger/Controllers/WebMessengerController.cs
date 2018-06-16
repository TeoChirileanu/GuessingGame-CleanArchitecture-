using Adapters;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers {
    [Route("api/[controller]")]
    public class WebMessengerController : Controller, IMessenger {
        public void Deliver(string message) {
            DeliverOverWeb(message);
        }

        [HttpGet]
        public IActionResult DeliverOverWeb(string message) {
            return Ok(message);
        }
    }
}