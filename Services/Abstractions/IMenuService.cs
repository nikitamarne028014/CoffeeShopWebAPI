using CoffeeShopWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWebAPI.Services.Abstractions
{
    public interface IMenuService
    {
        public List<Menu> getMenus();
        public Menu getMenu(int menuId);
    }
}
