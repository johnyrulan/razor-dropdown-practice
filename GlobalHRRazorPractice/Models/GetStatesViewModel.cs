using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalHRRazorPractice.Models
{
    public class GetStatesViewModel
    {
        public IList<State> States { get; set; }
        public IList<City> Cities { get; set; }
    }
}