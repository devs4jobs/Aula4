using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace aula04
{
    class Program
    {
        static void Main(string[] args)
        {   string Cadastro;
            List<string>Mat=new List<string> { "MATEMATICA", "PORTUQUES", "CIENCIAS", "ARTES", "HISTORIA", "EDUCACAO FISICA" };
            List<Professor> prof = new List<Professor>();
            List<Aluno> alu = new List<Aluno>();
            List<Turma> Turmas = new List<Turma>();
            string path = @"C:\Users\Treinamento 2\Desktop\Aula4\aula04\CaminhoT";
            string path2 = @"C:\Users\Treinamento 2\Desktop\Aula4\aula04\CaminhoP";
            string path3 = @"C:\Users\Treinamento 2\Desktop\Aula4\aula04\CaminhoA";
            do
            {
                Console.WriteLine("digite 1 para cadastrar professor.\ndigite 2 para cadastrar aluno.\nDigite 3 para cadastrar uma turma.\nDigite 4 para cadastrar um professor em uma turma\n" +
                    "Digite 5 para Cadastrar um aluno numa turma\nDigite 6 para terminar.");
                Cadastro = Console.ReadLine();
                try
                {
                    switch (Cadastro)
                    {
                        case "1":
                            {
                                Professor professor = new Professor();
                                professor.Registro(Mat);
                                prof.Add(professor);
                                Console.Clear();
                                break;
                            }
                        case "2":
                            {
                                Aluno Aluno = new Aluno();
                                Aluno.Registro(Mat);
                                alu.Add(Aluno);
                                Console.Clear();
                                break;
                            }
                        case "3":
                            {
                                Turma turma = new Turma();
                                turma.Registro(prof);
                                Turmas.Add(turma);
                                Console.Clear();
                                break;
                            }
                        case "4":
                            {
                                foreach (Turma v in Turmas)
                                {
                                    Console.WriteLine($"Nome da turma:{v.Nome}");
                                }
                                Console.WriteLine("Qual o nome da turma?");
                                string c = Console.ReadLine().ToUpper();
                                foreach (Turma v in Turmas)
                                {
                                    if (v.Nome == c)
                                        v.Registro(prof);
                                }
                                Console.Clear();
                                break;
                            }
                        case "5":
                            {
                                foreach (var v in alu)
                                {
                                    Console.WriteLine($"Nome do aluno:{v.Nome} RA:{v.RA}");
                                }
                                Console.WriteLine("Qual o RA do aluno?");
                                string c = Console.ReadLine().ToUpper();
                                foreach (Aluno v in alu)
                                {
                                    if (v.RA == c)
                                        v.RegistrarT(Turmas);
                                }
                                Console.Clear();
                                break;
                            }
                        case "6":
                            {
                                Console.WriteLine("Termino da registro");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Digite uma opcao valida!");
                                break;
                            }
                    }
                }catch(Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.White;

                }
            } while (Cadastro != "6");
            try
            {
                using(StreamWriter s = File.AppendText(path))
                {
                    foreach(Turma V in Turmas)
                    {
                        s.WriteLine(V.ToString());
                        V.Lista(s);
                    }
                }
                using (StreamWriter g = File.AppendText(path2))
                {
                    foreach (Professor v in prof)
                    {
                        g.WriteLine(v.ToString());
                        v.Lista(g);
                    }
                }
                using(StreamWriter h = File.AppendText(path3))
                {
                    foreach (Aluno V in alu)
                    {
                        h.WriteLine(V.ToString());
                        V.Lista(h);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
        }
    }
}
