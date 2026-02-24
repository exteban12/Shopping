using System.ComponentModel.DataAnnotations;

namespace Shopping.Date.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo {1}:caracteres ")]
        [Required(ErrorMessage = "el campo {0} es obligatorio.")]//requisito si o si
        public string Name { get; set; }


    }
}
