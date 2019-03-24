using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace samplemvcapp.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [DataType(DataType.Text)]
        public string MovieTitle { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset MovieReleaseDate { get; set; }
        [Display(Name = "Movie Length")]
        public float MovieLength { get; set; }
        [Display(Name = "Main Genre")]
        public Genre MainMovieGenre { get; set; }
        [Display(Name = "Secondary Genre")]
        public Genre? SecondMovieGenre { get; set; }
        [Display(Name = "Third Genre")]
        public Genre? ThirdMovieGenre { get; set; }
    }
}
