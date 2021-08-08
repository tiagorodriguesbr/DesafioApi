using System.ComponentModel.DataAnnotations;

namespace cadastro.Models
{
    public class User
    {
        [Key]
        public int Id { get ; set; }

        [Required(ErrorMessage = "Este campo e obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve ter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve ter entre 3 e 60  caracteres")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo e obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve ter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve ter entre 3 e 60  caracteres")]

        public string Endereco { get; set; }
    }
}