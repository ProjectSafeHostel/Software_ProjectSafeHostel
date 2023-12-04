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
    public class RegistroConfiguration : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_REGISTRO");
            builder.HasKey(r => r.REGISTRO_ID);

            builder
                .Property(r => r.REGISTRO_ID)
                .UseIdentityColumn()
                .HasColumnName("REGISTRO_ID")
                .HasColumnType("int");

            builder
                .Property(r => r.DATA_REGISTRO)
                .HasColumnName("DATA_REGISTRO")
                .HasColumnType("datetime");

            builder
                .Property(r => r.TERMINACAO_FLAG)
                .HasColumnName("TERMINACAO_FLAG")
                .HasColumnType("int");

            builder
                .Property(r => r.TERMINACAO_MOTIVO)
                .HasColumnName("TERMINACAO_MOTIVO")
                .HasColumnType("varchar(max)");

            builder
                .Property(r => r.DOACAO_ID)
                .HasColumnName("DOACAO_ID")
                .HasColumnType("int");

            builder
                .HasOne(r => r.DOACAO)
                .WithMany()
                .HasForeignKey(r => r.DOACAO_ID);

            builder
                .Property(r => r.COLABORADOR_ID)
                .HasColumnName("COLABORADOR_ID")
                .HasColumnType("int");

            builder
                .HasOne(r => r.COLABORADOR)
                .WithMany()
                .HasForeignKey(r => r.COLABORADOR_ID);

            builder
                .Property(r => r.CLIENTE_ID)
                .HasColumnName("CLIENTE_ID")
                .HasColumnType("int");

            builder
                .HasOne(r => r.CLIENTE)
                .WithMany()
                .HasForeignKey(r => r.CLIENTE_ID);
        }
    }
}
