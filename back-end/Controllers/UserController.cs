using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Implementation.Activity;
using Repository.Implementation.User;
using System.Net;

namespace back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserReposotory _userReposotory;
        private readonly IActivityRepository _activityRepository;

        public UserController(IUserReposotory userReposotory, IActivityRepository activityRepository)
        {
            _userReposotory = userReposotory;
            _activityRepository = activityRepository;
        }

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            var data = _userReposotory.Query().ToList();

            return data;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                _userReposotory.Insert(usuario);
                _activityRepository.InsertUserActivity(usuario, TypeActivity.Insert);
            }
            catch 
            {
                BadRequest();
            }

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Update(int id, [FromBody] Usuario usuario)
        {
            try
            {
                var user = _userReposotory.Query()
                    .Where(x => x.id_usuario == id)
                    .SingleOrDefault();

                if (user == null)
                    return StatusCode(404);

                user.BirthDate = usuario.BirthDate;
                user.Country = usuario.Country;
                user.Email = usuario.Email;
                user.Telephone = usuario.Telephone;
                user.Name = usuario.Name;
                user.LastName = usuario.LastName;
                user.GetInformation = usuario.GetInformation;

                _userReposotory.Update(user);
                _activityRepository.InsertUserActivity(usuario,TypeActivity.Update);

            }
            catch
            {
                BadRequest();
            }

            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            try
            {
                var user = _userReposotory.Query()
                    .Where(x => x.id_usuario == id)
                    .SingleOrDefault();

                if (user == null)
                    return StatusCode(404);        

                _userReposotory.Delete(user);
                _activityRepository.InsertUserActivity(user, TypeActivity.Delete);

            }
            catch
            {
                BadRequest();
            }

            return StatusCode(201);
        }

    }
}
