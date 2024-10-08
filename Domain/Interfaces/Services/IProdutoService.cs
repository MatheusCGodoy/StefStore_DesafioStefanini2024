using Domain.DTOs;
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
}
