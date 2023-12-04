using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectSafeHostel.Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dados.EntityFramework.Configurations.ValueObjects
{
    public class DescarteConfiguration : IEntityTypeConfiguration<Descarte>
    {
        public void Configure(EntityTypeBuilder<Descarte> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_DESCARTE");
            builder.HasKey(d => d.DESCARTE_ID);

            builder
                .Property(d => d.DESCARTE_ID)
                .UseIdentityColumn()
                .HasColumnName("DESCARTE_ID")
                .HasColumnType("int");

            builder
                .Property(d => d.MOTIVO_DESCARTE)
                .HasColumnName("MOTIVO_DESCARTE")
                .HasColumnType("varchar(50)");

            builder
                .Property(d => d.PRODUTO_ID)
                .HasColumnName("PRODUTO_ID")
                .HasColumnType("int");

            builder
                .HasOne(d => d.PRODUTO)
                .WithMany()
                .HasForeignKey(d => d.PRODUTO_ID);

            builder
                .Property(d => d.FUNCIONARIO_ID)
                .HasColumnName("FUNCIONARIO_ID")
                .HasColumnType("int");

            builder
                .HasOne(d => d.FUNCIONARIO)
                .WithMany()
                .HasForeignKey(d => d.FUNCIONARIO_ID);
        }
    }
}
