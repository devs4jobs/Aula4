using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
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
            string Path2 = @"C:\Users\Treinamento 2\Desktop\Aula4\aula04\CaminhoP";
            string Path3 = @"C:\Users\Treinamento 2\Desktop\Aula4\aula04\CaminhoA";
            try
            {
                using (StreamReader s = File.OpenText(Path))
                {
                    string[] lines = File.ReadAllLines(Path);
                    foreach (var line in lines)
                    {
                        Turma G = JsonConvert.DeserializeObject<Turma>(line);
                        Turmas.Add(G);
                    }
                }
                using (StreamReader s = File.OpenText(Path2))
                {
                    string[] lines = File.ReadAllLines(Path2);
                    foreach (var line in lines)
                    {
                        Professor G = JsonConvert.DeserializeObject<Professor>(line);
                        Prof.Add(G);
                    }
                }
                using (StreamReader s = File.OpenText(Path3))
                {
                    string[] lines = File.ReadAllLines(Path3);
                    foreach (var line in lines)
                    {
                        Aluno G = JsonConvert.DeserializeObject<Aluno>(line);
                        Alu.Add(G);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
            do
            {
                Console.WriteLine("Digite 1 para cadastrar professor.\nDigite 2 para cadastrar aluno.\nDigite 3 para cadastrar uma turma.\nDigite 4 para cadastrar um professor em uma turma.\n" +
                    "Digite 5 para cadastrar um aluno numa turma.\nDigite 6 para terminar.\nDigite 7 para ver as informações de um professor ou um aluno.");
                Cadastro = Console.ReadLine();
                try
                {
                    switch (Cadastro)
                    {
                        case "1":
                            {
                                Professor professor = new Professor();
                                professor.Registro(Mat);
                                Prof.Add(professor);
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
                                Turma turma = new Turma();
                                turma.Registro(Prof);
                                Turmas.Add(turma);
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
                                break;
                            }
                        case "5":
                            {
                                int c;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                foreach (var g in Alu)
                                {
                                    Console.WriteLine($"Nome do aluno:{g.Nome} RA:{g.RA}");
                                }
                                Console.WriteLine("Qual o RA do aluno?");
                                c = Convert.ToInt32(Console.ReadLine());
                                Aluno v = Alu.Find(x => x.RA == c);
                                if (v != null) { v.RegistrarT(Turmas, v); }
                                Console.Clear();
                                Console.ResetColor();
                                break;
                            }
                        case "6":
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Termino da registro");
                                Console.ResetColor();
                                break;
                            }
                        case "7":
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Professor(es):");
                                foreach (var v in Prof)
                                {
                                    Console.WriteLine($"{v.Nome}");
                                }
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Aluno(s):");
                                foreach (var v in Alu)
                                {
                                    Console.WriteLine($"{v.Nome}");
                                }
                                Console.ResetColor();
                                Console.WriteLine("Informe o nome do professor ou aluno:");
                                string g = Console.ReadLine().ToUpper();
                                Professor a = Prof.Find(x => x.Nome == g);
                                if (a != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(a.ToString());
                                    a.Link(Turmas, a);
                                }
                                Aluno b = Alu.Find(x => x.Nome == g);
                                if (b != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(b.ToString());
                                    b.Show();
                                }
                                Console.ResetColor();
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
                    Console.ResetColor();
                }
            } while (Cadastro != "6");
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
                File.Delete(Path2);
                using (StreamWriter g = File.AppendText(Path2))
                {
                    foreach (Professor v in Prof)
                    {
                        string G = JsonConvert.SerializeObject(v);
                        g.WriteLine(G);
                    }
                }
                File.Delete(Path3);
                using (StreamWriter h = File.AppendText(Path3))
                {
                    foreach (Aluno V in Alu)
                    {
                        string G = JsonConvert.SerializeObject(V);
                        h.WriteLine(G);
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
