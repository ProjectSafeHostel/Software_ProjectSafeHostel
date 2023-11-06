using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dados.EntityFramework.Configurations.Entities
{
    public class DoacaoConfiguration : IEntityTypeConfiguration<Doacao>
    {
        public void Configure(EntityTypeBuilder<Doacao> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_DOACAO");
            builder.HasKey(p => p.DOACAO_ID);

            builder
                .Property(p => p.DOACAO_ID)
                .UseIdentityColumn()
                .HasColumnName("DOACAO_ID")
                .HasColumnType("int");

            builder
                .Property(p => p.DOADOR_ID)
                .HasColumnName("DOADOR_ID")
                .HasColumnType("int");

            builder
                .HasOne(p => p.DOADOR)
                .WithMany()
                .HasForeignKey(p => p.DOADOR_ID);

            builder
                .Property(p => p.PRODUTO_ID)
                .HasColumnName("PRODUTO_ID")
                .HasColumnType("int");

            builder
                .HasOne(p => p.PRODUTO)
                .WithMany()
                .HasForeignKey(p => p.PRODUTO_ID);
        }
    }
}
