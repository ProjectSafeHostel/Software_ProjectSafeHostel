using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Dominio.ValueObject;
using ProjectSafeHostel.Dados.EntityFramework.Configurations.Entities;
using ProjectSafeHostel.Dados.EntityFramework.Configurations.ValueObjects;
using Microsoft.Extensions.Options;
using ProjectSafeHostel.Dados.EntityFramework.Configurations;

namespace ProjectSafeHostel.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        private readonly DatabaseSettings _databaseSettings;

        public Contexto(DbContextOptions<Contexto> options, IOptions<DatabaseSettings> databaseSettings)
            : base(options)
        {
            _databaseSettings = databaseSettings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_databaseSettings.ConnectionString);
        }


        #region - Entities

        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Doador> Doador { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        //public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ProdutoCategoria> ProdutoCategoria { get; set; }
        public DbSet<ProdutoFamilia> ProdutoFamilia { get; set; }

        #endregion

        #region - ValueObjects

        //public DbSet<Descarte> Descarte { get; set; }
        public DbSet<Doacao> Doacao { get; set; }
        //public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Registro> Registro { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdministradorConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new ColaboradorConfiguration());
            modelBuilder.ApplyConfiguration(new DoadorConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoCategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoFamiliaConfiguration());

            modelBuilder.ApplyConfiguration(new DoacaoConfiguration());
            modelBuilder.ApplyConfiguration(new RegistroConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
