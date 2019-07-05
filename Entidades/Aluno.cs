using System;
using System.Collections.Generic;
using System.Text;
using CadastroEscolar.Entidades.Design;
using System.Linq;
namespace CadastroEscolar.Entidades
{
    public class Aluno : Pessoa
    {

        public int Ra { get; set; }


        public Aluno()
        {

        }

        public Aluno(int ra)

        {
            Ra = ra;
        }

        override public void Cadastrar(List<Turma> lstTurmas)
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
            Sexo = Console.ReadLine().ToUpper();

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine(" DIGITE O CPF DO ALUNO:");
            Console.WriteLine("");
            d.MudarCores1();
            Cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            d.MudarCores();

            Console.WriteLine("");
            d.MudarCores1();

            Ra = (rnd.Next(10000, 90000));


            Console.WriteLine("O RA GERADO PARA ESTE ALUNO É:" + Ra);


            Console.WriteLine("QUAL TURMA ESTÈ ALUNO IRA PERTENCER? ");
            var codigoTurma = Console.ReadLine().ToUpper();

            if (lstTurmas.Where(t => t.CodTurma == codigoTurma).ToList().Count > 0)
            {
                lstTurmas.Where(t => t.CodTurma == codigoTurma).FirstOrDefault().AddAlunos(this);
            }
            else
            {
                Console.WriteLine("ESSA TURMA NAO EXISTE, DESEJA CADASTRAR UMA NOVA TURMA?");
                string decisaoturma = Console.ReadLine().ToUpper();
                if (decisaoturma == "SIM")
                    d.MudarCores();
                Console.WriteLine("QUAL TURMA DESEJA CADASTAR ESSE ALUNO? ? A,B,C,D OU E ?");
                string c = Console.ReadLine().ToUpper();

                Turma turma1 = new Turma();
                if (lstTurmas.Where(t => t.CodTurma == c).ToList().Count == 0)
                {
                    turma1.CadastrarTurma(c);
                    Console.WriteLine($"TURMA {c} CADASTRADA");
                    lstTurmas.Add(turma1);

                }
                else
                {
                    Console.WriteLine("TURMA JA CADASTRADA, NÂO É POSSIVEL CRIAR ELA NOVAMENTE");
                    Console.WriteLine("");
                   

                }

                Console.WriteLine("TURMA CRIADA, POR GENTILEZA EFETUAR O CADASTRO DO ALUNO NOVAMENTE !");
                Console.WriteLine("");




            }


        }

    }
}