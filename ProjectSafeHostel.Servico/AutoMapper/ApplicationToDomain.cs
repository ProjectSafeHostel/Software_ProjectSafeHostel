using AutoMapper;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Servico.ViewModels.Entities.Doador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Application.AutoMapper
{
    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain() 
        {
            #region - Doador

            CreateMap<DoadorViewModel, Doador>()
               .ConstructUsing(d => new Doador(d.DOADOR_ID, d.CPF, d.CNPJ, d.ENDERECO_ID, d.COLABORADOR_ID, d.ENDERECO, d.COLABORADOR));

            CreateMap<NovoDoadorViewModel, Doador>()
               .ConstructUsing(d => new Doador(d.CPF, d.CNPJ, d.ENDERECO_ID, d.COLABORADOR_ID, d.ENDERECO, d.COLABORADOR));

            #endregion
        }
    }
}
