using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Faculdade.Model
{
    public class Aluno
    {
        public Int32 idAluno { get; set; }
        public String matricula { get; set; }
        public String nome { get; set; }
        public int? idTurma { get; set; }
    }
}
