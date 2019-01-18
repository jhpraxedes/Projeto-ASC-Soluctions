using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faculdade.Model;
using Faculdade.Model.ObjectValue;

namespace Faculdade.Business.Services
{
    public class ProvaAlunoService
    {
        public ProvaAlunoService() { }

        public List<MediaAluno> ObterMedia()
        {
            FaculdadeDBContext context = new FaculdadeDBContext();
            List<MediaAluno> result = new List<MediaAluno>();

            var teste = (from a in context.Aluno
                         join b in context.ProvaAluno on a.idAluno equals b.idAluno
                         select new { a.idAluno, a.matricula, a.nome, a.idTurma, b.notaAluno } into x
                         join c in context.Prova on x.idTurma equals c.idProva
                         select new {x.idAluno, x.matricula, x.nome, x.idTurma, x.notaAluno, c.peso} into w
                         join d in context.Turma on w.idTurma equals d.idTurma
                         select new { w.idAluno, w.matricula, w.nome, w.idTurma, w.notaAluno, w.peso, d.nomeTurma } into z
                         group z by new { z.idAluno, z.matricula, z.nome, z.nomeTurma } into g
                         select new MediaAluno
                         {
                             nomeTurma = g.Key.nomeTurma,
                             matricula = g.Key.matricula,
                             nomeAluno = g.Key.nome,
                             mediaAluno = g.Sum(i => i.notaAluno * i.peso) / g.Sum(j => j.peso)
                         }).
                         OrderByDescending(f => f.mediaAluno)
                         .ToList();



            return teste;
        }
    }
}
