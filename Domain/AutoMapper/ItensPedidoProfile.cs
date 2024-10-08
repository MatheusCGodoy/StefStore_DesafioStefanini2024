using AutoMapper;
using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AutoMapper;

public class ItensPedidoProfile : Profile
{
    public ItensPedidoProfile()
    {
        CreateMap<ItensPedido, ItensPedidoDTO>();
        CreateMap<ItensPedidoDTO, ItensPedido>();
        CreateMap<ItensPedido, ReadItensPedidoDTO>()
            .ForMember(dest => dest.NomeProduto, opt => opt.MapFrom(src => src.Produto.NomeProduto))
            .ForMember(dest => dest.ValorUnitario, opt => opt.MapFrom(src => src.Produto.Valor));
    }
}
