using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Pedido
{
    [Key]
    [Required]
    public int Id { get; set;}
    [MaxLength(60)]
    public string NomeCliente { get; set; }
    [MaxLength(60)]
    public string EmailCliente { get; set; }
    [Required]
    public DateTime DataCriacao { get; set; }
    [Required]
    public bool Pago { get; set; }
    public ICollection<ItensPedido> ItensPedido { get; set; }

    public Pedido() { }

    public Pedido(int id, string nomeCliente, string emailCliente, DateTime dataCriacao, bool pago, ICollection<ItensPedido> itensPedido)
    {
        Id = id;
        NomeCliente = nomeCliente;
        EmailCliente = emailCliente;
        DataCriacao = dataCriacao;
        Pago = pago;
        ItensPedido = itensPedido;
    }
}
