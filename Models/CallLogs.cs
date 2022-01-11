using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactApplication.Models
{
	public class CallLogs{
[Key]
public int LogId{get;set;}
public string LogType{get;set;}

[ForeignKey("ContactId")]
public Contact Contact{get;set;}
[ForeignKey("UserId")]
public Login Login{get;set;}

    }
}