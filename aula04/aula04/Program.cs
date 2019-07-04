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
            List<string>Mat=new List<string> { "MATEMATICA", "PORTUGUES", "CIENCIAS", "ARTES", "HISTORIA", "EDUCACAO FISICA" };
            List<Professor> prof = new List<Professor>();
            List<Aluno> alu = new List<Aluno>();
            List<Turma> Turmas = new List<Turma>();
            string path = @"C:\Users\Treinamento 2\Desktop\Aula4\aula04\CaminhoT";
            string path2 = @"C:\Users\Treinamento 2\Desktop\Aula4\aula04\CaminhoP";
            string path3 = @"C:\Users\Treinamento 2\Desktop\Aula4\aula04\CaminhoA";
            try
            {
                using (StreamReader s = File.OpenText(path))
                {
                    string[] lines = File.ReadAllLines(path);
                    foreach (var line in lines) 
                    {
                        Turma G = JsonConvert.DeserializeObject<Turma>(line);
                        if(!Turmas.Contains(G))
                        Turmas.Add(G);
                    }
                }
                using (StreamReader s = File.OpenText(path2))
                {
                    string[] lines = File.ReadAllLines(path2);
                    foreach (var line in lines)
                    {
                        Professor G = JsonConvert.DeserializeObject<Professor>(line);
                        if(!prof.Contains(G))
                        prof.Add(G);
                    }
                }
                using (StreamReader s = File.OpenText(path3))
                {
                    string[] lines = File.ReadAllLines(path3);
                    foreach (var line in lines)
                    {
                        Aluno G = JsonConvert.DeserializeObject<Aluno>(line);
                        if(!alu.Contains(G))
                        alu.Add(G);
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
                    "Digite 5 para cadastrar um aluno numa turma.\nDigite 6 para terminar.\nDigite 7 para ver as informações de um professor.\nDigite 8 para ver as informações de um aluno.");
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
                                ConsoleColor aux = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Green;
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
                                Console.ForegroundColor = aux;
                                Console.Clear();
                                break;
                            }
                        case "5":
                            {
                                int c;
                                ConsoleColor aux = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                foreach (var v in alu)
                                {
                                    Console.WriteLine($"Nome do aluno:{v.Nome} RA:{v.RA}");
                                }
                                do
                                {
                                    Console.WriteLine("Qual o RA do aluno?");
                                    c = Convert.ToInt32(Console.ReadLine());
                                } while (c <= 0);
                                foreach (Aluno v in alu)
                                {
                                    if (v.RA == c)
                                        v.RegistrarT(Turmas,v);
                                }
                                Console.ForegroundColor = aux;
                                Console.Clear();
                                break;
                            }
                        case "6":
                            {
                                Console.WriteLine("Termino da registro");
                                break;
                            }
                        case "7":
                            {
                                foreach(var v in prof)
                                {
                                    Console.WriteLine($"{v.Nome}");
                                }
                                Console.WriteLine("Informe o professor:");
                                string g = Console.ReadLine();
                                foreach(var v in prof)
                                {
                                    if (v.Nome.Contains(g)) {
                                        Console.WriteLine(v.ToString());
                                        v.Link(Turmas,v);
                                    }  
                                }
                                break;
                            }
                        case "8":
                            {
                                foreach(var v in alu)
                                {
                                    Console.WriteLine($"{v.Nome}");
                                }
                                Console.WriteLine("Informe o aluno:");
                                string g = Console.ReadLine();
                                foreach (var v in alu)
                                {
                                    if (v.Nome.Contains(g))
                                    {
                                        Console.WriteLine(v.ToString());
                                        v.Show();
                                    }
                                }
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
            } while (Cadastro != "6");
            try
            {
                File.Delete(path);
                using(StreamWriter s = File.AppendText(path))
                {
                    foreach(Turma V in Turmas)
                    {
                        string G = JsonConvert.SerializeObject(V);
                        s.WriteLine(G);
                    }
                }
                File.Delete(path2);
                using (StreamWriter g = File.AppendText(path2))
                {
                    foreach (Professor v in prof)
                    {
                        string G = JsonConvert.SerializeObject(v);
                        g.WriteLine(G);
                    }
                }
                File.Delete(path3);
                using(StreamWriter h = File.AppendText(path3))
                {
                    foreach (Aluno V in alu)
                    {
                        string G = JsonConvert.SerializeObject(V);
                        h.WriteLine(G);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }catch(JsonException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
        }
    }
}
