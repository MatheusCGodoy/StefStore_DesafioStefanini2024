using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs;

public class ItensPedidoDTO
{
    public int Id { get; set; }
    [Required]
    public int Quantidade { get; set; }
    [Required]
    public int ProdutoId { get; set; }
    public int PedidoId { get; set; }
}
