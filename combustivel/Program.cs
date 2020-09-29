using System;

namespace combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, alcool, gasolina, diesel;

            Console.WriteLine("POSTO DE GASOLINA DA QUEBRADA");
            Console.WriteLine();

            Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
            n = int.Parse(Console.ReadLine());

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            while ( n != 4)
            {     
                if ( n == 1)
                {
                    alcool++;
                } else if ( n == 2)
                {
                    gasolina++;
                } else if ( n == 3)
                {
                    diesel++;
                } else
                {
                Console.WriteLine("Codigo fora da faixa de 1 a 4. Por favor tente novamente!");
                }

                Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine();
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);


        }
    }
}
