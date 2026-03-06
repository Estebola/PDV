using System.ComponentModel.DataAnnotations;

namespace PDV.Models
{
    public class EstoqueDiario
    {
        [Key]
        public int ID_Produto { get; set; }
        [Key]   
        public DateOnly Data_Estoque { get; set; }
        public decimal Quantidade_Estoque { get; set; }
    }
}
