using AutoMapper;
using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AutoMapper;

public class PedidoProfile : Profile
{
    public PedidoProfile()
    {
        CreateMap<CreatePedidoDTO, Pedido>();
        CreateMap<Pedido, CreatePedidoDTO>();
        CreateMap<Pedido, PedidoDTO>()
            .ForMember(dest => dest.ItensPedido, opt => opt.MapFrom(src => src.ItensPedido));

        CreateMap<PedidoDTO, Pedido>()
            .ForMember(dest => dest.ItensPedido, opt => opt.MapFrom(src => src.ItensPedido));

        CreateMap<Pedido, ReadPedidoDTO>()
            .ForMember(dest => dest.ValorTotal, opt => opt.MapFrom(src => src.ItensPedido.Sum(i => i.Quantidade * i.Produto.Valor)))
            .ForMember(dest => dest.ItensPedido, opt => opt.MapFrom(src => src.ItensPedido));

    }
}
