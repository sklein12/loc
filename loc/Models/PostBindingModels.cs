using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace loc.Models
{
    public class NewPostBindingModel 
    {


        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }

        [Required]
        [Display(Name = "Location")]
        public LocationBindingModel Location { get; set; }




    }

    public class LocationBindingModel
    {
        [Required]
        [Display(Name = "Latitidue")]
        public double Latitude { get; set; }
        [Required]
        [Display(Name = "Longitude")]
        public double Longitude { get; set; }

    }
}
