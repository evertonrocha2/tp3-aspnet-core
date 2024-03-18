using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace tp3.Models
{
    public class Computadores
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nome da marca")]
        public string Marca { get; set; }

        [Required]
        public string Processador { get; set; }

        [Required]
        [DisplayName("Placa mãe")]
        public string PlacaMae { get; set; }

        [Required]
        public string Memoria { get; set; }

        [Required]
        public string Hd { get; set; }

        [Required]
        [DisplayName("Numero do patrimônio")]
        public int NumeroPatrimonio {  get; set; }

        [Required]
        [DisplayName("Data de compra")]
        public string DataDeCompra { get; set; }
    }
}
