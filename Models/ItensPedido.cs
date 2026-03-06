using System.ComponentModel.DataAnnotations;

namespace PDV.Models
{
    public class ItensPedido
    {
        [Key]
        public int ID_Pedido { get; set; }
        [Key]
        public DateOnly Data_Pedido { get; set; }
        [Key]
        public int ID_Itens_Pedido { get; set; }
        public int ID_Produto { get; set; }
        public decimal Quantidade_Produto { get; set; }
        public decimal? Valor_Unitario_Produto { get; set; }

    }
}
