using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Implementation.CountriesCodes;

namespace back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {

        [HttpGet]
        public Country[] Get()
        {
            return Countries.getCountries();
        }
    }
}
