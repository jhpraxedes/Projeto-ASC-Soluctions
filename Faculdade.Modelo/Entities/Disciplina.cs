using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Model
{
    public class Disciplina
    {
        [Key]
        [Column("IdDisciplina")]
        public Int16 IdDisciplina { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Por favor, informe o nome da Disciplina.")]
        public String NomeDisciplina { get; set; }
    }
}
