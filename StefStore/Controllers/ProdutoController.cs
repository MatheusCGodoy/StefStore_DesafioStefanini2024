using Application.Interfaces.Services; 
using AutoMapper;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : Controller
{
    private readonly IProdutoAppService _produtoAppService;

    private readonly ILogger<ProdutoController> _logger;
    private IMapper _mapper;

    public ProdutoController(
        ILogger<ProdutoController> logger,
        IMapper mapper,
        IProdutoAppService produtoAppService)
    {
        _produtoAppService = produtoAppService;
        _logger = logger;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<ProdutoDTO>> GetProdutos()
    {
        return await _produtoAppService.GetAllProdutos();
    }
}
