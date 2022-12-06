using System.ComponentModel.DataAnnotations;

namespace APS_Final_Project.Models
{
    public class Boleto : Pagamento
    {
        [Display(Name ="Código")]
        public string? Codigo {get;set;}
        [Display(Name ="Vencimento")]
        public DateOnly Vencimento {get;set;}
    }
}