using System;
using System.ComponentModel.DataAnnotations;

namespace cadastrodealuno.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O RA é obrigatório.")]
        [StringLength(10, ErrorMessage = "O RA deve ter no máximo {1} caracteres.")]
        public string RA { get; set; }

        [Required(ErrorMessage = "O curso é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome do curso é muito longo.")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}