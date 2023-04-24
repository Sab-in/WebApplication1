using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webapplication1.application.DTOs;

namespace webapplication1.application.Common.Interface
{
    public interface IAuthentication
    {

        Task<ResponseDTO> Register(UserRegisterRequestDto model);
    }
}
