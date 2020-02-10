using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Data.Entities
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class Product:IEntity
	{
		// Es oblidatorio en entity que todas las tablas tengan un id numerico autoincrementable
		// por defecto se pone el nombre Id y no hay que ponerle data notation diciendo que es clave primaria
		
		public int Id { get; set; }

		[Required]
		[MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters length.")]
		public string Name { get; set; }

		/*Decorados: son modificaciones que se le ponen a los atributos, pueden cambiar solo para visualizacion 
		 o cambiar la estructura en  que se guardan en la base de datos

		 en este caso el decorado "{0:C2}",currency 2  es visual y afecta el formato en que se muestra el precio 
		 con el simbolo de unidad de precio , separacion de miles y 2 decimales
		 "ApplyFormatInEditMode = false" cuando edita el precio no aparece con el simbolo ni separadores
	*/

		[DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
		public decimal Price { get; set; }

		//decoradores display  cambia el nombre que ve el usuario
		[MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
		[Display(Name = "Image")]
		public string ImageUrl { get; set; }

		
		[Display(Name = "Last Purchase")]
		public DateTime? LastPurchase { get; set; }


		[Display(Name = "Last Sale")]
		public DateTime? LastSale { get; set; }

		[Display(Name = "Is Availabe?")]
		public bool IsAvailabe { get; set; }

		//Numerico de 2 
		[DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
		public double Stock { get; set; }

		public User User { get; set; }
	}









}
