using System.ComponentModel.DataAnnotations;

namespace ContactApplication.Models
{
    public class Register{
    [Key]
    public int UserRegId {get;set;}
    public string UserName {get;set;}
    public string Email {get;set;}
    public string Password{get;set;}
    public int MobileNumber{get;set;}
    }
}