using Microsoft.AspNetCore.Mvc;
using Nursery.Models;
using System.Collections.Generic;

namespace Nursery.Controllers
{
  public class TamagotchisController : Controller
  {
    [HttpPost("/tamagotchis/{id}")]
    public ActionResult Feed(int foodQuantity)
    {
      Tamagotchi myTamagotchi = new Tamagotchi(foodQuantity);
      return RedirectToAction("Index");
    }

    [HttpPost("/tamagotchis/{id}")]
    public ActionResult Sleep(int sleepQuantity)
    {
      Tamagotchi myTamagotchi = new Tamagotchi(sleepQuantity);
      return RedirectToAction("Index");
    }

    [HttpPost("/tamagotchis/{id}")]
    public ActionResult Play(int playQuantity)
    {
      Tamagotchi myTamagotchi = new Tamagotchi(playQuantity);
      return RedirectToAction("Index");
    }

  }
}