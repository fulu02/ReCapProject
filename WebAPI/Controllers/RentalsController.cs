using Busines.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        public RentalsController(Rentals Rental)
        {
            _rentalService = RentalService;
        }

        public IRentalService RentalService { get; }
    }
    [HttpGet("getall"")]
            public IActionResult GetAll()
    {
        var result = _rentalService GetAll();
        if (result.Succes)
        {
            return Ok.(result);
        }
        return BadRequest(result);
    }

    [HttpGet("getbyid"")]
            public IActionResult GetById()
    {
        var result = _rentalService GetById(int RentalId);
        if (result.Success)
        {
            return Ok.(result);
        }
        return BadRequest(result);
    }

    [HttpGet("getcardetails"")]
            public IActionResult GetCarRentalDetails()
    {
        var result = IRentalService GetCarRentalDetails()
        if (result.Success)
        {
            return Ok.(result);
        }
        return BadRequest(result);
    }


    [HttpPost("add")]
            public IActionResult Add(Rentals Rental)
    {
        var result = _rentalService Add(Rentals Rental);
        if (result.Success)
        {
            return Ok.(result);
        }
        return BadRequest(result);
    }

    [HttpPost("update")]
            public IActionResult Update(Rentals Rental)
    {
        var result = _rentalService Update(Rentals Rental);
        if (result.Success)
        {
            return Ok.(result);
        }
        return BadRequest(result);
    }


    [HttpPost("delete")]

            public IActionResult Delete(Rentals Rental)
    {
        var result = _rentalService Delete(Rentals Rental);
        if (result.Success)
        {
            return Ok.(result);
        }
        return BadRequest(result);
    }



}

