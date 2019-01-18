using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Model.Entities.Mapping
{
    public class DisciplinaMap : EntityTypeConfiguration<Disciplina>
    {
        public DisciplinaMap()
        {
            // Nome da Tabela
            ToTable("Disciplina");
            // Chave Primária
            HasKey(t => t.IdDisciplina);
            // Propriedades
            Property(t => t.NomeDisciplina).IsRequired().HasColumnName("NumeroMaxAlunos").HasMaxLength(50);
        }
    }
}
