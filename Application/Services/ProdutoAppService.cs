using Application.Interfaces.Services;
using Domain.DTOs;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public class ProdutoAppService : IProdutoAppService
{
    private readonly IProdutoService _produtoService;
    public ProdutoAppService(IProdutoService produtoService)
    {
        _produtoService = produtoService;
    }

    public async Task<IEnumerable<ProdutoDTO>> GetAllProdutos()
    {
        return await _produtoService.GetAllProdutos();
    }

    public Task<ProdutoDTO?> GetProdutoById(int id)
    {
        throw new NotImplementedException();
    }
}
