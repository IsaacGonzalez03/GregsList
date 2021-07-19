using System.Collections.Generic;
using GregsList.Models;
using GregsList.Services;
using Microsoft.AspNetCore.Mvc;

namespace GregsList.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _cs;
    public CarsController(CarsService cs)
    {
      _cs = cs;
    }
    [HttpGet]
    public List<Car> GetCars()
    {
      return _cs.GetAll();
    }
  }
}