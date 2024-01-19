using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaApiCS.Models
{
    [Table("Passagem")]
    public class Passagem
    {
        [Key]
        [Column(name: "id")]
        public long Id { get; set; }

        [Required]
        [Column(name:"pacotePromo")]
        public int PacotePromo { get; set; }

        [Required]
        [Column(name: "dataViagem")]
        public DateTime DataViagem { get; set;}

        [Required]
        [Column(name:"valorTotal",TypeName = "decimal(10,2)")]
        public decimal? ValorTotal { get; set; }

        [Required]
        [Column(name: "usuario_id_fk")]
        public long Usuario_id_fk { get; set; }

        [ForeignKey("Usuario_id_fk")]
        public Usuario Usuario { get; set;}

        [Required]
        [Column(name: "destino_id_fk")]
        public long Destino_id_fk { get; set; }

        [ForeignKey("Destino_id_fk")]
        public Destino Destino { get; set; }
    }
}
