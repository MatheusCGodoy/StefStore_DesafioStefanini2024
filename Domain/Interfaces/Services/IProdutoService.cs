using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services;

public interface IProdutoService
{
    public Task<IEnumerable<ProdutoDTO>> GetAllProdutos();
    public Task<Produto?> GetProdutoById(int id);
}
