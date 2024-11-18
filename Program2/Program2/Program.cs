using System;
using System.Security.Cryptography.X509Certificates;

namespace Course;
    public class Program { 
    static void Main(string[] args)
    {
        Produto p = new Produto();
       

        Console.WriteLine("Digite os dados do Produto: ");
        Console.Write("Nome do Produto: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preco: ");
        p.Preco = double.Parse(Console.ReadLine());
        Console.Write("Quantidade no estoque: ");
        p.Qnt = int.Parse(Console.ReadLine());


        //retorna dados com console.writeline

        Console.WriteLine("Dados: " + p);

        while (true)
        {
            Console.WriteLine("Voce quer adicionar mais do produto ao estoque? sim=[1], não=[2]; Caso queira parar tecle qualquer coisa fora os numeros citados ");
            int res = int.Parse(Console.ReadLine());

            if (res != 1 && res != 2) break;

            if (res == 1)
            {
                Console.Write("Digite a quantidade que deverá ser adicionada ao estoque");
                int qnt = int.Parse(Console.ReadLine());
                p.AddProduto(qnt);
                Console.WriteLine("DADOS ATUALIZADOS: " + p);
            }
            else if (res == 2)
            {
                Console.Write("Digite a quantidade que deverá ser retirada ao estoque");
                int qnt = int.Parse(Console.ReadLine());
                p.SubtProduto(qnt);
                Console.WriteLine("DADOS ATUALIZADOS: " + p);
            }
            else
            {
                Console.WriteLine("ERRO");
            }
        }
    }
}