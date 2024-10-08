using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs;

public class CreatePedidoDTO
{
    [Required]
    [MaxLength(60)]
    public string NomeCliente { get; set; }
    [Required]
    [MaxLength(60)]
    public string EmailCliente { get; set; }
    public DateTime DataCriacao { get; set; }
    public bool Pago { get; set; }
    public ICollection<ItensPedidoDTO> ItensPedido { get; set; }
}
