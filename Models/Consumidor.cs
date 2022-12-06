using System.ComponentModel.DataAnnotations;

namespace APS_Final_Project.Models
{
    public class Consumidor
    {
        [Display(Name ="ID")]
        public int Id {get; set;}
        [Display(Name ="Nome")]
        public string? Nome {get; set;}
        [Display(Name ="CPF")]
        public string? Cpf {get; set;}
        [Display(Name ="Endereço")]
        public string? Endereco {get; set;}
        [Display(Name ="E-mail")]
        public string? Email {get; set;}
        [Display(Name ="Nascimento")]
        public DateOnly Nascimento {get; set;}
        [Display(Name ="VIP")]
        public bool Vip {get; set;}
        public virtual ICollection<Pedido>? Pedidos {get;set;}
    }
}