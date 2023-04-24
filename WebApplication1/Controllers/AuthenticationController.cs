using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using webapplication1.application.Common.Interface;
using webapplication1.application.DTOs;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAuthentication _authenticationManager;

        public AuthenticationController(
            UserManager<IdentityUser> userManager, IAuthentication authenticationManager)
        {
            _userManager = userManager;
            _authenticationManager = authenticationManager;
        }

        [HttpPost]
        [Route(template:"/api/authenticate/register")]
        public async Task<ResponseDTO> Register([FromBody] UserRegisterRequestDto model)
        {
            var result = await _authenticationManager.Register(model);
            return result;
        }
            
    }
}
