using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services;

public class PedidoAppService: IPedidoAppService
{
    private readonly IPedidoService _pedidoService;
    public PedidoAppService(
        IPedidoService pedidoService)
    {
        _pedidoService = pedidoService;
    }

    //public Pedido CreatePedido(CreatePedidoModel pedidoModel)
    //{
    //    return _pedidoService.CreatePedido(pedidoModel);
    //}
}
