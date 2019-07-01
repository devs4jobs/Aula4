using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEscolar.Entidades
{
    class Aluno:Pessoa
    {
        public int Ra { get;  set; }
        public object Alunos { get;  set; }

        public Aluno()
        {

        }

        public Aluno(int ra)

        {
            Ra = ra;
        }

        public object Cadastroalunos()
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

            return aluno;

        }

    }




}
