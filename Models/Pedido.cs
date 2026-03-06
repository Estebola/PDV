using System.ComponentModel.DataAnnotations;

namespace PDV.Models
{
    public class Pedido
    {
        [Key]
        public int ID_Pedido { get; set; }
        [Key]
        public DateOnly Data_Pedido { get; set; }
        public string? Nome_Cliente { get; set; }
        public string? Carro_Cliente { get; set; }
        public string? Endereco_Cliente { get; set; }
        public TimeOnly Hora_Pedido { get; set; }
        public decimal Valor_Total_Pedido { get; set; }


    }
}
