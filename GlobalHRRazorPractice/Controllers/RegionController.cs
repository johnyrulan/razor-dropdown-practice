using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GlobalHRRazorPractice.Models;

namespace GlobalHRRazorPractice.Controllers
{
    public class RegionController : Controller
    {
        public IList<State> States;
        public IList<City> Cities;

        public RegionController()
        {
            States = new List<State>
            {
                new State { Abbreviation = "FL", Id = 3, Name = "Florida" },
                new State { Abbreviation = "TX", Id = 21, Name = "Texas" },
                new State { Abbreviation = "NJ", Id = 15, Name = "New Jersey" }
            };

            Cities = new List<City>
            {
                new City { Id = 4, StateId = 3, Name = "Tampa" },
                new City { Id = 5, StateId = 3, Name = "Jacksonville" },
                new City { Id = 6, StateId = 3, Name = "Miami" },

                new City { Id = 7, StateId = 21, Name = "Houston" },
                new City { Id = 8, StateId = 21, Name = "Dallas" },
                new City { Id = 9, StateId = 21, Name = "San Antonio" },

                new City { Id = 12, StateId = 15, Name = "Newark" },
                new City { Id = 13, StateId = 15, Name = "Jersey Shore" },
            };

        }

        [HttpGet]
        public ActionResult GetStates()
        {           
            return View(new GetStatesViewModel
            {
                States = States,
                Cities = null
            });
        }

        [HttpPost]
        public ActionResult GetStates(int stateId)
        {
            return View(new GetStatesViewModel
            {
                States = States,
                Cities = Cities.Where(c => c.StateId == stateId).ToList()
            });
        }
	}
}