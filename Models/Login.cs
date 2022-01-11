using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactApplication.Models
{
	public class Login{ 
        //long int
        [Key]
    public int UserId {get;set;}
    public string Email {get;set;}
    public string Password{get;set;}
    [ForeignKey("UserRegId")]
    public Register Register {get;set;}
    }
    
    
}