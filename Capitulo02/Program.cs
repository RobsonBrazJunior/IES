using ProjetoIES.model;
using ProjetoIES.Repo;
using System;

namespace ProjetoIES
{
    class Program
    {
        static void Main(string[] args)
        {
            var iesUTFPR = new Instituicao()
            {
                Nome = "UTFPR",
                Endereco = new Endereco()
                {
                    Rua = "Brasil",
                    Numero = "1000"
                }
            };

            var iesCC = new Instituicao()
            {
                Nome = "Casa do Código",
                Endereco = new Endereco()
                {
                    Bairro = "Liberdade"
                }
            };

            var dptoEnsino = new Departamento()
            {
                Nome = "Computação"
            };

            var dptoAlimentos = new Departamento();
            dptoAlimentos.Nome = "Alimentos";

            var dptoRevisao = new Departamento();
            dptoRevisao.Nome = "Revisão Escrita";

            iesUTFPR.RegistrarDepartamento(dptoEnsino);
            iesUTFPR.RegistrarDepartamento(dptoAlimentos);

            iesCC.RegistrarDepartamento(dptoRevisao);

            Console.WriteLine("UTFPR");
            for (int i = 0; i < iesUTFPR.ObterQuantidadeDeparetamentos(); i++)
            {
                Console.WriteLine($"==> {iesUTFPR.DepartamentoPorIndice(i).Nome}");
            }

            Console.WriteLine("Casa do Código");
            for (int i = 0; i < iesCC.ObterQuantidadeDeparetamentos(); i++)
            {
                Console.WriteLine($"==> {iesCC.DepartamentoPorIndice(i).Nome}");
            }

            Console.WriteLine();
            Console.WriteLine("=======================================");

            dptoAlimentos.RegistrarCurso(
                new Graduacao {
                    Nome = "Tecnologia de Alimentos",
                    CargaHoraria = 2000
                }
            );

            dptoAlimentos.RegistrarCurso(
                new Graduacao
                {
                    Nome = "Engenharia de Alimentos",
                    CargaHoraria = 3000
                }
            );

            Console.WriteLine();
            Console.WriteLine($"Cursos no departamento de {dptoAlimentos.Nome}");

            foreach (var curso in dptoAlimentos.Cursos)
            {
                Console.WriteLine($"==> {curso.Nome} ({curso.CargaHoraria}h)");
            }

            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine();

            var ctAlimentos = new Graduacao()
            {
                Nome = "Tecnologia em Alimentos",
                CargaHoraria = 2000
            };

            if (!dptoAlimentos.Cursos.Contains(ctAlimentos))
                dptoAlimentos.RegistrarCurso(ctAlimentos);

            dptoAlimentos.FecharDepartamento();
            dptoAlimentos = null;
            Console.WriteLine();
            Console.WriteLine("O departamento de alimentos foi fechado");

            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine();

            var cursoCC = new Graduacao()
            {
                Nome = "Ciência da Computação",
                CargaHoraria = 3000
            };

            cursoCC.RegistrarDisciplina(new Disciplina()
            {
                Nome = "Algoritmos",
                CargaHoraria = 80
            });
            cursoCC.RegistrarDisciplina(new Disciplina()
            {
                Nome = "Orientação a Objetos",
                CargaHoraria = 60
            });
            cursoCC.RegistrarDisciplina(new Disciplina()
            {
                Nome = "Orientação a Objetos",
                CargaHoraria = 80
            });
            cursoCC.RegistrarDisciplina(new Disciplina()
            {
                Nome = "Estrutura de Dados",
                CargaHoraria = 80
            });
            cursoCC.RegistrarDisciplina(new Disciplina()
            {
                Nome = "Programação para Web",
                CargaHoraria = 80
            });

            Console.WriteLine($"O curso {cursoCC.Nome} possui {cursoCC.Disciplinas.Count} disciplinas: ");
            foreach (var d in cursoCC.Disciplinas)
            {
                Console.WriteLine($"==> {d.Nome} ({d.CargaHoraria})");
            }

            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine();

            var graduacao = new Graduacao() { Nome = "Curso de Graduação" };
            var latoSensu = new LatoSensu() { Nome = "Curso de Lato Sensu" };
            var strictoSensu = new StrictoSensu() { Nome = "Curso de Stricto Sensu" };

            var repositorioCursos = new RepositorioCurso();
            repositorioCursos.Gravar(graduacao);
            repositorioCursos.Gravar(latoSensu);
            repositorioCursos.Gravar(strictoSensu);

            Console.WriteLine("Cursos gravados");
            foreach (var curso in repositorioCursos.ObterTodos())
            {
                Console.WriteLine($"==> {curso.Nome} ({curso.GetType()})");
            }

            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine();

            var turma = new Turma()
            {
                CodigoTurma = "1",
                PeriodoCurso = Enum.PeriodoCursoEnum.Primeiro,
                TurnoTurma = Enum.TurnoTurmaEnum.Matutino
            };

            var aluno = new Aluno()
            {
                RegistroAcademico = "1",
                Nome = "Asdrubal"
            };

            cursoCC.RegistarAluno(aluno);
            cursoCC.RegistrarTurma(turma);

            foreach (var d in cursoCC.Disciplinas)
            {
                try
                {
                    turma.RegistrarMatricula(new Matricula()
                    {
                        Aluno = aluno,
                        Disciplina = d
                    });
                } catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();                    
                }
                
            }

            Console.WriteLine("Registro de matrículas concluído");

            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine();

            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
