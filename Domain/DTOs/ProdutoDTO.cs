using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs;

public class ProdutoDTO
{
    public int Id { get; set; }
    [MaxLength(20)]
    public string NomeProduto { get; set; }
    public decimal Valor { get; set; }
    //public ICollection<ItensPedidoDTO> ItensPedido { get; set; }
}
