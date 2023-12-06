using AutoMapper;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Servico.ViewModels;
using ProjectSafeHostel.Servico.ViewModels.Buscas;
using ProjectSafeHostel.Servico.ViewModels.Entities.Cliente;
using ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador;
using ProjectSafeHostel.Servico.ViewModels.Entities.Doador;
using ProjectSafeHostel.Servico.ViewModels.Entities.Endereco;
using ProjectSafeHostel.Servico.ViewModels.Entities.Produto;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoCategoria;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoFamilia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.AutoMapper
{
    public class DomainToApplication : Profile
    {
        public DomainToApplication()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Colaborador, ColaboradorViewModel>();
            CreateMap<Doador, DoadorViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<ProdutoCategoria, ProdutoCategoriaViewModel>();
            CreateMap<ProdutoFamilia, ProdutoFamiliaViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();

            #region - Buscar Doadores

            CreateMap<Doador, BuscarDoadorViewModel>()
            .ForMember(dest => dest.DoadorId, opt => opt.MapFrom(src => src.DOADOR_ID))
            .ForMember(dest => dest.CPF, opt => opt.MapFrom(src => src.CPF))
            .ForMember(dest => dest.CNPJ, opt => opt.MapFrom(src => src.CNPJ))
            .ForMember(dest => dest.ColaboradorId, opt => opt.MapFrom(src => src.COLABORADOR.COLABORADOR_ID))
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.COLABORADOR.NOME))
            .ForMember(dest => dest.Sobrenome, opt => opt.MapFrom(src => src.COLABORADOR.SOBRENOME))
            .ForMember(dest => dest.DataNascimento, opt => opt.MapFrom(src => src.COLABORADOR.DATA_NASCIMENTO))
            .ForMember(dest => dest.Tipo, opt => opt.MapFrom(src => src.COLABORADOR.TIPO))
            .ForMember(dest => dest.ColaboradorCPF, opt => opt.MapFrom(src => src.COLABORADOR.CPF))
            .ForMember(dest => dest.DataContratacao, opt => opt.MapFrom(src => src.COLABORADOR.DATA_CONTRATACAO))
            .ForMember(dest => dest.DataTerminacao, opt => opt.MapFrom(src => src.COLABORADOR.DATA_TERMINACAO))
            .ForMember(dest => dest.TerminacaoFlag, opt => opt.MapFrom(src => src.COLABORADOR.TERMINACAO_FLAG));

            #endregion
        }
    }
}
