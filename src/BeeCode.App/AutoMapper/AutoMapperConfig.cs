using AppMvcBeeCode.Models;
using AutoMapper;
using BeeCode.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeCode.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap(); ;
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap(); ;
            CreateMap<Produto, ProdutoViewModel>().ReverseMap(); ;
        }
    }
}
