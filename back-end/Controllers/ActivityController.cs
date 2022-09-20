using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Implementation.Activity;

namespace back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityRepository _activityRepository;

        public ActivityController(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository;
        }


        [HttpGet]
        public IEnumerable<Activity> Get()
        {
            return _activityRepository.Query()                
                .OrderByDescending(x => x.Date)
                .ToList();
        }

    }
}
