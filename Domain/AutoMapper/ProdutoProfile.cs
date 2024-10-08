using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.DTOs;
using Domain.Entities;

namespace Domain.AutoMapper;

public class ProdutoProfile : Profile
{
    public ProdutoProfile()
    {
        CreateMap<Produto, ProdutoDTO>();
        CreateMap<ProdutoDTO, Produto>();
    }
}
