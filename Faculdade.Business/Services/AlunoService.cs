using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faculdade.Model;

namespace Faculdade.Business.Services
{
    public class AlunoService
    {
        public int Save(Aluno aluno)
        {
            using (var db = new FaculdadeDBContext())
            {
                db.Entry(aluno).State = System.Data.Entity.EntityState.Added;
                db.Aluno.Add(aluno);
                db.SaveChanges();
            }
            return aluno.idAluno;
        }

        public int Update(Aluno aluno, Int32 idAluno)
        {
            using (var db = new FaculdadeDBContext())
            {
                Aluno aluno_a_alterar = db.Aluno.First(t => t.idAluno == idAluno);
                if (aluno_a_alterar != null)
                {
                    aluno_a_alterar = aluno;
                }
                db.SaveChanges();
            }
            return aluno.idAluno;
        }
    }
}
