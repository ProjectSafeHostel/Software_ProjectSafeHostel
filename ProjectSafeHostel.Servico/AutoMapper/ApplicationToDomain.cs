using AutoMapper;
using ProjectSafeHostel.Dominio.Entities;
using ProjectSafeHostel.Servico.ViewModels;
using ProjectSafeHostel.Servico.ViewModels.Cadastros;
using ProjectSafeHostel.Servico.ViewModels.Entities.Cliente;
using ProjectSafeHostel.Servico.ViewModels.Entities.Colaborador;
using ProjectSafeHostel.Servico.ViewModels.Entities.Doador;
using ProjectSafeHostel.Servico.ViewModels.Entities.Endereco;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoCategoria;
using ProjectSafeHostel.Servico.ViewModels.Entities.ProdutoFamilia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSafeHostel.Servico.AutoMapper
{
    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain() 
        {
            #region - Cadastros

            #region - Cadastrar Doador

            CreateMap<CadastrarDoadorViewModel, Doador>()
                    .ForMember(dest => dest.CPF, opt => opt.MapFrom(src => src.Doador.CPF))
                    .ForMember(dest => dest.CNPJ, opt => opt.MapFrom(src => src.Doador.CNPJ))
                    .ForMember(dest => dest.COLABORADOR_ID, opt => opt.MapFrom(src => src.Doador.COLABORADOR_ID));

                    CreateMap<CadastrarDoadorViewModel, Colaborador>()
                        .ForMember(dest => dest.NOME, opt => opt.MapFrom(src => src.Colaborador.NOME))
                        .ForMember(dest => dest.SOBRENOME, opt => opt.MapFrom(src => src.Colaborador.SOBRENOME))
                        .ForMember(dest => dest.DATA_NASCIMENTO, opt => opt.MapFrom(src => src.Colaborador.DATA_NASCIMENTO))
                        .ForMember(dest => dest.TIPO, opt => opt.MapFrom(src => src.Colaborador.TIPO))
                        .ForMember(dest => dest.CPF, opt => opt.MapFrom(src => src.Colaborador.CPF));

                    CreateMap<CadastrarDoadorViewModel, Endereco>()
                        .ForMember(dest => dest.LOGRADOURO, opt => opt.MapFrom(src => src.Endereco.LOGRADOURO))
                        .ForMember(dest => dest.NUMERO, opt => opt.MapFrom(src => src.Endereco.NUMERO))
                        .ForMember(dest => dest.COMPLEMENTO, opt => opt.MapFrom(src => src.Endereco.COMPLEMENTO))
                        .ForMember(dest => dest.CIDADE, opt => opt.MapFrom(src => src.Endereco.CIDADE))
                        .ForMember(dest => dest.CEP, opt => opt.MapFrom(src => src.Endereco.CEP))
                        .ForMember(dest => dest.COLABORADOR_ID, opt => opt.MapFrom(src => src.Endereco.COLABORADOR_ID));

                #endregion

            #endregion

            #region - Categoria

            CreateMap<ProdutoCategoriaViewModel, ProdutoCategoria>()
               .ConstructUsing(p => new ProdutoCategoria(
                   p.PRODUTO_CATEGORIA_ID,
                   p.DESCRICAO
                ));

            CreateMap<NovoProdutoCategoriaViewModel, ProdutoCategoria>()
               .ConstructUsing(p => new ProdutoCategoria(
                   p.DESCRICAO
                ));

            #endregion

            #region - Cliente

            CreateMap<ClienteViewModel, Cliente>()
               .ConstructUsing(c => new Cliente(
                   c.CLIENTE_ID,
                   c.NOME,
                   c.FOTO,
                   c.ATIVO_FLAG
                ));

            CreateMap<NovoClienteViewModel, Cliente>()
               .ConstructUsing(c => new Cliente(
                   c.NOME,
                   "",
                   0
                ));

            #endregion

            #region - Colaborador

            CreateMap<ColaboradorViewModel, Colaborador>()
               .ConstructUsing(c => new Colaborador(
                   c.COLABORADOR_ID, 
                   c.NOME, 
                   c.SOBRENOME, 
                   c.DATA_NASCIMENTO, 
                   c.TIPO, 
                   c.CPF, 
                   c.DATA_CONTRATACAO, 
                   c.DATA_TERMINACAO, 
                   c.TERMINACAO_FLAG
                ));

            CreateMap<NovoColaboradorViewModel, Colaborador>()
               .ConstructUsing(c => new Colaborador(
                   c.NOME, 
                   c.SOBRENOME, 
                   c.DATA_NASCIMENTO, 
                   c.TIPO, 
                   c.CPF, 
                   DateTime.Now, 
                   c.DATA_TERMINACAO, 
                   0
                ));

            #endregion

            #region - Doador

            CreateMap<DoadorViewModel, Doador>()
               .ConstructUsing(d => new Doador(
                   d.DOADOR_ID,
                   d.CPF,
                   d.CNPJ,
                   d.COLABORADOR_ID
                ));

            CreateMap<NovoDoadorViewModel, Doador>()
               .ConstructUsing(d => new Doador(
                   d.CPF,
                   d.CNPJ,
                   d.COLABORADOR_ID
                ));

            #endregion

            #region - Endereco

            CreateMap<EnderecoViewModel, Endereco>()
                .ConstructUsing(e => new Endereco(
                    e.ENDERECO_ID,
                    e.LOGRADOURO,
                    e.NUMERO,
                    e.COMPLEMENTO,
                    e.CIDADE,
                    e.CEP,
                    e.COLABORADOR_ID
                ));

            CreateMap<NovoEnderecoViewModel, Endereco>()
               .ConstructUsing(e => new Endereco(
                   e.LOGRADOURO, 
                   e.NUMERO, 
                   e.COMPLEMENTO, 
                   e.CIDADE, 
                   e.CEP, 
                   e.COLABORADOR_ID
                ));

            #endregion

            #region - Familia

            CreateMap<ProdutoFamiliaViewModel, ProdutoFamilia>()
                .ConstructUsing(f => new ProdutoFamilia(
                    f.PRODUTO_FAMILIA_ID,
                    f.FAMILIA,
                    f.PRODUTO_CATEGORIA_ID
                ));

            CreateMap<NovoProdutoFamiliaViewModel, ProdutoFamilia>()
                .ConstructUsing(f => new ProdutoFamilia(
                    f.FAMILIA,
                    f.PRODUTO_CATEGORIA_ID
                ));

            #endregion

            #region - Usuario

            CreateMap<UsuarioViewModel, Usuario>()
                .ConstructUsing(u => new Usuario(
                    u.usuario_id,
                    u.Login,
                    u.Senha
                ));

            CreateMap<NovoUsuarioViewModel, Usuario>()
                .ConstructUsing(u => new Usuario(
                    u.Login,
                    u.Senha
                ));

            #endregion
        }
    }
}
