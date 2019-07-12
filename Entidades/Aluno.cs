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

        // metodo de cadastro com diversas validações
        override public void Cadastrar(List<Turma> lstTurmas)
        {

            Designs d = new Designs();
            Random rnd = new Random();
        inicio:

            Console.WriteLine("");
            Console.WriteLine("DIGITE O NOME DO ALUNO");
            Console.WriteLine("");

            Nome = Console.ReadLine().Trim();
            while (Nome == "")
            {
                Console.WriteLine("DIGITO INCORRETO,ESCREVA NOVAMENTE");
                Nome = Console.ReadLine().Trim();

            }

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("DIGITE A IDADE DO ALUNO:");
            Console.WriteLine("");
            d.MudarCores1();
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            while (Idade < 4 || Idade > 21)
            {
                Console.WriteLine("PARA CADASTRO DE ALUNOS EM NOSSA ESCOLA É NECESSARIO TER NO MINIMO 4 ANOS ( ENSINO FUNDAMENTAL)");
                Console.WriteLine("E O MAXIMO DE 21 ANOS, 3 ANO DO ENSINO MEDIO");
                Console.WriteLine("");
                Idade = int.Parse(Console.ReadLine());
            }
            do
            {
                Console.WriteLine("");
                d.MudarCores();
                Console.WriteLine("QUAL O SEXO DO ALUNO?\nDIGITE ( F ) PARA FEMININO E ( M ) PARA MASCULINO");
                Console.WriteLine("");
                d.MudarCores1();
                Sexo = Console.ReadLine().ToUpper();
            } while (Sexo != "F" && Sexo != "M");

            do
            {
                Console.WriteLine("");
                d.MudarCores();
                Console.WriteLine("DIGITE O CPF DO ALUNO, CONTENDO 11 DIGITOS SEM PONTOS (.) OU TRAÇOS (-)");
                Console.WriteLine("");
                d.MudarCores1();
                Cpf = long.Parse(Console.ReadLine());

            } while (Cpf < 10000000000 || Cpf > 99999999999);

            Console.WriteLine("");
            d.MudarCores();

            Console.WriteLine("");
            d.MudarCores1();

            Ra = (rnd.Next(1000, 9000));


            Console.WriteLine("O RA GERADO PARA ESTE ALUNO É:" + Ra);
            Console.WriteLine("");


            Console.WriteLine("QUAL TURMA ESTÈ ALUNO IRA PERTENCER? ");
            Console.WriteLine("");
            var codigoTurma = Console.ReadLine().ToUpper();

            if (lstTurmas.Where(t => t.CodTurma == codigoTurma).ToList().Count > 0)
            {
                lstTurmas.Where(t => t.CodTurma == codigoTurma).FirstOrDefault().AddAlunos(this);
                Console.WriteLine("");
                Console.WriteLine($"CADASTRO DO ALUNO {Nome} RA: {Ra} FOI REALIZADO ");
            }
            else
            {
                d.MudarCores();
                Console.WriteLine("ESSA TURMA NAO EXISTE, QUAL TURMA DESEJA CADASTAR ? A,B,C,D OU E ?");
                string c = Console.ReadLine().ToUpper();

                Turma turma1 = new Turma();
                if (lstTurmas.Where(t => t.CodTurma == c).ToList().Count == 0)
                {
                    while (c != "A" && c != "B" && c != "C" && c != "D" && c != "E")
                    {
                        Console.WriteLine("OPCAO INVÁLIDA, FAVOR DIGITAR NOVAMENTE!");
                        c = Console.ReadLine().ToUpper();
                    }
                    turma1.CadastrarTurma(c);
                    Console.WriteLine($"TURMA {c} CADASTRADA");
                    if (lstTurmas.Contains(turma1))
                    {
                        Console.WriteLine("NAO É POSSIVEL ADICONAR TURMA, POIS ELA JÁ EXISTE!");
                    }
                    else
                    {
                        Console.WriteLine("Turma Adicionada");
                        lstTurmas.Add(turma1);
                    }
                }
                else
                {
                    Console.WriteLine("TURMA JA CADASTRADA, NÂO É POSSIVEL CRIAR ELA NOVAMENTE");
                    Console.WriteLine("");
                }
                Console.WriteLine("POR GENTILEZA EFETUAR O CADASTRO DO ALUNO NOVAMENTE !");
                Console.WriteLine("");
                goto inicio;
            }

        }

    }
}