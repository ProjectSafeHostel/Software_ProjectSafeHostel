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
    public class DomainToApplication : Profile
    {
        public DomainToApplication() 
        {
            CreateMap<Doador, DoadorViewModel>();
            CreateMap<Doador, NovoDoadorViewModel>();
        }
    }
}
