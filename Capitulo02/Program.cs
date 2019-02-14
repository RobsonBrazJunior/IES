using Capitulo02.model;
using System;

namespace Capitulo02
{
    class Program
    {
        static void Main(string[] args)
        {
            var iesUTFPR = new Instituicao();
            iesUTFPR.Nome = "UTFPR";
            iesUTFPR.Endereco = "Medianeira";

            var iesCC = new Instituicao();
            iesCC.Nome = "Casa do Código";
            iesCC.Endereco = "São Paulo";

            var dptoEnsno = new Departamento();
            dptoEnsno.Nome = "Computação";

            var dptoAlimentos = new Departamento();
            dptoAlimentos.Nome = "Alimentos";

            var dptoRevisao = new Departamento();
            dptoRevisao.Nome = "Revisão Escrita";

            iesUTFPR.RegistrarDepartamento(dptoEnsno);
            iesUTFPR.RegistrarDepartamento(dptoAlimentos);

            iesCC.RegistrarDepartamento(dptoRevisao);

            Console.WriteLine("UTFPR");
            for (int i = 0; i < iesUTFPR.ObterQuantidadeDeparetamentos(); i++)
            {
                Console.WriteLine($"==> {iesUTFPR.Departamentos[i].Nome}");
            }

            Console.WriteLine("Casa do Código");
            for (int i = 0; i < iesCC.ObterQuantidadeDeparetamentos(); i++)
            {
                Console.WriteLine($"==> {iesCC.Departamentos[i].Nome}");
            }

            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
