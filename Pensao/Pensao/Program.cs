using Pensao;
using System;

namespace Course
{
    class Pensao
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos serão os hospedes? ");
            int n = int.Parse(Console.ReadLine());


            //criando um vetor 
            Quarto[] vect = new Quarto[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Por favor, digite o nome do hospede: ");
                string customer = Console.ReadLine();


                Console.WriteLine("Por favor, digite o email do hospede: ");
                string email = Console.ReadLine();

                Console.WriteLine("Por favor, digite o numero do quarto do hospede(0 a 9): ");
                int room = int.Parse(Console.ReadLine());


                vect[i] = new Quarto { CustomerName = customer, Email = email, RoomNumber = room };

            }
            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < vect.Length; i++)  // Imprime todos os quartos
            {
                if (vect[i] != null)  // Verifica se o quarto foi ocupado
                {
                    Console.WriteLine($"Quarto {vect[i].RoomNumber}: {vect[i].CustomerName}, {vect[i].Email}");
                }
            }
        }
    }
}