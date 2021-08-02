using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Entity
{
    public class Cast
    {
        public int CastId { get; set; }
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Character { get; set; }
        public Movie Movie { get; set; }
        public Person Person { get; set; }
    }
}
