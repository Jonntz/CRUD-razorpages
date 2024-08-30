using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsPremiumCRUD.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O titulo não deve ser vazio")]
        [StringLength(80, ErrorMessage = "O titulo deve conter ao máximo 80 caracteres")]
        [MinLength(3, ErrorMessage = "O titulo deve conter no mínimo 3 caracteres")]
        [DisplayName("Titulo")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        [DisplayName("Data de início")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Data de término")]
        public DateTime EndDate { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "O aluno não pode ser vazio")]
        public Guid StudentId { get; set; }

        public Student? Student { get; set; }
    }
}