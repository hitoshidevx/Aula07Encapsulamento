using System;

namespace Aula07Encapsulamento
{
    public class Mastercard : Cartao
    {
        public int parcelas { get; set; }
        public void ComprarComDescontoMastercard(float desconto){

            cvc = 751;    

            Console.WriteLine($"Aplicado desconto de {desconto}, com o total de {parcelas} parcelas");
        }
    }
}