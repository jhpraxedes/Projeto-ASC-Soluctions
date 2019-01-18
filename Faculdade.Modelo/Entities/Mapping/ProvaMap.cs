using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculdade.Model.Entities.Mapping
{
    public class ProvaMap : EntityTypeConfiguration<Prova>
    {
        public ProvaMap()
        {
            // Nome da Tabela
            ToTable("Prova");
            // Chave Primária
            HasKey(t => t.idProva);
            // Propriedades
            Property(t => t.idDisciplina).IsRequired().HasColumnName("idDisciplina");
            Property(t => t.nomeProva).IsRequired().HasColumnName("NomeProva").HasMaxLength(50);
            Property(t => t.numeroProva).IsRequired().HasColumnName("NumeroProva");
            Property(t => t.peso).IsRequired().HasColumnName("Peso");
        }
    }
}
