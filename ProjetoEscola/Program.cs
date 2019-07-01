using System;
using System.Collections.Generic;
using System.Globalization;


// 30/06/2019  Falta : jogar pro txt , pesquisar dicionary e implementar no Codigo , Relacionar as 3 classes  !! Por CodTurma !!
namespace ProjetoEscola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Beep();
            List<Turma> lstTurmas = new List<Turma>();
            Turma turma = new Turma();
            Console.WriteLine("\t\t============================== MENU ==============================\t\t\n");
            Console.WriteLine("\t\t\t\t\tDigite um Opção a ser feita ! : \n\n");
            Console.WriteLine("\t\t\t\t\t1 - Cadastrar Professores\n\t\t\t\t\t2 - Cadastrar Alunos\n\t\t\t\t\t3 - Cadastrar Turmas\n");
            Console.WriteLine("\t\t============================== XXXX ==============================\t\t\n");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                Console.Write("Digite quantos Professores  você deseja cadastrar :  ");
                int N = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < N; i++)
                {
                    Professor prof = new Professor();
                    prof.CadastrarProfessor();
                    turma.lstProfessores.Add(prof);
                }//Repetição Para Adicionar Professores a Lista !!
            }
            else if (op == 2)
            {
                Console.Write("Digite quantos Alunos  você deseja cadastrar :  ");
                int N = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < N; i++)
                {
                    Aluno aluno = new Aluno();
                    
                    turma.lstAlunos.Add(aluno);
                }//Repetição Para Adicionar Professores a Lista !!
            }else if (op == 3){

            }
        }//Main
    }//Class Programa
}
