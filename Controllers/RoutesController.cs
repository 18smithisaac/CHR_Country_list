using CHR_Country_list.Data;
using CHR_Country_list.Models;
using Microsoft.AspNetCore.Mvc;

namespace CHR_Country_list.Controllers 
{
    //api/routes
    [Route("api/routes")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        private readonly MockCountryList _repo = new MockCountryList();

        //api/routes/{destination}
        [HttpGet("{destination}")]
        public ActionResult <Route> GetRoute(string destination)
        {
            var routeItem = _repo.GetRoute(destination);
            return Ok(routeItem);
        }
    }
}