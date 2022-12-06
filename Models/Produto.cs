using System.ComponentModel.DataAnnotations;

namespace APS_Final_Project.Models
{
    public class Produto
    {
        [Display(Name ="ID")]
        public int Id {get;set;}
        [Display(Name ="Nome")]
        public string? Nome {get; set;}
        [Display(Name ="ID de Pedido")]
        public int PedidoId {get;set;}
        public virtual Pedido? Pedido {get;set;}
        [Display(Name ="ID de Tipo")]
        public int TipoId {get;set;}
        public virtual TipoProduto? Tipo {get; set;}
        [Display(Name ="Descrição")]
        public string? Descricao {get;set;}
    }
}