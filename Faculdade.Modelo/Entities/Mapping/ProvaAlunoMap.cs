using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Model.Entities.Mapping
{
    public class ProvaAlunoMap : EntityTypeConfiguration<ProvaAluno>
    {
        public ProvaAlunoMap()
        {
            // Nome da Tabela
            ToTable("ProvaAluno");
            // Chave Primária
            HasKey(t => t.idProvaAluno);
            // Propriedades
            Property(t => t.idProva).IsRequired().HasColumnName("IdProva");
            Property(t => t.idAluno).IsRequired().HasColumnName("IdAluno");
            Property(t => t.notaAluno).IsRequired().HasColumnName("NotaAluno");
        }
    }
}
