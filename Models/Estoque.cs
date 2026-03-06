using System.ComponentModel.DataAnnotations;

namespace PDV.Models
{
    public class Estoque
    {
        [Key]
        public int ID_Produto { get; set; }
        public decimal Quantidade_Estoque { get; set; }
    }
}
