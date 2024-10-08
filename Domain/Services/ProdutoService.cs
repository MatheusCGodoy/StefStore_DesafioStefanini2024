using AutoMapper;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _produtoRepository;
    private readonly IMapper _mapper;
    public ProdutoService(
        IMapper mapper,
        IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProdutoDTO>> GetAllProdutos()
    {
        var produtos = await _produtoRepository.GetAllProdutos();
        return _mapper.Map<List<ProdutoDTO>>(produtos);
    }

    public async Task<Produto?> GetProdutoById(int id)
    {
        return await _produtoRepository.GetProdutoById(id);
    }
}
