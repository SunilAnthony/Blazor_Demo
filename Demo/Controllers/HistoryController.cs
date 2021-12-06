using Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly SessionState sessionState;

        public HistoryController(SessionState sessionState)
        {
            this.sessionState = sessionState;
        }
        [HttpPost]
        public IActionResult ListingHistory([FromForm]History history)
        {
            sessionState.MlsNumber = history.MlsNumber;
            sessionState.PropertyTaxId = history.ParcelNumber;
            return Redirect("/");
        }
    }
}
