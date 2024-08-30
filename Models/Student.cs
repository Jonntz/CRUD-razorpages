using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsPremiumCRUD.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome não deve ser vazio")]
        [StringLength(80, ErrorMessage = "O nome deve conter ao máximo 80 caracteres")]
        [MinLength(3, ErrorMessage = "O nome deve conter no mínimo 3 caracteres")]
        [DisplayName("Nome Completo")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email não deve ser vazio")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        [DisplayName("Email")]
        public string Email { get; set; } = string.Empty;

        public ICollection<Premium>? Premiums { get; set; }
    }
}