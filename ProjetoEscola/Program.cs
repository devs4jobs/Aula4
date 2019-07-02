using System;
using System.Collections.Generic;
using System.Globalization;


// 30/06/2019  Falta : jogar pro txt , pesquisar dicionary e implementar no Codigo , Relacionar as 3 classes  !! Por CodTurma !!
namespace ProjetoEscola.Clasees
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Beep();
               

                Turma turma = new Turma();
                Console.WriteLine("\t\t============================== MENU DE REGISTRO ==============================\t\t\n");
                Console.WriteLine("\t\t\t\t\tDigite um Opção a ser feita ! : \n\n");
                Console.WriteLine("\t\t\t\t\t1 - Cadastrar Professores\n\t\t\t\t\t2 - Cadastrar Alunos\n\t\t\t\t\t3 - Cadastrar Turmas\n\t\t\t\t\t4 - Para Sair");
                Console.WriteLine("\t\t============================== XXXX ==============================\t\t\n");

                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    Console.Clear();
                    Console.Write("Digite quantos Professores  você deseja cadastrar :  ");
                    int N = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < N; i++)
                    {
                        Professor prof = new Professor();
                        prof.Cadastrar();
                        turma.lstProfessores = new List<Professor>();
                        turma.lstProfessores.Add(prof);
                        turma.AddProfessor(prof);
                    }//Repetição Para Adicionar Professores a Lista !!
                }
                else if (op == 2)
                {
                    Console.Write("Digite quantos Alunos  você deseja cadastrar :  ");
                    int N = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < N; i++)
                    {
                        Console.Clear();
                        Aluno aluno = new Aluno();
                        aluno.Cadastrar();
                        turma.lstAlunos = new List<Aluno>(aluno.CodTurma);
                        turma.AddAlunos(aluno);
                    }//Repetição Para Adicionar Professores a Lista !!
                }
                else if (op == 3)
                {


                    Console.WriteLine("Quantas turmas desejas cadastrar");
                    int qnt = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < qnt; i++)
                    {
                        Turma trm = new Turma();

                        Console.WriteLine("Insira o código da turma a ser cadastrado, Ex : A, B, C");
                        trm.CodTurma = Convert.ToChar(Console.ReadLine());

                        trm.CadastrarTurma(trm.CodTurma);

                        trm.turmas.Add(trm);

                    }

                }

                else if (op == 4)
                {
                    Console.WriteLine("RafaTheus agradece e volte sempre!");
                }

            } while (op != 4 || op > 4);

        }//Main
    }//Class Programa
}

