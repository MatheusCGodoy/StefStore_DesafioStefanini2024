using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs;

public class ReadPedidoDTO
{
    public int Id { get; set; }
    public string NomeCliente { get; set; }
    public string EmailCliente { get; set; }
    public DateTime DataCriacao { get; set; }
    public bool Pago { get; set; }
    public decimal ValorTotal { get; set; }
    public ICollection<ReadItensPedidoDTO> ItensPedido { get; set; }
}
