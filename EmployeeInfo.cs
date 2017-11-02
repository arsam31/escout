using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eScout.Models
{
    public class EmployeeInfo
    {



        [Required(ErrorMessage = "name is required.")]
        public string emp_name { get; set; }

       
        public string emp_email { get; set; }

        [Required(ErrorMessage = "number is required.")]
        public string emp_number { get; set; }

        
        public DateTime doj { get; set; }

        
        public DateTime dol { get; set; }

        
        public string cell_number { get; set; }


        
        public Boolean is_active { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime dob { get; set; }

        [Required(ErrorMessage = "designation id is required.")]
        public int designation_id { get; set; }
    }
}