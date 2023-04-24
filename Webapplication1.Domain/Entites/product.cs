using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapplication1.Domain.Shared;

namespace Webapplication1.Domain.Entites
{
    public class product : BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; } = string.Empty;
        public string ProductCategory { get; set; }
        public int ProductCategoryId { get; set;}
    }
}
