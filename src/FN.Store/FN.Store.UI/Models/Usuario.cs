using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FN.Store.UI.Models
{
    [Table(nameof(Usuario))]
    public class Usuario: Entity
    {
        [Column(TypeName = "varchar")]
        [Required, StringLength(100)]
        public string Nome { get; set; }

        [Column(TypeName = "varchar")]
        [Required, StringLength(80)]
        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        [Required, StringLength(100)]
        public string Senha { get; set; }
    }
}
