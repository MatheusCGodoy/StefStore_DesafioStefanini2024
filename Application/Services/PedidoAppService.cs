using Application.Interfaces.Services;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services;

public class PedidoAppService: IPedidoAppService
{
    private readonly IPedidoService _pedidoService;
    public PedidoAppService(
        IPedidoService pedidoService)
    {
        _pedidoService = pedidoService;
    }

    public async Task<PedidoDTO> CreatePedido(CreatePedidoDTO pedidoDTO)
    {
        return await _pedidoService.CreatePedido(pedidoDTO);
    }

    public async Task<IEnumerable<ReadPedidoDTO>> GetAllPedidos()
    {
        return await _pedidoService.GetAllPedidos();
    }

    public async Task<ReadPedidoDTO?> GetPedidoById(int id)
    {
        return await _pedidoService.GetPedidoById(id);
    }
}
