using System.ComponentModel.DataAnnotations;

namespace PDV.Models
{
    public class Produto
    {
        [Key]
        public int ID_Produto { get; set; }
        public string? Nome_Produto { get; set; }
        public string? Unidade_Produto { get; set; }    
        public string? Tipo_Produto { get; set; }
        public decimal Valor_Unitario_Produto { get; set; }

    }
}
