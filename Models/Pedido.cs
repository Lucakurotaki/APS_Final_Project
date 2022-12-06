using System.ComponentModel.DataAnnotations;

namespace APS_Final_Project.Models
{
    public class Pedido
    {
        [Display(Name ="ID")]
        public int Id {get; set;}
        [Display(Name ="Data")]
        public DateTime Data {get; set;}
        public virtual ICollection<Produto>? Itens {get; set;}
        [Display(Name ="ID de Consumidor")]
        public int ConsumidorId {get;set;}
        public Consumidor? Consumidor {get;set;}

        public void incluiProduto(){}
        public void excluiProduto(){}
    }
}