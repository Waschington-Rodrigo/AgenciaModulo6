using AgenciaApiCS.Models;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaApiCS
{
    [Table("Usuario")]
    public class Usuario
    {
        public Usuario()
        {
        Reservas = new Collection<Reserva>();
            Passagens = new Collection<Passagem>();
            
        }
        [Key]
        [Column(name: "id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [StringLength(255)]
        [Column(name: "nome")]
        public string Nome { get; set; }

        [Required]
        [StringLength(255)]
        [Column(name: "cpf")]
        public string Cpf { get; set; }

        [Required]
        [Column(name:"data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(255)]
        [Column(name: "email")]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        [Column(name: "telefone")]
        public string Telefone { get; set; }

        [Required]
        [StringLength(255)]
        [Column(name: "endereco")]
        public string Endereco { get; set; }

        [Required]
        [StringLength(255)]
        [Column(name: "estado")]
        public string Estado { get; set; }

        [Required]
        [StringLength(255)]
        [Column(name: "cidade")]
        public string Cidade { get; set; }

        public ICollection<Reserva> Reservas { get; private set; }
        public ICollection<Passagem> Passagens { get; private set; }
    }
}
