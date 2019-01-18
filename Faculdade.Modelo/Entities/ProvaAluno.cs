using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Model
{
    public class ProvaAluno
    {
        public Int32 idProvaAluno { get; set; }
        public Int32 idProva { get; set; }
        public Int32 idAluno { get; set; }
        public Double notaAluno { get; set; }

    }
}
