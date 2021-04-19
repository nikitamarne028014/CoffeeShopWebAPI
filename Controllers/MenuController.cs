using CoffeeShopWebAPI.Models;
using CoffeeShopWebAPI.Services;
using CoffeeShopWebAPI.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        // GET: api/<MenuController>
        [HttpGet]
        [ProducesResponseType(typeof(Menu), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetAllMenus()
        {
            return Ok(_menuService.getMenus());
        }

        // GET api/<MenuController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Menu), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Get(int id)
        {
            var Menu = _menuService.getMenu(id);

            if (Menu == null)
                return NotFound(new { statusCode = StatusCodes.Status404NotFound, message = "Menu " + id + " Not Found" });
            
            return Ok(Menu);
        }
    }
}
