using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Services;
using Domain.DTOs;

namespace StefStore.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : Controller
{
    private readonly IPedidoAppService _pedidoAppService;

    private readonly ILogger<PedidoController> _logger;
    private IMapper _mapper;

    public PedidoController(
        ILogger<PedidoController> logger, 
        IMapper mapper,
        IPedidoAppService pedidoAppService)
    {
        _pedidoAppService = pedidoAppService;
        _logger = logger;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> CreatePedido([FromBody] CreatePedidoDTO pedidoModel)
    {
        try
        {
            var result = await _pedidoAppService.CreatePedido(pedidoModel);
            if (result == null)
            {
                return BadRequest();
            }

            var pedido = _mapper.Map<Pedido>(result);

            return CreatedAtAction(nameof(CreatePedido), new { Id = pedido.Id }, pedido);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public async Task<IEnumerable<ReadPedidoDTO>> GetPedidos()
    {
        var pedidos = await _pedidoAppService.GetAllPedidos();
        return pedidos;
    }

    [HttpGet("{pedidoId}")]
    public async Task<IActionResult> GetPedidoById(int pedidoId)
    {
        var pedidoDTO = await _pedidoAppService.GetPedidoById(pedidoId);
        if (pedidoDTO != null)
        {
            return Ok(pedidoDTO);
        }
        return NotFound();
    }
}
