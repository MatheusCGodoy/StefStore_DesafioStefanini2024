using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories;

public interface IProdutoRepository
{
    public Task<Produto?> GetProdutoById(int id);
    public Task<IEnumerable<Produto>> GetAllProdutos();
}
