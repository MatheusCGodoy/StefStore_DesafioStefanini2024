using Domain.DTOs;

namespace Domain.Interfaces.Services;

public interface IPedidoService
{
    Task<PedidoDTO> CreatePedido(CreatePedidoDTO pedidoDTO);
    Task<ReadPedidoDTO?> GetPedidoById(int id);
    Task<IEnumerable<ReadPedidoDTO>> GetAllPedidos();
}