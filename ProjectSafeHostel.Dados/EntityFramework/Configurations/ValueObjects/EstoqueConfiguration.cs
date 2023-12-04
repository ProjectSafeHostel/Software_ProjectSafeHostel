using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectSafeHostel.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dados.EntityFramework.Configurations.ValueObjects
{
    public class EstoqueConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_ESTOQUE");
            builder.HasKey(e => e.ESTOQUE_ID);

            builder
                .Property(e => e.ESTOQUE_ID)
                .UseIdentityColumn()
                .HasColumnName("ESTOQUE_ID")
                .HasColumnType("int");

            builder
                .Property(e => e.DATA_ENTRADA)
                .HasColumnName("DATA_ENTRADA")
                .HasColumnType("datetime");

            builder
                .Property(e => e.DATA_SAIDA)
                .HasColumnName("DATA_SAIDA")
                .HasColumnType("datetime");

            builder
                .Property(e => e.DATA_VENCIMENTO)
                .HasColumnName("DATA_VENCIMENTO")
                .HasColumnType("datetime");

            builder
                .Property(e => e.LOCAL_PRODUTO)
                .HasColumnName("LOCAL_PRODUTO")
                .HasColumnType("varchar(80)");

            builder
                .Property(e => e.VENCIMENTO_FLAG)
                .HasColumnName("TERMINACAO_FLAG")
                .HasColumnType("int");

            builder
                .Property(e => e.USUARIO_RETIRADA_ESTOQUE)
                .HasColumnName("USUARIO_RETIRADA_ESTOQUE")
                .HasColumnType("char(11)");

            builder
                .Property(e => e.PRODUTO_ID)
                .HasColumnName("PRODUTO_ID")
                .HasColumnType("int");

            builder
                .HasOne(e => e.PRODUTO)
                .WithMany()
                .HasForeignKey(e => e.PRODUTO_ID);
        }
    }
}
