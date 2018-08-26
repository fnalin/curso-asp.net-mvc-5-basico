using System;
using System.ComponentModel.DataAnnotations;

namespace FN.Store.UI.ViewModels.Produtos.AddEdit
{
    public class ProdutoAddEditVM
    {
        public ProdutoAddEditVM()
        {
            DataCadastro = DateTime.Now;
        }

        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public short Qtde { get; set; }

        [Display(Name ="Tipo de Produto")]
        public int TipoDeProdutoId { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
