using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webapplication1.application.Common.Interface;
using webapplication1.application.DTOs;

namespace webapplication1.Infrastructure.Services
{
    public class AuthenticationService : IAuthentication
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AuthenticationService (UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ResponseDTO> Register(UserRegisterRequestDto model)
        {
            var userExists = await _userManager.FindByNameAsync(model.UserName);

            if (userExists != null)
                return new ResponseDTO
                {
                    Status = "Error",
                    Message = "User Already Exists."
                };

            IdentityUser user = new()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.UserName
            };

            var result = await _userManager.CreateAsync(user,model.Password);
            if (!result.Succeeded)
                return
                    new ResponseDTO
                    {
                        Status = "Error",
                        Message = "User Creation Failed, Please Check your user detail."

                    };
            return new ResponseDTO
            {
                Status = "Success",
                Message = "User Created Successfully."
            };
            

        }

    }
}
