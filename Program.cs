using System;

namespace Aula07Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Mastercard card = new Mastercard();

            card.titular = "Hitoshi";
            card.parcelas = 23;
            card.ComprarComDescontoMastercard(37f);

        }
    }
}
