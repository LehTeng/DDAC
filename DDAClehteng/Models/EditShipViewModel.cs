using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDAClehteng.Models
{
    public class EditShipViewModel
    {
        public int Ship_Id { get; set; }

        [Required]
        [Display(Name = "Shipping Destination")]
        public string Ship_Place { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Depature Date")]
        public System.DateTime Ship_Depart { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Arrival Date")]
        public System.DateTime Ship_Arrived { get; set; }

        public string Status { get; set; }

        public List<SelectListItem> listItem { get; set; }
    }
}