using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infra.Context;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Domain.DTOs;
using AutoMapper;

namespace Infra.Repositories;

public class PedidoRepository: IPedidoRepository
{
    private readonly StoreDbContext _context;
    private readonly IMapper _mapper;
    public PedidoRepository(StoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Pedido> AddPedido(Pedido pedido)
    {
        pedido.DataCriacao = DateTime.Now;
        //pedido.Pago = false;
        _context.Pedidos.Add(pedido);
        await _context.SaveChangesAsync();

        return pedido;
    }

    public async Task<Pedido?> GetPedidoById(int id)
    {
        return await _context.Pedidos
            .Include(p => p.ItensPedido) 
            .ThenInclude(i => i.Produto) 
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Pedido>> GetAllPedidos()
    {
        return await _context.Pedidos
            .Include(p => p.ItensPedido)
            .ThenInclude(i => i.Produto)
            .ToListAsync();
    }
}
