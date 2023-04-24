using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapplication1.Domain.Entites;

namespace webapplication1.application.Common.Interface
{
    public interface IApplicationDbContext
    {
        DbSet<User> User { get; set; }
        DbSet<product> products { get; set; }
    }
}
