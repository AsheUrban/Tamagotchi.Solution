// using Microsoft.AspNetCore.Mvc;
// using Nursery.Models;
// using System.Collections.Generic;

// namespace Nursery.Controllers
// {
//   public class TamagotchisController : Controller
//   {
//     [HttpPost("/tamagotchis/{id}")]
//     public ActionResult Feed(int id, int foodQuantity)
//     {
//       Tamagotchi foundTamagotchi = Tamagotchi.Find(id);
      
//       foundTamagotchi.Feed(foodQuantity);
//       return View(foundTamagotchi);
//     }

//     [HttpPost("/tamagotchis/{id}")]
//     public ActionResult Sleep(int id, int sleepQuantity)
//     {
//       Tamagotchi foundTamagotchi = Tamagotchi.Find(id);
//       foundTamagotchi.Sleep(sleepQuantity);
//       return View(foundTamagotchi);
//     }

//     [HttpPost("/tamagotchis/{id}")]
//     public ActionResult Play(int id, int playQuantity)
//     {
//      Tamagotchi foundTamagotchi = Tamagotchi.Find(id);
//       foundTamagotchi.Play(playQuantity);
//       return View(foundTamagotchi);
//     }

//   }
// }