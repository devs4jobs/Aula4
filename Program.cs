using System;
using CadastroEscolar.Entidades;

namespace CadastroEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Turma turma = new Turma();

            int decisao, i=0,N; 

            Console.WriteLine("DIGITE 1 PARA ALUNO / DIGITE 2 PARA PROFESSOR");
            decisao = int.Parse(Console.ReadLine());

            if (decisao == 1)
            {
                Console.WriteLine("QUANTOS ALUNOS DESEJA CADASTRAR? ");
                N = int.Parse(Console.ReadLine());

                for ( i = 0; i < N; i++)
                {
                    Aluno aluno = new Aluno();
                    aluno.Cadastrar();
                    turma.AddAlunos(aluno);
                }
            }
            else if (decisao == 2)
            {
                Console.WriteLine("QUANTOS PROFESSORES DESEJA CADASTRAR? ");
                 N= int.Parse(Console.ReadLine());

                for (i = 0; i <N ; i++)
                {
                    Professor professor = new Professor();
                    professor.Cadastrar();
                    turma.AddProfessores(professor);

                    Console.WriteLine(professor.Nome);
                }

            }

        }
    }
}
