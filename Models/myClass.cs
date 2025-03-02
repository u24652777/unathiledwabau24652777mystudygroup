using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace unathiledwabau24652777mystudygroup.Models
{
	public class myClass
	{
		[Display(Name = "Student Number")]//adding a decorator
		public string StudentNumber { get; set; }

		[Display(Name = "Name")]//adding a decorator
		public string Name { get; set; }

		[Display(Name = "Surname")]
		public string Surname { get; set; }

		[Display(Name ="Email Address")]
		public string Email { get; set; }
		}
	}
