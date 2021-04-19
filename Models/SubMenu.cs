using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWebAPI.Models
{
    public class SubMenu
    {
        public int SubMenuId { get; set; }
        public string SubMenuName { get; set; }
        public string SubMenuDescription { get; set; }
        public double SubMenuPrice { get; set; }
        public string SubMenuImage { get; set; }
    }
}
