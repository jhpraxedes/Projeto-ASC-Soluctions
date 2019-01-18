using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Model
{
    public class Turma
    {
        public Int32 idTurma { get; set; }
        public String nomeTurma { get; set; }
        public Int32 numeroMaxAlunos { get; set; }
    }
}
