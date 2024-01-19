using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaApiCS.Models
{


    [Table("Hospedagem")]
    public class Hospedagem
    {
        public Hospedagem()
        {
            Reservas = new Collection<Reserva>();
        }

        [Key]
        [Column(name: "id")]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(name: "nome")]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        [Column(name: "cidade")]
        public string Cidade { get; set; }

        [Required]
        [StringLength(50)]
        [Column(name: "estado")]
        public string Estado { get; set; }

        [Required]
        [StringLength(50)]
        [Column(name: "endereco")]
        public string Endereco { get; set; }

        [Required]
        [StringLength(50)]
        [Column(name: "tipo")]
        public string Tipo { get; set; }

        [Required]
        [StringLength(50)]
        [Column(name: "telefone")]
        public string Telefone { get; set; }

        [Required]
        [Column(name: "valorDiaria", TypeName = "decimal(10,2)")]
        public decimal? ValorDiaria { get; set; }

        public ICollection<Reserva> Reservas { get; private set; }
    }
}
