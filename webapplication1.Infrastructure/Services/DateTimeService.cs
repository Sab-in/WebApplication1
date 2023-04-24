using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webapplication1.application.Common.Interface;

namespace webapplication1.Infrastructure.Services
{
    public class DateTimeService :IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
