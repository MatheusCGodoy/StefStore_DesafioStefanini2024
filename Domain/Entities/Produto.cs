using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Produto
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    [MaxLength(60)]
    public string NomeProduto { get; set; }
    [Required]
    [Column(TypeName = "decimal(10, 2)")]
    public decimal Valor { get; set; }
    public ICollection<ItensPedido> ItensPedido { get; set; } = new List<ItensPedido>();

    public Produto() { }

    public Produto(int id, string nomeProduto, decimal valor, ICollection<ItensPedido> itensPedido)
    {
        Id = id;
        NomeProduto = nomeProduto;
        Valor = valor;
        ItensPedido = itensPedido;
    }
}
