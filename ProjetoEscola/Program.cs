using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using ProjetoEscola.Tela;

//04/0/2019  pesquisar dicionary e implementar no Codigo 
namespace ProjetoEscola.Clasees
{
    class Program
    {
        static void Main(string[] args)
        {
            TelaPrincipal TPrincipal = new TelaPrincipal();
            List<Turma> lstTurmas = new List<Turma>();
            int op = 0;
            try
            {
                do
                {
                     op = TPrincipal.MenuPrincipal();
                    if (op == 1)
                    {
                        Console.Clear();
                        TPrincipal.MenuProfessor(lstTurmas);
                    }
                    else if (op == 2)
                    {
                        Console.Clear();
                        TPrincipal.MenuAluno(lstTurmas);
                    }
                    else if (op == 3)
                    {
                        Console.Clear();
                        TPrincipal.MenuTurma(lstTurmas);
                        Console.Clear();
                    }
                    else if (op == 4)
                    {
                        Console.Clear();
                        TPrincipal.ExbirTurmas(lstTurmas);
                    }
                    else if (op == 5)
                    {
                        Console.Clear();
                        TPrincipal.ExibirProfessores(lstTurmas);
                    }
                    else if (op == 6)
                    {
                        Console.Clear();
                        TPrincipal.ExibirAlunos(lstTurmas);
                    }
                    else if (op == 7)
                    {
                        Console.Clear();
                        TPrincipal.Despedida();
                    }else
                        Console.WriteLine("Opção invalida!");
                } while (op != 7 || op > 7);

                JsonSelialize(lstTurmas);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }//Main

        #region MetodosStaticos
        public static object CadastrarTurma(string cod, List<Turma> lstTurmas)
        {
            do
            {

                if (lstTurmas.Exists(x => x.CodTurma == cod))
                {
                    Console.WriteLine("Essa Turma já Existe!");
                    return 0;

                }
                else if (cod == "A")
                {

                    Turma A = new Turma
                    {
                        CodTurma = "A"
                    };
                    Console.WriteLine($"Turma {cod} cadastrada com sucesso");
                    lstTurmas.Add(A);
                    return A;

                }
                else if (cod == "B")
                {
                    Turma B = new Turma
                    {
                        CodTurma = "B"
                    };

                    Console.WriteLine($"Turma {cod} cadastrada com sucesso");
                    lstTurmas.Add(B);
                    return B;

                }
                else if (cod == "C")
                {
                    Turma C = new Turma
                    {
                        CodTurma = "C"
                    };

                    Console.WriteLine($"Turma {cod} cadastrada com sucesso");
                    lstTurmas.Add(C);
                    return C;
                }
                else

                    Console.WriteLine("Turma Inválida digite uma Turma Valida : A ou B ou C , Nada foi registrado!");
                return 0;

            } while (cod != "A" || cod != "B" || cod != "C");


        }


        public static void JsonSelialize(List<Turma> turmas)
        {
            {
                try
                {
                    StreamWriter file = new StreamWriter(@"C:\Users\Treinamento 6\Desktop\teste\teste1.txt");

                    string strResultadoJson = JsonConvert.SerializeObject(turmas);
                    file.Write($"Lista de Turmas: {strResultadoJson} \n");
                    file.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Muito Obrigado Volte Sempre !!! ");
                }
            }
        }

        #endregion

    }//Class Programa
}

