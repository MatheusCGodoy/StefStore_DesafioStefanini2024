using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class ItensPedido
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public int PedidoId { get; set; }
    public virtual Pedido Pedido { get; set; }
    [Required]
    public int ProdutoId { get; set; }
    public virtual Produto Produto { get; set; }
    [Required]
    public int Quantidade { get; set; }

    public ItensPedido() { }

    public ItensPedido(int id, int quantidade, Produto produto, Pedido pedido)
    {
        Id = id;
        Pedido = pedido;
        PedidoId = pedido.Id;
        Produto = produto;
        ProdutoId = produto.Id;
        Quantidade = quantidade;
    }
}
