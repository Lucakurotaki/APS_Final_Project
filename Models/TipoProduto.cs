using System.ComponentModel.DataAnnotations;

namespace APS_Final_Project.Models
{
    public class TipoProduto
    {
        [Display(Name ="ID")]
        public int Id {get;set;}
        [Display(Name ="Nome")]
        public string? Nome {get;set;}
        public virtual ICollection<Produto>? Produtos {get;set;}
    }
}