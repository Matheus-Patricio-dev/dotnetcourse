using exercicios1;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("ESCREVA OS DADOS DA PESSOA: ");
            Console.Write("Nome:  ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade:  ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Nome:  ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade:  ");
            p2.Idade = int.Parse(Console.ReadLine());


            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha é: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é: " + p2.Nome);
            }




            // salario medio exc


            Pessoa p3 = new Pessoa();
            Pessoa p4 = new Pessoa();

            Console.WriteLine("Escreva o Nome e Salario!!");

            Console.Write("Nome: ");
            p3.Nome = Console.ReadLine();
            Console.Write("Salario:  ");
            p3.Salario = double.Parse(Console.ReadLine());

            Console.Write("Nome da segunda pessoa: ");
            p4.Nome = Console.ReadLine();
            Console.Write("Salario da segunda pessoa:  ");
            p4.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Calculando...");
            Thread.Sleep(3000);

            double salarioMedio = (p3.Salario + p4.Salario) / 2; 

            Console.WriteLine("salário medio: " + salarioMedio);



        }
    }
}