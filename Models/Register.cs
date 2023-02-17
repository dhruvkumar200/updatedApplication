using System;
using System.ComponentModel.DataAnnotations;



    public class Register {  
    
    [Required]
    [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
    public string? FirstName {  
        get;  
        set;  
    }
    [Required]
    public string? LastName {  
        get;  
        set;  
    }  
    public int UserId {  
        get;  
        set;  
    }  
   
    public string? Password {  
        get;  
        set;  
    }  
   [Compare(nameof(Password), ErrorMessage = "confirm password and password not match")]
      public string? confirmPassword {  
        get;  
        set;  
    }  
    [EmailAddress (ErrorMessage="please enter valid email")]
    public string? Email {  
        get;  
        set;  
    }  

    public string? Contact {  
        get;  
        set;  
    }

  
} 


