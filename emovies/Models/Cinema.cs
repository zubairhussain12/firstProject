using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace emovies.Models
{
    public class Cinema
    {
        [key]
        public int Id { get; set; }
        [Display(Name = "Cinemas Logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinemas Name")]
        public string Name { get; set; }
        [Display(Name = "Cinemas Description")]
        public string Description { get; set; }
        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
