using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDAClehteng.Models
{
    public class ShipViewModel
    {
        [Required]
        [Display(Name = "Shipping Destination")]
        public string Ship_Place { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Depature Date")]
        public string Ship_Depart { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Arrival Date")]
        public string Ship_Arrived { get; set; }

    }
}
