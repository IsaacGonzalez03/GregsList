using System;
using System.ComponentModel.DataAnnotations;

namespace GregsList.Models
{
  public class Car
  {
    public Car(string make, string model, int year, int price)
    {
      Make = make;
      Model = model;
      Year = year;
      Price = price;
    }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Price { get; set; }
  }
}