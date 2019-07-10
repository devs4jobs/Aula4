using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
namespace aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            string Cadastro;
            List<string> Mat = new List<string> { "MATEMATICA", "PORTUGUES", "CIENCIAS", "ARTES", "HISTORIA", "EDUCACAO FISICA" };
            List<Professor> Prof = new List<Professor>();
            List<Aluno> Alu = new List<Aluno>();
            List<Turma> Turmas = new List<Turma>();
            string Path = @"C:\Users\Treinamento 2\Desktop\Aula4\aula04\CaminhoT";
            try
            {
                using (StreamReader s = File.OpenText(Path))
                {
                    string[] lines = File.ReadAllLines(Path);
                    foreach (var line in lines)
                    {
                        Turma G = JsonConvert.DeserializeObject<Turma>(line);
                        Turmas.Add(G);
                        Alu.AddRange(G.aluno);
                        Prof.AddRange(G.professors);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
            catch(JsonException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
            do
            {
                Console.ResetColor();
                Console.WriteLine("Digite 1 para cadastrar professor.\nDigite 2 para cadastrar aluno.\nDigite 3 para cadastrar uma turma.\nDigite 4 para cadastrar um professor em uma turma.\n" +
                    "Digite 5 para cadastrar um aluno numa turma.\nDigite 6 para ver as informações de um professor.\nDigite 7 para ver informações de um aluno.\nDigite 8 para terminar.");
                Cadastro = Console.ReadLine();
                try
                {
                    switch (Cadastro)
                    {
                        case "1":
                            {
                                Professor Professor = new Professor();
                                Professor.Registro(Mat);
                                Prof.Add(Professor);
                                Console.Clear();
                                break;
                            }
                        case "2":
                            {
                                Aluno Aluno = new Aluno();
                                Aluno.Registro(Mat);
                                Alu.Add(Aluno);
                                Console.Clear();
                                break;
                            }
                        case "3":
                            {
                                Turma Turma = new Turma();
                                Turma.Registro(Prof);
                                Turmas.Add(Turma);
                                Console.Clear();
                                break;
                            }
                        case "4":
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                foreach (Turma g in Turmas)
                                {
                                    Console.WriteLine($"Nome da turma:{g.Nome}");
                                }
                                Console.WriteLine("Qual o nome da turma?");
                                string c = Console.ReadLine().ToUpper();
                                Turma v = Turmas.Find(x => x.Nome == c);
                                if (v != null) { v.Registro(Prof); }
                                else { Console.WriteLine("Turma não existe"); }
                                break;
                            }
                        case "5":
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                foreach (var g in Alu)
                                {   if(!g.Validar)
                                    Console.WriteLine($"Nome do aluno:{g.Nome} RA:{g.RA}");
                                }
                                Console.WriteLine("Qual o RA do aluno?");
                                int c = Convert.ToInt32(Console.ReadLine());
                                Aluno v = Alu.Find(x => x.RA == c);
                                if (v != null) { v.RegistrarT(Turmas, v); }
                                else { Console.WriteLine("Aluno não existe"); }
                                break;
                            }
                        case "6":
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Professor(es):");
                                foreach (var v in Prof)
                                {
                                    Console.WriteLine($"Nome:{v.Nome},NR:{v.NRProfessor}");
                                }
                                Console.ResetColor();
                                Console.WriteLine("Informe o NR do professor");
                                int g = Convert.ToInt32(Console.ReadLine());
                                Professor a = Prof.Find(x => x.NRProfessor == g);
                                if (a != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(a.ToString());
                                    a.Link(Turmas, a);
                                }
                                else { Console.WriteLine("Professor não existe"); }
                                break;
                            }
                        case "7":
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Aluno(s):");
                                foreach (var v in Alu)
                                {
                                    Console.WriteLine($"Nome:{v.Nome},RA:{v.RA}");
                                }
                                Console.WriteLine("Informe o RA do aluno:");
                                int g = Convert.ToInt32(Console.ReadLine());
                                Aluno b = Alu.Find(x => x.RA == g);
                                if (b != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(b.ToString());
                                }
                                else { Console.WriteLine("Aluno não existe."); }
                                break;
                            }
                        case "8":
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Termino da registro");
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Digite uma opcao valida!");
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);
                }
            } while (Cadastro != "8");
            try
            {
                File.Delete(Path);
                using (StreamWriter s = File.AppendText(Path))
                {
                    foreach (Turma V in Turmas)
                    {
                        string G = JsonConvert.SerializeObject(V);
                        s.WriteLine(G);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
            catch (JsonException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
        }
    }
}
