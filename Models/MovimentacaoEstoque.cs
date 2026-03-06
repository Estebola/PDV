using System.ComponentModel.DataAnnotations;

namespace PDV.Models
{
    public class MovimentacaoEstoque
    {
        [Key]
        public int ID_Produto { get; set; }
        [Key]
        public int Lancto_Movimentacao { get; set; }
        public DateOnly Data_Movimentacao { get; set; }
        public decimal Quantidade_Movimentacao { get; set; }
        public string? Tipo_Movimentacao { get; set; } 
    }
}
