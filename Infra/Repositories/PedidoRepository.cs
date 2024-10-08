using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infra.Context;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories;

public class PedidoRepository: IPedidoRepository
{
    private readonly StoreDbContext _context;
    public PedidoRepository(StoreDbContext context)
    {
        _context = context;
    }

    //public async Task<Pedido> CreatePedido(CreatePedidoDTO pedidoModel)
    //{
    //    Pedido pedido = _mapper.Map<Pedido>(pedidoModel);
    //    _context.Pedidos.Add(pedido);
    //    await _context.SaveChangesAsync();

    //    //return pedido;
    //}

    public async Task<Pedido?> GetPedidoById(int id)
    {
        return await _context.Pedidos.FindAsync(id);
    }

    public async Task<IEnumerable<Pedido>> GetAllPedidos()
    {
        return await _context.Pedidos.ToListAsync();
    }
}
