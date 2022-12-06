namespace APS_Final_Project.Models
{
    public class Pagamento
    {
        public int Id {get;set;}
        public float Valor {get;set;}
        public DateOnly DataEmissao {get;set;}

        public int PedidoId {get;set;}
        public Pedido? Pedido {get;set;}
        public void Confirma(){}
    }
}