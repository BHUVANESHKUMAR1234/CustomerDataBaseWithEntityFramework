using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CustomerDataBaseEF.Models
{
   

    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        
        [Column(TypeName ="nvarchar(200)")]
        [Required(ErrorMessage ="This field is required.")]
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        
        [Column(TypeName = "int")]
        public int Age { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        [DisplayName("Email ID")]
        public string EmailId { get; set; }


    }
}
