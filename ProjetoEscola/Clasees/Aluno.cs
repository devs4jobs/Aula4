using System;
using System.Collections.Generic;

namespace ProjetoEscola.Clasees
{
    class Aluno : Pessoa
    {
        private Guid Matricula_ { get; set; }
        public Turma Turma;


        #region Construtores
        public Aluno(string nome, string sexo, string nacionaliddade, DateTime dataNasc, string pais, string cidade, uint idade, Guid matricula, Turma turma) : base(nome,sexo,nacionaliddade,dataNasc,pais,cidade,idade)
        {
            Matricula_ = matricula;
            Turma = turma;
        }

        public Aluno() { }


        public Guid Matricula
        {
            get { return Matricula_; }
            set
            {
                Matricula_ = value;
            }
        }

        #endregion

        #region MetodosDaClasse



        #endregion

        #region MetodosAbstratos

        public override object Cadastrar(List<Turma> lstTurmas)
        {

                Console.Beep();
                Console.Write("Digite o nome do Aluno(a) : ");
                Nome = Console.ReadLine().Trim();

                while (Nome.Length == 0)
                {
                    Console.WriteLine($"Insira um nome valido ! Nome não pode ser Vazio ! ");
                    Nome = Console.ReadLine().Trim();
                }

                Console.Write("\nDigite o Genero : (M/F) ");
                Sexo = Console.ReadLine().ToUpper().Trim();

                while (((!Sexo.Contains("M")) && (!Sexo.Contains("F"))) || Sexo.Length > 1)
                {
                    Console.WriteLine($"Insira um Genero valido ! Genero não pode ser vazio e não pode ser diferente de (M/F)  ");
                    Sexo = Console.ReadLine().ToUpper().Trim();
                }

                Console.Write("\nDigite a Nacionalidade:  ");
                Nacionaliddade = Console.ReadLine().Trim();
                while (Nacionaliddade.Length == 0)
                {
                    Console.WriteLine($"Insira uma Nacionaliddade valida ! Nacionalidade não pode ser vazia ! ");
                    Nacionaliddade = Console.ReadLine().Trim();
                }

                Console.Write("\nDigite o Pais : ");

                Pais = Console.ReadLine().Trim();

                while (Pais.Length == 0)
                {
                    Console.WriteLine("Digite um Pais valido !");
                    Pais = Console.ReadLine().Trim();
                }
                Console.Write("\nDigite a Cidade: ");

                Cidade = Console.ReadLine();

                while (Cidade.Length == 0)
                {
                    Console.WriteLine("Digite uma Cidade valida !");
                    Cidade = Console.ReadLine().Trim();
                }



                int count = 1;
                while (count == 1)
                {
                    try
                    {
                        Console.Write("\nDigite uma idade válida: ");
                        Idade = Convert.ToUInt32(Console.ReadLine());
                        if (Idade > 0 || Idade < 100)
                        {
                            count = 2;
                        }
                        else
                        {
                        } while (Idade < 0 || Idade >= 100)
                        {

                            bool parseOkay;
                            Console.WriteLine("Insira uma idade válida \n");

                            var valid = Console.ReadLine();
                            uint valor;
                            parseOkay = uint.TryParse(valid, out valor);

                            if (parseOkay == true)
                            {
                                valor = uint.Parse(valid);
                                Idade = valor;
                                count = 2;
                            }
                            else
                            {
                                valor = 111;
                                Idade = valor;
                                count = 1;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("ERRO ");
                        count = 1;
                    }
                }
                Console.Write("\nDigite a Data de Nascimento: (DD/MM/YYYY)");
                DataNasc = Convert.ToDateTime(Console.ReadLine());

                Guid Matricula = Guid.NewGuid();
                Console.Write($"\nA Matricula(a) dele(a) é {Matricula} \n");
                CadastrarCodigoTurma(lstTurmas);

                return this;
       
        }
        public override string ToString()
        {

            return $"Nome do Aluno: {Nome} , Idade: {Idade} , Matrícula: {Matricula}";

        }


        public override void CadastrarCodigoTurma(List<Turma> lstTurmas)
        {
            Console.WriteLine("\nDigite qual o codigo da turma que o aluno vai estar !! : EX: A, B, C.. ");
            string codTurma = Console.ReadLine().ToUpper();

            switch (codTurma)
            {
                case "A":
                    foreach (var turma in lstTurmas)
                    {
                        if (turma.CodTurma == "A")
                            turma.lstAlunos.Add(this);
                        else
                        {
                            Turma A = new Turma();
                            A.lstAlunos.Add(this);
                            lstTurmas.Add(A);
                        }
                    }
                    break;

                case "B":
                    foreach (var turma in lstTurmas)
                    {
                        if (turma.CodTurma == "B")
                            turma.lstAlunos.Add(this);

                        else
                        {
                            Turma B = new Turma();
                            B.lstAlunos.Add(this);
                            lstTurmas.Add(B);
                        }
                    }
                    break;
                case "C":
                    foreach (var turma in lstTurmas)
                    {
                        if (turma.CodTurma == "C")
                            turma.lstAlunos.Add(this);

                        else
                        {
                            Turma C = new Turma();
                            C.lstAlunos.Add(this);
                            lstTurmas.Add(C);
                        }
                    }
                    break;
                default:

                    break;

            }
        }

        #endregion
    }
}

