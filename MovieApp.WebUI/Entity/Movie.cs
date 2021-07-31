using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Entity
{
    public class Movie
    {
        public int? MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public int? GenreId { get; set; }


        public virtual Genre Genre { get; set; } // navigation property

    }
}
