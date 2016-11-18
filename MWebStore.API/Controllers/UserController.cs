using MWebStore.Domain.Commands.UserCommands;
using MWebStore.Domain.Services;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MWebStore.API.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserApplicationService _service;
        //di
        public UserController(IUserApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/users")]
        [Authorize(Roles = "admin")]
        public Task<HttpResponseMessage> Get()
        {
            var users = _service.List();
            return CreateResponse(HttpStatusCode.OK, users);
        }

        [HttpPost]
        [Route("api/users")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new RegisterUserCommand(
                email: (string)body.email,
                password: (string)body.password,
                isAdmin: (bool)body.isAdmin
            );

            var user = _service.Register(command);

            return CreateResponse(HttpStatusCode.Created, user);
        }
    }
}