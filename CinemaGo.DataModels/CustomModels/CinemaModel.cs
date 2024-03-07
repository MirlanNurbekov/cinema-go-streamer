using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CinemaGo.DataModels.CustomModels
{
    public class CinemaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Cinema Name is required")]

        public string Name { get; set; }
    }
}