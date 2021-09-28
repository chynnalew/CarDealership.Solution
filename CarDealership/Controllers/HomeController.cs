using Dealership.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Dealership.Controllers
{
  public class HomeController : Controller
  {
    [Route ("/")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }
    [Route ("/addcar")]
    public ActionResult AddCar()
    {
      return View();
    }
    [Route ("/viewcar")]
    public ActionResult Create(string makeModel, string price, string miles)
    {
      Car newCar = new Car( makeModel, price, miles);
      return RedirectToAction("Index");
    }
  }
}