using System;
using System.Collections.Generic;

namespace aula04
{
    class Program
    {
        static void Main(string[] args)
        {   string Cadastro;
            List<Professor> prof = new List<Professor>();
            List<Aluno> alu = new List<Aluno>();
            List<Turma> Turmas = new List<Turma>();
            do
            {
                Console.WriteLine("digite 1 para cadastrar professor.\ndigite 2 para cadastrar aluno.\nDigite 3 para cadastrar uma turma.\nDigite 4 para cadastrar um professor em uma turma\n" +
                    "Digite 5 para Cadastrar um aluno numa turma\nDigite 6 para terminar.");
                Cadastro = Console.ReadLine();
                switch (Cadastro)
                {
                    case "1":
                        {
                            Professor professor = new Professor();
                            professor.Registro();
                            prof.Add(professor);
                            break;
                        }
                    case "2":
                        {
                            Aluno Aluno = new Aluno();
                            Aluno.Registro();
                            alu.Add(Aluno);
                            break;
                        }
                    case "3":
                        {
                            if (prof != null)
                            {
                                Turma turma = new Turma();
                                turma.Registro(prof);
                                Turmas.Add(turma);
                            }
                            else { Console.WriteLine("Registre um professor primeiro"); }
                            break;
                        }
                    case "4":
                        {
                            foreach(Turma v in Turmas)
                            {
                                Console.WriteLine($"Nome da turma:{v.Nome}");
                            }
                            Console.WriteLine("Qual o nome da turma?");
                            string c = Console.ReadLine();
                            foreach (Turma v in Turmas)
                            {
                                if (v.Nome == c)
                                    v.Registro(prof);
                            }
                            break;
                        }
                    case "5":
                        {
                            foreach (var v in alu)
                            {
                                Console.WriteLine($"Nome do aluno:{v.Nome}");
                            }
                            Console.WriteLine("Qual o RA do aluno?");
                            string c = Console.ReadLine();
                            foreach (Aluno v in alu)
                            {
                                if (v.RA == c)
                                    v.RegistrarT(Turmas);
                            }
                            break;
                        }
                    case "6": { Console.WriteLine("Termino da registro");
                            break;
                        }
                     default: { Console.WriteLine("Digite uma opcao valida!");
                            break;
                        }
                }
            } while (Cadastro != "6");
        }
    }
}
