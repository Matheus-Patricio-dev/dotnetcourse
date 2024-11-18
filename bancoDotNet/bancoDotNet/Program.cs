using System;
using System.Security.Cryptography.X509Certificates;

namespace bancoDotNet
{
    public class Program
    {
        public static void Main(string[] args) 
        {

            Usuario usuario;
            
            //pegando dados do usuario
            Console.WriteLine("Bem vindo ao BancoDotNet");
            Console.WriteLine("Digite qual é o Nome do titular da conta: ");
            string tittle = Console.ReadLine();
            Console.WriteLine("Digite o Numero da conta: ");
            int numAcc = int.Parse(Console.ReadLine());

            //verificando se há deposito inicial
            Console.WriteLine("Gostaria de fazer um deposito inicial? [s/n] ");
            char resp = char.Parse(Console.ReadLine());


            if (resp == 's' || resp == 'S') 
            {
        
                Console.WriteLine("Digite o valor do deposito: ");
                double initialValue = double.Parse(Console.ReadLine());
                usuario = new Usuario(tittle, numAcc, initialValue);

            }
            else
            {
                usuario = new Usuario(tittle, numAcc);
            }

            Console.Write("Digite um valor para deposito: ");
            double offBalance = double.Parse(Console.ReadLine());
            usuario.AddBalance(offBalance);

            Console.WriteLine(usuario);

            Console.Write("Digite um valor para Saque: ");
            offBalance = double.Parse(Console.ReadLine());
            usuario.MinusBalance(offBalance);

            Console.WriteLine(usuario);

        }
    }
}