using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapplication1.Domain.Shared;

namespace Webapplication1.Domain.Entites
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phonenum {get; set; }
    }
}
