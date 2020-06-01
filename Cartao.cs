namespace Aula07Encapsulamento
{
    public class Cartao
    {
        public string titular { get; set; }
        public string numero { get; set; }
        public string bandeira { get; set; }
        private string token { get; set; }
        protected int cvc { get; set; }

        public string AprovarCompra(){
            return "Compra aprovada!";
        }

        private bool ValidarToken(string token){
            if(token != null && token != ""){
                return true;
            }
            return false;    
        }

        protected bool ValidarCompra(){
            return true;
        }

    }
}