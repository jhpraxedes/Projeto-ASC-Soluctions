using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Faculdade.Model
{
    public class Prova
    {
        public Int32 idProva { get; set; }
        public String nomeProva { get; set; }
        public Int32 idDisciplina { get; set; }
        public Int16 numeroProva { get; set; }
        public Double peso { get; set; }

    }
}
