using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs;

public class ReadItensPedidoDTO
{
    public int Id { get; set; }
    public int ProdutoId { get; set; }
    public string NomeProduto { get; set; }
    public decimal ValorUnitario { get; set; }
    public int Quantidade { get; set; }
    public int PedidoId { get; set; }
}
