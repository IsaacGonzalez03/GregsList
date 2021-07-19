using System.Collections.Generic;
using GregsList.Data;
using GregsList.Models;

namespace GregsList.Services
{
  public class CarsService
  {
    public List<Car> GetAll()
    {
      return FakeDb.Cars;
    }
  }
}