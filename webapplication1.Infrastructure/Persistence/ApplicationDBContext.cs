using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webapplication1.application.Common.Interface;
using Webapplication1.Domain.Entites;

namespace webapplication1.Infrastructure.Persistence
{
    /* public class ApplicationDBContext : DbContext, IApplicationDbContext*/
/*
 we replace above : inheritance of DbContext {i.e we used only Entity frame work core 7.0.3} but we are using 
 */
    public class ApplicationDBContext : IdentityDbContext<IdentityUser, IdentityRole, string>, IApplicationDbContext
    {
        private readonly IDateTime _dateTime;
        //Contructor
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options, IDateTime dateTime)
            :base(options)

        {
            _dateTime = dateTime;
        }

        public DbSet<User> User { get; set; }
        public DbSet<product> products { get; set; }
    }
}
