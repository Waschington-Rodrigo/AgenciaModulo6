using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaApiCS.Models
{
    [Table("Destino")]
    public class Destino
    {
        public Destino() 
        {
            Passagens = new Collection<Passagem>();
        }

        [Key]
        [Column(name: "id")]
        public long Id { get; set; }
        
        [Required]
        [StringLength(50)]
        [Column(name: "cidade")]
        public string Cidade {  get; set; }

        [Required]
        [StringLength(50)]
        [Column(name: "estado")]
        public string Estado { get; set;}

        [Required]
        [StringLength(50)]
        [Column(name: "localDestino")]
        public string LocalDestino { get; set; }

        [Required]
        [Column(name: "valor", TypeName = "decimal(10,2)")]
        public decimal? Valor { get; set; }

        public ICollection<Passagem> Passagens { get; private set; }
        
    }
}
