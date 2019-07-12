using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CadastroEscolar.Entidades.Design;

namespace CadastroEscolar.Entidades
{
    public class Professor : Pessoa
    {
        public int Identificacao { get; set; }
        public double Salario { get; set; }
        public List<Materias> LstMaterias { get; set; } = new List<Materias>();

        int i = 0;
        public Professor()
        {

        }
        // metodo de cadastro com diversas validações
        #region "CADASTRO INFORMAÇÔES PROFESSORES"
        override public void Cadastrar(List<Turma> lstTurmas)
        {
            Random rnd = new Random();
            Designs d = new Designs();
        inicio:
            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("DIGITE O NOME DO PROFESSOR");
            Console.WriteLine("");
            d.MudarCores1();
            Nome = Console.ReadLine().Trim();
            while (Nome == "")
            {
                Console.WriteLine("DIGITO INCORRETO,ESCREVA NOVAMENTE");
                Nome = Console.ReadLine().Trim();

            }


            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("DIGITE A IDADE DO PROFESSOR:");
            Console.WriteLine("");
            d.MudarCores1();
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            while (Idade < 18 || Idade >= 100)
            {
                Console.WriteLine("PARA CADASTRO DE PROFESSORES É NECESSARIO SER MAIOR DE IDADE");
                Idade = int.Parse(Console.ReadLine());

            }

            do
            {
                Console.WriteLine("");
                d.MudarCores();
                Console.WriteLine("QUAL O SEXO DO PROFESSOR?\n DIGITE ( F ) PARA FEMININO E ( M ) PARA MASCULINO");
                Console.WriteLine("");
                d.MudarCores1();
                Sexo = Console.ReadLine().ToUpper();

            } while (Sexo != "F" && Sexo != "M");

            do
            {
                Console.WriteLine("");
                d.MudarCores();
                Console.WriteLine("DIGITE O CPF DO PROFESSOR:");
                Console.WriteLine("");
                d.MudarCores1();
                Cpf = long.Parse(Console.ReadLine());
                Console.WriteLine("");

            } while (Cpf < 10000000000 || Cpf > 99999999999);

            Console.WriteLine("AGORA DIGITE O SALARIO DO PROFESSOR ");
            Salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            d.MudarCores();

            Console.WriteLine("");
            d.MudarCores1();
            Identificacao = (rnd.Next(10000, 90000));

            Console.WriteLine("O NUMERO DE IDENTIFICAÇÂO PARA ESTE PROFESSOR É:" + Identificacao);

            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("CADASTRE AS MATERIAS QUE O PROFESSOR DA AULA: ");
            Console.WriteLine("");
            Console.WriteLine("QUANTAS MATERIAS DESEJA CADASTRAR PARA ESTE PROFESSOR?");
            Console.WriteLine("");
            d.MudarCores1();
            int num = int.Parse(Console.ReadLine());

            while (num > 5)
            {
                Console.WriteLine("O PROFESSOR PODE DAR AULA APENAS EM 5 MATERIAS DIFERENTES");
                num = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < num; i++)
            {
                Materias m = new Materias();

                Console.WriteLine("");
                d.MudarCores();
                Console.WriteLine($"DIGITE 1 PARA MATEMATICA\nDIGITE 2 PARA PORTUGUES\nDIGITE 3 PARA BIOLOGIA\nDIGITE 4 PARA GEOGRAFIA\nDIGITE 5 PARA INGLES");
                Console.WriteLine("");
                d.MudarCores1();
                int decisao = int.Parse(Console.ReadLine());
                while (decisao < 0 || decisao > 5)
                {
                    Console.WriteLine("OPCAO INVÁLIDA, DIGITE NOVAMENTE!");
                    decisao = int.Parse(Console.ReadLine());
                }

                switch (decisao)
                {

                    case 1:

                        Console.WriteLine("");
                        d.MudarCores();

                        if (LstMaterias.Where(t => t.CodMateria == decisao).ToList().Count == 0)
                        {
                            Console.WriteLine("MATERIA MATEMATICA ADICIONADA!");
                            m.DefinirMateria(decisao);
                            LstMaterias.Add(m);
                        }
                        else

                        {
                            Console.WriteLine("MATERIAS REPETIDAS, FAVOR ADICIONAR OUTRA ");
                            i--;
                        }


                        Console.WriteLine("");
                        break;


                    case 2:
                        Console.WriteLine("");
                        d.MudarCores();

                        if (LstMaterias.Where(t => t.CodMateria == decisao).ToList().Count == 0)
                        {
                            Console.WriteLine("MATERIA PORTUGUES ADICIONADA!");
                            m.DefinirMateria(decisao);
                            LstMaterias.Add(m);
                        }
                        else

                        {
                            Console.WriteLine("MATERIAS REPETIDAS, FAVOR ADICIONAR OUTRA ");
                            i--;
                        }


                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.WriteLine("");
                        d.MudarCores();

                        if (LstMaterias.Where(t => t.CodMateria == decisao).ToList().Count == 0)
                        {
                            Console.WriteLine("MATERIA BIOLOGIA ADICIONADA!");
                            m.DefinirMateria(decisao);
                            LstMaterias.Add(m);
                        }
                        else

                        {
                            Console.WriteLine("MATERIAS REPETIDAS, FAVOR ADICIONAR OUTRA ");
                            i--;
                        }

                        Console.WriteLine("");
                        break;

                    case 4:
                        Console.WriteLine("");
                        d.MudarCores();

                        if (LstMaterias.Where(t => t.CodMateria == decisao).ToList().Count == 0)
                        {
                            Console.WriteLine("MATERIA GEOGRAFIA ADICIONADA!");
                            m.DefinirMateria(decisao);
                            LstMaterias.Add(m);
                        }
                        else

                        {
                            Console.WriteLine("MATERIAS REPETIDAS, FAVOR ADICIONAR OUTRA ");
                            i--;
                        }

                        Console.WriteLine("");
                        break;

                    case 5:
                        Console.WriteLine("");
                        d.MudarCores();

                        if (LstMaterias.Where(t => t.CodMateria == decisao).ToList().Count == 0)
                        {
                            Console.WriteLine("MATERIA INGLES  ADICIONADA!");
                            m.DefinirMateria(decisao);
                            LstMaterias.Add(m);
                        }
                        else
                        {
                            Console.WriteLine("MATERIAS REPETIDAS, FAVOR ADICIONAR OUTRA ");
                            i--;
                        }
                        Console.WriteLine("");
                        break;

                    default:

                        break;

                }
            }
            Console.Clear();
            Console.WriteLine("");
            d.MudarCores();
            Console.WriteLine("ESSE PROFESSOR DA AULA PARA QUANTAS TURMAS?");
            int turm = Convert.ToInt32(Console.ReadLine());
            if (turm > 5)
            {
                turm = 5;
            }
            Console.WriteLine("");
            d.MudarCores1();

            for (int i = 0; i < turm; i++)
            {
                Console.WriteLine("PARA QUAL TURMA ESTE PROFESSOR DARÁ AULA ?");
                Console.WriteLine("");

                var codigoTurma = Console.ReadLine().ToUpper();
                while (codigoTurma != "A" && codigoTurma != "B" && codigoTurma != "C" && codigoTurma != "D" && codigoTurma != "E")
                {
                    Console.WriteLine("OPCAO INVÁLIDA, FAVOR DIGITAR NOVAMENTE!");
                    codigoTurma = Console.ReadLine().ToUpper();
                }
                if (lstTurmas.Where(t => t.CodTurma == codigoTurma).ToList().Count > 0)
                {
                    lstTurmas.Where(t => t.CodTurma == codigoTurma).FirstOrDefault().AddProfessores(this);
                    Console.WriteLine($"CADASTRO DO PROFESSOR {Nome} ID: {Identificacao} NESSA TURMA REALIZADO ");
                }
                else
                {
                    d.MudarCores();

                    Console.WriteLine("ESSA TURMA NAO EXISTE, QUAL TURMA DESEJA CADASTRAR? A,B,C,D OU E ?");
                    string c = Console.ReadLine().ToUpper();
                    Console.WriteLine("");


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
                        Console.WriteLine("TURMA JA CADASTRADA, FAVOR ADICIONAR OUTRA");
                        Console.WriteLine("");
                        i--;
                    }
                    Console.WriteLine("TURMA CRIADA, APERTE ENTER EFETUAR O CADASTRO DO PROFESSOR NOVAMENTE !");
                    Console.WriteLine("");
                    Console.ReadLine();
                    goto inicio;
                }
                #endregion
            }

        }

    }
}