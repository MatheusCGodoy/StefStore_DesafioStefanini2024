using Domain.DTOs;
using Domain.Entities;

namespace Application.Interfaces.Services;

public interface IPedidoAppService
{
    Task<PedidoDTO> CreatePedido(CreatePedidoDTO pedidoDTO);
    Task<ReadPedidoDTO?> GetPedidoById(int id);
    Task<IEnumerable<ReadPedidoDTO>> GetAllPedidos();
}
