using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

//30/06/2019  Falta : jogar pro txt , pesquisar dicionary e implementar no Codigo , Relacionar as 3 classes  !! Por CodTurma !!
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
//            string seteraquivo = @"C:\Users\Treinamento 6\Desktop\TesteFile";
//            string receberdados = @"C:\Users\Treinamento 6\Desktop\TesteFile1";

            do
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Beep();
                Console.WriteLine("\t\t============================== MENU DE REGISTRO ==============================\t\t\n");
                Console.WriteLine("\t\t\t\t\tDigite um Opção a ser feita ! : \n\n");
                Console.WriteLine("\t\t\t\t\t1 - Cadastrar Professores\n\t\t\t\t\t2 - Cadastrar Alunos\n\t\t\t\t\t3 - Cadastrar Turmas\n\t\t\t\t\t4 - Para Sair");
                Console.WriteLine("\t\t============================== XXXX ==============================\t\t\n");

                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    Console.Clear();
                    Console.Write("Digite quantos Professores  você deseja cadastrar :  \n");
                    int N = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < N; i++)
                    {
                        Professor prof = new Professor();
                        prof.Cadastrar(lstTurmas,turma);
                        turma.lstProfessores = new List<Professor>();
                        turma.lstProfessores.Add(prof);
                    }//Repetição Para Adicionar Professores a Lista !!
                }
                else if (op == 2)
                {
                    Console.Write("Digite quantos Alunos  você deseja cadastrar :  \n");
                    int N = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < N; i++)
                    {
                        Console.Clear();
                        Aluno aluno = new Aluno();
                        aluno.Cadastrar(lstTurmas,turma);
                        turma.lstAlunos.Add(aluno);
                    }//Repetição Para Adicionar Professores a Lista !!
                }
                else if (op == 3)
                {
                    //List<Turma> lstTurmas = new List<Turma>();
                        Console.WriteLine("Insira o código da turma a ser cadastrado, Ex : A, B, C");
                        char codigoTurma = Convert.ToChar(Console.ReadLine().ToUpper());
                        CadastrarTurma(codigoTurma, lstTurmas);                 
                                                
                        //lstTurmas.Add(trm);   
                }

                else if (op == 4)
                {
                    Console.WriteLine("RafaTheus agradece e volte sempre!");
                }

            } while (op != 4 || op > 4);

            try
            {
             //Aqui vamos Passar o Arquivo JSON para o nosso aquivo da maquina !! , caso no FileInfo ... 
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro ");
                Console.WriteLine(e.Message);

            }



        }//Main


        #region MetodosStaticos
        public static object CadastrarTurma(char cod, List<Turma> lstTurmas)
        {
            do
            {

                if (lstTurmas.Exists(x => x.CodTurma == cod))
                {
                    Console.WriteLine("Essa Turma já Existe ! ");
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

                    Console.WriteLine("Turma Inválida digite uma Turma Valida : A ou B ou C , Nada foi refistrado!");
                    return 0;

            } while (cod != 'A' || cod != 'B' || cod != 'C');

          
        }

        #endregion

    }//Class Programa
}

