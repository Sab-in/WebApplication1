using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace webapplication1.application.Common.Interface
{
    /*
     we have to use Public cause we need multiple assembly*/
    public interface IDateTime
    {
        DateTime Now { get; }
    }
}
