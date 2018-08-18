using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FN.Store.UI.Models
{
    [Table(nameof(TipoDeProduto))]
    public class TipoDeProduto:Entity
    {
        [Required, Column(TypeName ="varchar"), StringLength(100)]
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
