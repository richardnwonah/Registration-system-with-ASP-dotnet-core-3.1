using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistrationSystem.Models
{
	public class UserClass
	{
		[Key]
		public int UserId { get; set;}

		[Required(ErrorMessage = "Enter User name")]
		[Display(Name ="User name")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Enter a password")]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Pwd { get; set; }

		[Required(ErrorMessage = "Confirm password")]
		[DataType(DataType.Password)]
		[Display(Name = "Confirm Password")]
		[Compare("Pwd")]
		public string Confirmpwd { get; set; }

		[Required(ErrorMessage = "Enter User Email")]
		[Display(Name = "User Email")]
		public string Uemail { get; set; }

		[Required(ErrorMessage = "Enter User gender")]
		[Display(Name = "User gender")]
		public string Gender { get; set; }

		[Required(ErrorMessage = "Enter User Marital status")]
		[Display(Name = "User Marital status")]
		public string Martialstatus { get; set; }


	}
}
