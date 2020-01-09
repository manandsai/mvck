using System;  
using System.ComponentModel.DataAnnotations;  
  
namespace MvcDemo.Models  
{  
    public class People  
    {   
       public string FirstName { get; set; }
        public string LastName { get; set; }
    
       [Required(ErrorMessage = "Required")]  
       [DataType(DataType.PhoneNumber)]  
       [RegularExpression(@"^[\+\d]+(?:[\d-.\s()]*)$", ErrorMessage = "Not a valid Mobile number")]  
     public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }  
}  