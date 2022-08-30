using MVC_Basic.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Basic.Models
{
    public class HomeModel
    {
        public List<Category_2119110135> ListCategory { get; set; }
        public List<Product_2119110135> ListProduct { get; set; }
        public Nullable<bool> IsAdmin { get; set; }

    }
}