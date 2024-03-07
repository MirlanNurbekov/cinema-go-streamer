using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaGo.DataModels.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }
        public int? CategoryId { get; set; }
        public string ImageUrl { get; set; }
        public int? Stock { get; set; }
        public int? CinemaId { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public int? Hour { get; set; }
        public int? Minute { get; set; }
        public string TrailerUrl { get; set; }
        public string Language { get; set; }
        public string ReleaseDate { get; set; }
        public string RunningTime { get; set; }
        public string Status { get; set; }
    }
}