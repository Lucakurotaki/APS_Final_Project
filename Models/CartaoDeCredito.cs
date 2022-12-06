using System.ComponentModel.DataAnnotations;

namespace APS_Final_Project.Models
{
    public class CartaoDeCredito
    {
        [Display(Name ="ID")]
        public int Id {get;set;}
        [Display(Name ="Número")]
        public int Numero {get;set;}
        [Display(Name ="Validade")]
        public DateOnly Validade {get;set;}
        [Display(Name ="CVC")]
        public int Cvc {get;set;}

        public void AtivarDebito(){}
    }
}