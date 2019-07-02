using System;
using System.Collections.Generic;
using System.Text;
using CadastroEscolar.Entidades.Enums;
namespace CadastroEscolar.Entidades
{
    class Aluno:Pessoa
    {
        public List<Classes> lstCodAlunos{ get; set; } = new List<Classes>();
        public int Ra { get;  set; }
        public object Alunos { get;  set; }

        public Aluno()
        {

        }

        public Aluno(int ra)

        {
            Ra = ra;
        }

       override public object Cadastrar()
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("DIGITE O NOME DO ALUNO");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("DIGITE A IDADE DO ALUNO:");
            aluno.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("QUAL O SEXO DO ALUNO?\n DIGITE ( F ) PARA FEMININO E ( M ) PARA MASCULINO");
            aluno.Sexo = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("DIGITE O CPF DO ALUNO:");
            aluno.Cpf = Console.ReadLine().ToUpper();

            Console.WriteLine("CRIE UM RA PARA ESTE ALUNO: ");
            aluno.Ra = int.Parse(Console.ReadLine());

            Console.WriteLine("QUAL É A TURMA DO Aluno? A,B,C,D ou E");
            Classes C = Enum.Parse<Classes>(Console.ReadLine().ToUpper());
            lstCodAlunos.Add(C);


            return aluno;

        }

    }




}
