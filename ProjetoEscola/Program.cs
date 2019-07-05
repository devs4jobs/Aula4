using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Web.Script.Serialization;

//04/0/2019  pesquisar dicionary e implementar no Codigo 
namespace ProjetoEscola.Clasees
{
    class Program
    {
        static void Main(string[]args)
        {
            
            int op;
            Turma turma = new Turma();
            List<Turma> lstTurmas = new List<Turma>();
            turma.lstAlunos = new List<Aluno>();
            turma.lstProfessores = new List<Professor>();

            do
            {
                
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();
                Console.WriteLine();
                Console.WriteLine("\t\t============================== MENU DE REGISTRO ==============================\t\t");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\tDigite um Opção a ser feita ! :");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t1 - Cadastrar Professores\n\t\t\t\t\t2 - Cadastrar Alunos\n\t\t\t\t\t3 - Cadastrar Turmas\n\t\t\t\t\t4 - Para Sair");
                Console.WriteLine();
                op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    Console.Clear();
                    Console.Write("Digite quantos Professores você deseja cadastrar:  \n");
                    int N = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < N; i++)
                    {
                        Professor prof = new Professor();
                        prof.Cadastrar(lstTurmas,turma);
                        turma.lstProfessores = new List<Professor>();
                        turma.lstProfessores.Add(prof);
                        JsonSelialize(prof);
                    }//Repetição Para Adicionar Professores a Lista !!
                }
                else if (op == 2)
                {
                    Console.Write("Digite quantos Alunos você deseja cadastrar:  \n");
                    int N = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < N; i++)
                    {
                        Console.Clear();
                        Aluno aluno = new Aluno();
                        aluno.Cadastrar(lstTurmas,turma);
                        turma.lstAlunos.Add(aluno);
                        JsonSelialize(aluno);
                    }//Repetição Para Adicionar Professores a Lista !!
                }
                else if (op == 3)
                {
                    //List<Turma> lstTurmas = new List<Turma>();
                        Console.WriteLine("Insira o código da turma a ser cadastrado. Ex : A, B, C");
                        char codigoTurma = Convert.ToChar(Console.ReadLine().ToUpper());
                        CadastrarTurma(codigoTurma, lstTurmas);         
                                                
                        //lstTurmas.Add(trm);   
                }

                else if (op == 4)
                {
                    Console.WriteLine("RafaTheus agradece e volte sempre!");
                }
            } while (op != 4 || op > 4);



        }//Main


        #region MetodosStaticos
        public static object CadastrarTurma(char cod, List<Turma> lstTurmas)
        {
            do
            {

                if (lstTurmas.Exists(x => x.CodTurma == cod))
                {
                    Console.WriteLine("Essa Turma já Existe!");
                    return 0;

                }else   if (cod == 'A') {

                    Turma A = new Turma
                    {
                        CodTurma = 'A'
                    };
                    Console.WriteLine($"Turma {cod} cadastrada com sucesso");
                    lstTurmas.Add(A);
                    return A;

                }else if (cod == 'B') {
                    Turma B = new Turma
                    {
                        CodTurma = 'B'
                    };

                    Console.WriteLine($"Turma {cod} cadastrada com sucesso");
                    lstTurmas.Add(B);
                    return B;

                }  else if (cod == 'C') {
                    Turma C = new Turma
                    {
                        CodTurma = 'C'
                    };

                    Console.WriteLine($"Turma {cod} cadastrada com sucesso");
                    lstTurmas.Add(C);
                    return C;
                }   else

                    Console.WriteLine("Turma Inválida digite uma Turma Valida : A ou B ou C , Nada foi registrado!");
                    return 0;

            } while (cod != 'A' || cod != 'B' || cod != 'C');

          
        }


        public static void JsonSelialize(object objetoDesejado)
        {
            {
                string seteraquivo = @"C:\Users\Treinamento 6\Documents\Testes\Cadastro.json";

                try
                {
                    string strResultadoJson = JsonConvert.SerializeObject(objetoDesejado);
                    File.WriteAllText(seteraquivo, strResultadoJson);


                }
                catch (IOException e)
                {
                    Console.WriteLine("Ocorreu um erro ");
                    Console.WriteLine(e.Message);

                }
            }
        }
        #endregion

    }//Class Programa
}

