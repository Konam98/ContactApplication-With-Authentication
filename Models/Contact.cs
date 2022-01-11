using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactApplication.Models
{
	public class Contact
	{
        [Key]
		public int ContactId {get; set; }

		[Required]
		[Display(Name = "First Name")]
    
		public string FirstName {get; set;}

		[Required]
		[Display(Name = "Last Name")]
		public string LastName {get; set; }
        [Required]
		[Display(Name = "ContactNumber")]
		public int ContactNumber {get; set; }

		
		[Display(Name = "Email")]
		public string EmailAddress {get; set; }
        
        [Display(Name ="Address")]
        public string Address{get;set;}
        [ForeignKey("UserId")]
        public Login Login {get;set;}
		
	}
}