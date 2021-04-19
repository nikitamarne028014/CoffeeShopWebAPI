using CoffeeShopWebAPI.Data;
using CoffeeShopWebAPI.Models;
using CoffeeShopWebAPI.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWebAPI.Services
{
    public class MenuService : IMenuService
    {
        private readonly CoffeeShopDBContext _dBContext;

        public MenuService(CoffeeShopDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public Menu getMenu(int menuId)
        {
            return _dBContext.Menus.Include("SubMenus").FirstOrDefault(p => p.MenuId == menuId);
        }

        public List<Menu> getMenus()
        {
            List<Menu> menus = new List<Menu>();
            var MenuFromDB = _dBContext.Menus.Include("SubMenus");
            
            foreach(var menu in MenuFromDB)
            {
                menus.Add(menu);
            }

            return menus;
        }
    }
}
