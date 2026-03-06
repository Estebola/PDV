using System.ComponentModel.DataAnnotations;

namespace PDV.Models
{
    public class ProdutoComposicao
    {
        [Key]
        public int ID_Produto_Matriz{ get; set; }
        [Key]
        public int ID_Produto_Composicao { get; set; }
        public decimal Quantidade_Composicao { get; set; }
    }
}
