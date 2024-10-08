using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private readonly StoreDbContext _context;
    public ProdutoRepository(StoreDbContext context)
    {
        _context = context;
    }

    public async Task<Produto?> GetProdutoById(int id)
    {
        return await _context.Produtos.FindAsync(id);
    }

    public async Task<IEnumerable<Produto>> GetAllProdutos()
    {
        return await _context.Produtos.ToListAsync();
    }
}
