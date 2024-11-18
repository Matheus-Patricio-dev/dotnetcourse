using System;

namespace exec2
{
    public class Program
    { 
        static void Main (string[] args)
        {
            Funcionario func = new Funcionario();
            /*
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retangulo: ");

            //altura
            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine());

            //largura
            Console.WriteLine("Largura");
            ret.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine($"A area do triangulo é {ret.Area()}, o perimetro é {ret.Perimetro()} e a diagonal é {ret.Diagonal()}");

            */

            ///EXERCICIO 2

            //Nome Funcionario
            Console.WriteLine("digite o nome do funcionario: ");
            func.Nome = Console.ReadLine();

            //Salario
            Console.WriteLine("digite o salario do funcionario: ");
            func.Salario = double.Parse(Console.ReadLine());


            //Imposto
            Console.WriteLine("digite o imposto que o funcionario paga: ");
            func.Imposto = double.Parse(Console.ReadLine());


            Console.WriteLine($"Nome: {func.Nome}, Salário: {func.salarioLiquido()}");

            while(true)
            {
                Console.WriteLine("Quer aumentar o salário do funcionario em porcentagem? [S/N]");
                string res = Console.ReadLine(); 

                if ( res == "N")
                {
                    break;
                } else if ( res == "S")
                {
                    Console.WriteLine("Quantos porcento será o aumento?");
                    func.Porcentagem = int.Parse(Console.ReadLine());
                    

                    //Salário atualizado
                    Console.WriteLine($"Salário atualizado: {func.AumentaSalario()}");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
    }
}