using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Model.Entities.Mapping
{
    public class AlunoMap : EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            // Nome da Tabela
            ToTable("Aluno");
            // Chave Primária
            HasKey(t => t.idAluno);
            
            Property(t => t.matricula).IsRequired().HasColumnName("Matricula").HasMaxLength(10);
            // Propriedades
            Property(t => t.nome).IsRequired().HasMaxLength(50);
            Property(t => t.idTurma).HasColumnName("IdTurma").IsRequired();
        }
    }
}
