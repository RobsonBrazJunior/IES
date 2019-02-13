using Capitulo02.model;
using System;

namespace Capitulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Instituicao instituicao = new Instituicao();
            Console.Write("Informe o nome da instituição: ");
            instituicao.Nome = Console.ReadLine();

            Console.WriteLine("Informe o endereço da instituição: ");
            instituicao.Endereco = Console.ReadLine();

            Console.WriteLine("====================================");
            Console.WriteLine($"Preenchido os dados da {instituicao.Nome}!");
            Console.Write("Pressione qualquer tecla para encerrar");
            Console.ReadKey();
        }
    }
}
