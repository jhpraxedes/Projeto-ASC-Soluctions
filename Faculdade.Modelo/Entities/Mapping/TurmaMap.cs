using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Model.Entities.Mapping
{
    public class TurmaMap : EntityTypeConfiguration<Turma>
    {

        public TurmaMap()
        { 
            // Nome da Tabela
            ToTable("Turma");
            // Chave Primária
            HasKey(t => t.idTurma);
            // Propriedades
            Property(t => t.nomeTurma).IsRequired().HasColumnName("NomeTurma").HasMaxLength(50);
            Property(t => t.numeroMaxAlunos).HasColumnName("NumeroMaxAlunos");
        }
    }
}
