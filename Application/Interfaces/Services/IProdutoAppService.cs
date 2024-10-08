using Domain.DTOs;

namespace Application.Interfaces.Services;

public interface IProdutoAppService
{
    public Task<ProdutoDTO?> GetProdutoById(int id);
    public Task<IEnumerable<ProdutoDTO>> GetAllProdutos();
}