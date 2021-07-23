using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.WebUI.Models
{
    public class Movie
    {
        public int? MovieId { get; set; }

        [Required(ErrorMessage = "film başlığı eklemelisiniz")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "film başlığı 5-50 karakter aralığında olmalıdır")]
        public string Title { get; set; }

        [Required(ErrorMessage = "film açıklaması eklemelisiniz")]
        public string Description { get; set; }

        [Required]
        public string Director { get; set; }
        public string[] Players { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public int? GenreID { get; set; }
    }
}
