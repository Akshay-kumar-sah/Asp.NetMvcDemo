using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Asp.NetMvcDemo.Models
{
    public class Employee
    {
        [Key]
        public int Id {get; set;}

        [Required]
        public string? Name {get; set;}

         [Required]
        public string?  Gender {get; set;}

            [Required]
        public string? Email {get; set;}
        [Required]
        public string ?Age{get;set;}
        


    


    }
}