using System.ComponentModel.DataAnnotations;

namespace Shopping.Date.Entities
{
    public class Category
    {

        public int Id { get; set; }

        [Display(Name = "Categoria")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo {1}:caracteres ")]
        [Required(ErrorMessage = "el campo {0} es obligatorio.")]//requisito si o si
        public string Name { get; set; }
    }
}
