using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using aula04.Service;
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
            Show show = new Show();
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
                                break;
                            }
                        case "2":
                            {
                                Aluno Aluno = new Aluno();
                                Aluno.Registro(Mat);
                                Alu.Add(Aluno);
                                break;
                            }
                        case "3":
                            {
                                Turma Turma = new Turma();
                                Turma.RegistroT(Prof);
                                Turmas.Add(Turma);
                                break;
                            }
                        case "4": { show.ShowRegistro(Prof, Turmas); break; }
                        case "5": { show.ShowRegistro(Alu, Turmas); break; }
                        case "6": { show.ShowP(Prof, Turmas); break; }
                        case "7": { show.ShowA(Alu); break; }
                        case "8":
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Termino da registro");
                                break;
                            }    
                        default:
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
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
