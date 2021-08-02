using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Entity
{
    public class Crew
    {
        public int CrewId { get; set; }
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public string Job { get; set; }
        public Movie Movie { get; set; }
        public Person Person { get; set; }
    }
}
