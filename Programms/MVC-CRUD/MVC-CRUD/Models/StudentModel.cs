using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Models
{
    public class StudentModel
    {
        
        public int StudentId { get; set; }

        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public DateTime CreatedOn { get; set; }



    }
}