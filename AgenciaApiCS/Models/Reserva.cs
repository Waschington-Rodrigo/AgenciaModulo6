using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaApiCS.Models
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        [Column(name: "id")]
        public long Id { get; set; }

        [Required]
        [Column(name: "qtdDias")]
        public int QtdDias { get; set; }

        [Required]
        [Column(name: "dataReserva")]
        public DateTime DataReserva { get; set; }

        [Required]
        [Column(name: "pacotePromo")]
        public int PacotePromo { get; set; }

        [Required]
        [Column(name: "valorTotal", TypeName = "decimal(10,2)")]
        public decimal? ValorTotal { get; set; }

        [Required]
        [Column(name: "usuario_id_fk")]
        public long Usuario_id_fk { get; set; }

        [ForeignKey("Usuario_id_fk")]
        public Usuario Usuario { get; set; }

        [Required]
        [Column(name: "hospedagem_id_fk")]
        public long Hospedagem_id_fk { get; set; }

        [ForeignKey("Hospedagem_id_fk")]
        public Hospedagem Hospedagem { get; set; }

    }
}
