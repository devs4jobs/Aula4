using System;
using System.Collections.Generic;
using System.Text;
using CadastroEscolar.Entidades.Enums;
using CadastroEscolar.Entidades.Design;
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
            Designs d = new Designs();


            Console.WriteLine("");
            Console.WriteLine("DIGITE O NOME DO ALUNO");
            Console.WriteLine("");
         
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("DIGITE A IDADE DO ALUNO:");
            Console.WriteLine("");
            d.MudarCores1();
            aluno.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("QUAL O SEXO DO ALUNO?\n DIGITE ( F ) PARA FEMININO E ( M ) PARA MASCULINO");
            Console.WriteLine("");
            d.MudarCores1();
            aluno.Sexo = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine(" DIGITE O CPF DO ALUNO:");
            Console.WriteLine("");
            d.MudarCores1();
            aluno.Cpf = Console.ReadLine().ToUpper();

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("CRIE UM RA PARA ESTE ALUNO:");
            Console.WriteLine("");
            d.MudarCores1();
            aluno.Ra = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("QUAL É A TURMA DO Aluno? A,B,C,D ou E");
            d.MudarCores1();
            Classes C = Enum.Parse<Classes>(Console.ReadLine().ToUpper());
            Console.Clear();
            lstCodAlunos.Add(C);

            return aluno;

        }

    }




}
