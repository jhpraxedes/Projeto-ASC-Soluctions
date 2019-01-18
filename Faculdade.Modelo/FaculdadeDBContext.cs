using System.Data.Entity;
using Faculdade.Model;
using System.Configuration;
using Faculdade.Model.Entities.Mapping;

namespace Faculdade.Model
{
    public class FaculdadeDBContext : DbContext
    {
        public FaculdadeDBContext() : base("FaculdadeConn")
        {
            Database.SetInitializer<FaculdadeDBContext>(null);
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Prova> Prova { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<ProvaAluno> ProvaAluno { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlunoMap());
            modelBuilder.Configurations.Add(new TurmaMap());
            modelBuilder.Configurations.Add(new DisciplinaMap());
            modelBuilder.Configurations.Add(new ProvaMap());
            modelBuilder.Configurations.Add(new ProvaAlunoMap());
        }
    }
}
