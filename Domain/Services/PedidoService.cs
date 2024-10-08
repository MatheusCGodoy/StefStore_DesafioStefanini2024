using AutoMapper;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class PedidoService: IPedidoService
{
    private readonly IProdutoService _produtoService;
    private readonly IPedidoRepository _pedidoRepository;
    private readonly IMapper _mapper;
    
    public PedidoService(
        IProdutoService produtoService,
        IPedidoRepository pedidoRepository,
        IMapper mapper)
    {
        _produtoService = produtoService;
        _pedidoRepository = pedidoRepository;
        _mapper = mapper;
    }

    public async Task<PedidoDTO> CreatePedido(CreatePedidoDTO pedidoDTO)
    {
        Pedido pedido = _mapper.Map<Pedido>(pedidoDTO);

        foreach (var itemDto in pedidoDTO.ItensPedido)
        {
            var produto = await _produtoService.GetProdutoById(itemDto.ProdutoId);
            if (produto == null)
            {
                throw new Exception("Produto não encontrado");
            }
        }
        
        var pedidoInserido = await _pedidoRepository.AddPedido(pedido);
        if (pedidoInserido == null)
        {
            throw new Exception("Erro ao criar pedido");
        }

        return _mapper.Map<PedidoDTO>(pedidoInserido);
    }

    public async Task<ReadPedidoDTO?> GetPedidoById(int id)
    {
        var pedido = await _pedidoRepository.GetPedidoById(id);
        if (pedido == null)
        {
            return null;
        }
        var readPedido = _mapper.Map<ReadPedidoDTO>(pedido);
        readPedido.ValorTotal = pedido.ItensPedido.Sum(i => i.Quantidade * i.Produto.Valor);
        return readPedido;
    }

    public async Task<IEnumerable<ReadPedidoDTO>> GetAllPedidos()
    {
        var pedidos = await _pedidoRepository.GetAllPedidos();
        return _mapper.Map<List<ReadPedidoDTO>>(pedidos);
    }
}
