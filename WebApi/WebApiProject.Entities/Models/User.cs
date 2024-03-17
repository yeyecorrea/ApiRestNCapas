using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiProject.Entities.Models
{
	/// <summary>
	/// Modelo de la entidad Usuario
	/// </summary>
	 public class User
	 {
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage ="El campo {1} es obligatorio")]
		public string Name { get; set; }

	 }
}
