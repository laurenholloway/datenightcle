using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightCleveland.Models
{
    public class DatesModel
    {
        [Key][Display(Name ="#")]
        public int DateID { get; set; }
        [Display(Name ="Date Name")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TimeOfDay { get; set; }
        public double Price { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string DateType { get; set; }


    }
}
