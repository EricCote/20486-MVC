using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogAW.Models
{

        public class Prod
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal ListPrice { get; set; }
            public string Color { get; set; }
            public string Category { get; set; }
        }

}