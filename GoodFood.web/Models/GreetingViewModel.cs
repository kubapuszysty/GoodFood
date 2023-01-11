using GoodFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodFood.web.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}