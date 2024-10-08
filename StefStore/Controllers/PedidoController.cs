using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Services;

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

    //[HttpPost]
    //public IActionResult CreatePedido(CreatePedidoModel pedidoModel)
    //{
    //    var result = _pedidoAppService.CreatePedido(pedidoModel);
    //    if (result == null)
    //    {
    //        return BadRequest();
    //    }
        
    //    var pedido = _mapper.Map<ReadPedidoModel>(result);

    //    return CreatedAtAction(nameof(CreatePedido), new { Id = pedido.Id }, pedido);
    //}

    //[HttpGet]
    //public IEnumerable<Pedido> GetPedidos()
    //{
    //    return _mapper.Map<List<ReadPedidoModel>>(_context.Pedidos.ToList());
    //}

    //[HttpGet("{pedidoId}")]
    //public IActionResult GetPedidoById(int pedidoId)
    //{
    //    Pedido pedido = _context.Pedidos.FirstOrDefault(pedido => pedido.Id == pedidoId);
    //    if (pedido != null)
    //    {
    //        ReadPedidoModel pedidoModel = _mapper.Map<ReadPedidoModel>(pedido);
    //        return Ok(pedidoModel);
    //    }
    //    return NotFound();
    //}
}
