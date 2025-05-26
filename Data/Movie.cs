﻿using System.ComponentModel.DataAnnotations;

namespace MediaRatingApp.Data
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        [Range(0, 10)]
        public float Rate { get; set; }

        [Url]
        public string? ImageUrl { get; set; }
    }
}
