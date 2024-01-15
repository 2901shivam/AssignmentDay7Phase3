using AssignmentDay7.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentDay7.Controllers
{
    public class PlayerController : Controller
    {

        List<Player> player = new List<Player>()
        {
            new Player(){PId=1,Pname="Rohit Sharma",PCountry="India",PType="Captain Batsman"},
              new Player(){PId=2,Pname="Virat Kohli",PCountry="India",PType="Batsman"},
                new Player(){PId=3,Pname="Shoib Akhtar",PCountry="Pakistan",PType="Fats Baowler"},
                  new Player(){PId=4,Pname="Yuvraj Singh",PCountry="India",PType="AllRounder"},
                    new Player(){PId=5,Pname="David Warner",PCountry="Austrelia",PType="Left hand Batsman"},
                      new Player(){PId=6,Pname="Surya",PCountry="India",PType="Right-Hand Batsman"},

        };
        public IActionResult Index()
        {
            return View(player);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]

        public IActionResult Create(Player pl)
        {
            if (ModelState.IsValid)
            {
                player.Add(pl);
                return RedirectToAction("Index");
            }
            return View(pl);
        }
    }
}
