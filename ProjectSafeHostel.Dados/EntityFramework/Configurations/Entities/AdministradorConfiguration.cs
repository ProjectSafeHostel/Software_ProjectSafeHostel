using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectSafeHostel.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Dados.EntityFramework.Configurations.Entities
{
    public class AdministradorConfiguration : IEntityTypeConfiguration<Administrador>
    {
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            builder.ToTable("TB_SAFE_HOSTEL_ADMINISTRADOR");
            builder.HasKey(a => a.ADMINISTRADOR_ID);

            builder
                .Property(a => a.ADMINISTRADOR_ID)
                .UseIdentityColumn()
                .HasColumnName("ADMINISTRADOR_ID")
                .HasColumnType("int");

            builder
                .Property(a => a.SALARIO)
                .HasColumnName("SALARIO")
                .HasColumnType("numeric");

            builder
                .Property(a => a.COLABORADOR_ID)
                .HasColumnName("COLABORADOR_ID")
                .HasColumnType("int");

            builder
                .HasOne(a => a.COLABORADOR)
                .WithMany()
                .HasForeignKey(a => a.COLABORADOR_ID);
        }
    }
}
