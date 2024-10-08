using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Interfaces.Repositories;

public interface IPedidoRepository
{
    //public Task<Pedido> CreatePedido(CreatePedidoDTO pedidoModel);
    public Task<Pedido?> GetPedidoById(int id);
    public Task<IEnumerable<Pedido>> GetAllPedidos();
}