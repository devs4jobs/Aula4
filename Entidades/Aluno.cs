using System;
using System.Collections.Generic;
using System.Text;
using CadastroEscolar.Entidades.Enums;
using CadastroEscolar.Entidades.Design;
namespace CadastroEscolar.Entidades
{
    class Aluno : Pessoa
    {
        public List<Magote> TurmaDoAluno { get; set; } = new List<Magote>();
        public int Ra { get; set; }


        public Aluno()
        {

        }

        public Aluno(int ra)

        {
            Ra = ra;
        }

        override public void Cadastrar()
        {


            Designs d = new Designs();
            Random rnd = new Random();


            Console.WriteLine("");
            Console.WriteLine("DIGITE O NOME DO ALUNO");
            Console.WriteLine("");

            Nome = Console.ReadLine().ToUpper();

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("DIGITE A IDADE DO ALUNO:");
            Console.WriteLine("");
            d.MudarCores1();
            Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("QUAL O SEXO DO ALUNO?\n DIGITE ( F ) PARA FEMININO E ( M ) PARA MASCULINO");
            Console.WriteLine("");
            d.MudarCores1();
            Sexo = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine(" DIGITE O CPF DO ALUNO:");
            Console.WriteLine("");
            d.MudarCores1();
            Cpf = Console.ReadLine().ToUpper();

            Console.WriteLine("");
            d.MudarCores();

            Console.WriteLine("");
            d.MudarCores1();

            int codidentificado = (rnd.Next(10000, 90000));
            Ra = codidentificado;

            Console.WriteLine("O RA GERADO PARA ESTE ALUNO É:" + codidentificado);

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("QUAL É A TURMA DO Aluno? A,B,C,D ou E");
            d.MudarCores1();

            Magote ma = new Magote();

            int decisao = int.Parse(Console.ReadLine());

            switch (decisao)


            {
                case 1:


                    Console.WriteLine("");
                    d.MudarCores();
                    Console.WriteLine("Turma A CADASTRADA");
                    ma.DefinirTurma(decisao);
                    TurmaDoAluno.Add(ma);
                    Console.WriteLine("");
                    break;

                case 2:
                    Console.WriteLine("");
                    d.MudarCores();
                    Console.WriteLine("TURMA B CADASTRADA");
                    ma.DefinirTurma(decisao);
                    TurmaDoAluno.Add(ma);
                    Console.WriteLine("");
                    break;

                case 3:
                    Console.WriteLine("");
                    d.MudarCores();
                    Console.WriteLine("TURMA C CADASTRADA");
                    ma.DefinirTurma(decisao);
                    TurmaDoAluno.Add(ma);
                    Console.WriteLine("");
                    break;

                case 4:
                    Console.WriteLine("");
                    d.MudarCores();
                    Console.WriteLine("TURMA D CADASTRADA");
                    ma.DefinirTurma(decisao);
                    TurmaDoAluno.Add(ma);
                    Console.WriteLine("");
                    break;

                case 5:
                    Console.WriteLine("");
                    d.MudarCores();
                    Console.WriteLine("TURMA E CADASTRADA");
                    ma.DefinirTurma(decisao);
                    TurmaDoAluno.Add(ma);
                    Console.WriteLine("");
                    break;

                default:
                    break;

            }

            Console.WriteLine($"ALUNO {Nome} CADASTRADO EM {ma.NomeTurma}!");

        }


    }

}
