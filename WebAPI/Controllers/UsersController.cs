using Busines.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
            public UsersController (IUserService userService)
        {
            _userService = userService;
        }
        public IUserService RentalService { get; }

        [HttpGet("getall"")]
            public IActionResult GetAll()
        {
            var result = _userService GetAll();
            if (result.Succes)
            {
                return Ok.(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid"")]
            public IActionResult GetById()
        {
            var result = _userService GetById(int Id);
            if (result.Success)
            {
                return Ok.(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add"")]
            public IActionResult Add(Users user)
        {
            var result = _userService Add(Users user);
            if (result.Success)
            {
                return Ok.(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update"")]
            public IActionResult Update(Users user)
        {
            var result = _userService Update(Users user);
            if (result.Success)
            {
                return Ok.(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete"")]
            public IActionResult Delete(Users user)
        {
            var result = _userService Delete(Users user);
            if (result.Success)
            {
                return Ok.(result);
            }
            return BadRequest(result);
        }
    }
}
