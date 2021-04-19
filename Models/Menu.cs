using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWebAPI.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuImage { get; set; }
        public ICollection<SubMenu> SubMenus { get; set; }
    }
}
