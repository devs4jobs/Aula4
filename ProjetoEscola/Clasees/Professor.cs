using System;
using System.Collections.Generic;
using System.Globalization;
using ProjetoEscola.Clasees.Excepitions;

namespace ProjetoEscola.Clasees
{
    class Professor : Pessoa
    {
        private double Salario_ { get; set; }
        private int Id_ { get; set; }

        public List<string> lstMaterias = new List<string>();
        public List<string> lstCodTurma = new List<string>();

        #region MetodosConstrutores

        public Professor(string nome, string sexo, string nacionaliddade, DateTime dataNasc, string pais, string cidade, uint idade, List<string> listamaterias, List<string> codigoTurma ) : base(nome,sexo, nacionaliddade, dataNasc, pais, cidade, idade)
        {
            lstMaterias = listamaterias;
            lstCodTurma = codigoTurma;

        }
        public Professor() { }

        #endregion

        #region Propriedades 

        public int ID
        {
            get { return Id_; }
            set
            {
                Id_ = value;
            }
        }

        public double Salario
        {
            get { return Salario_; }
            set
            {
                Salario_ = value;
            }
        }

        #endregion

        #region MetodosDaClasse

        #endregion

        #region MetodosAbstratos

        public override object Cadastrar(List<Turma> lstTurmas)
        {
            Random random = new Random();
            Console.Beep();



            //while( N < 0 || N > 5 )


            Console.Write("Digite o nome do professor(a) : ");
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


            ID = random.Next(1, 1000);
            Console.Write($"\n O ID dele(a) é {ID} \n");


            Console.Write("\nDigite o Salario: ");
            try
            {
                Salario = Convert.ToDouble(Console.ReadLine());
                while (Salario < 0.0)
                {
                    Console.Write("\nDigite um salário válido");
                    Salario = Convert.ToUInt32(Console.ReadLine());
                }
            }
            catch (Exception x)
            {
                throw new Exception($"Insira um valor valido ! : {x.Message}");
            }



            Console.Write("\nDigite quantas materias esse Professor(a)  terá :");
            int QuantidadeDeMaterias = Convert.ToInt32(Console.ReadLine());
            Cadastrarmaterias(QuantidadeDeMaterias);
            CadastrarCodigoTurma(lstTurmas);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            return this;

        }

        public override void CadastrarCodigoTurma(List<Turma> lstTurmas)
        {
            Console.WriteLine("\nPara quantas turmas você dará aula?");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            if (quantidade > 3) { quantidade = 3; }
            for (int i = 0; i < quantidade; i++)
            {

                Console.WriteLine("\nDigite qual o codigo da turma que o Professor dara aula : A ou B ou  C ");
                string codTurma = Console.ReadLine().ToUpper();

                switch (codTurma)
                {
                    case "A":
                        if (this.lstCodTurma.Contains("A"))
                        {
                            Console.WriteLine($"Professor {this.Nome} já cadastrado nessa turma ");
                            Console.WriteLine();
                            Console.WriteLine("Insira uma outra turma");
                            i--;
                            break;
                        }
                        else
                            lstCodTurma.Add("A");


                        foreach (Turma turma in lstTurmas)
                        {
                            if (lstTurmas.Exists(X => X.CodTurma == "A"))
                                turma.lstProfessores.Add(this);
                            else
                            {
                                Turma A = new Turma();
                                A.CodTurma = "A";
                                A.lstProfessores.Add(this);
                                lstTurmas.Add(A);
                            }
                        }
                        break;


                    case "B":
                        if (this.lstCodTurma.Contains("B"))
                        {
                            Console.WriteLine($"Professor {this.Nome} já cadastrado nessa turma ");
                            Console.WriteLine();
                            Console.WriteLine("Insira uma outra turma");
                            i--;
                            break;
                        }
                        else
                            lstCodTurma.Add("B");
                        foreach (var turma in lstTurmas)
                        {
                            if (turma.CodTurma == "B")
                            {

                                turma.lstProfessores.Add(this);
                            }
                            else
                            {
                                Turma B = new Turma();
                                B.CodTurma = "B";
                                B.lstProfessores.Add(this);
                                lstTurmas.Add(B);

                            }
                        }
                        break;
                    case "C":
                        if (this.lstCodTurma.Contains("C"))
                        {
                            Console.WriteLine($"Professor {this.Nome} já cadastrado nessa turma ");
                            Console.WriteLine();
                            Console.WriteLine("Insira uma outra turma");
                            i--;
                            break;
                        }
                        else
                            lstCodTurma.Add("C");
                        foreach (var turma in lstTurmas)
                        {
                            if (turma.CodTurma == "C")
                            {

                                turma.lstProfessores.Add(this);
                            }
                            else
                            {
                                Turma C = new Turma();
                                C.CodTurma = "C";
                                C.lstProfessores.Add(this);
                                lstTurmas.Add(C);

                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Codigo invalido insira o um codigo valido , entre eles : A ou B ou C !");
                        codTurma = Console.ReadLine().ToUpper();
                        while (codTurma != "A" || codTurma != "B" || codTurma != "C")
                        {
                            Console.WriteLine("Codigo invalido insira o um codigo valido , entre eles : A ou B ou C !");
                            codTurma = Console.ReadLine().ToUpper();
                        }
                        i--;
                        break;
                }
            }

        }

        public void Cadastrarmaterias(int QuantidadeDeMaterias)
        {
            lstMaterias = new List<string>();
            if (QuantidadeDeMaterias > 7) { QuantidadeDeMaterias = 7; }
            for (int i = 0; i < QuantidadeDeMaterias; i++)
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\t\t============================ MENU DE MATÉRIAS ============================\t\t\n");
                Console.WriteLine("\t\t\t\t\tDigite um Opção a ser feita ! : \n\n");
                Console.WriteLine("\t\t\t\t\t1 - Português\n\t\t\t\t\t2 - Matemática\n\t\t\t\t\t3 - Ciências\n\t\t\t\t\t4 - Geografia\n\t\t\t\t\t5 - Artes\n\t\t\t\t\t6 - História\n\t\t\t\t\t7 - Ed.Física");
                Console.WriteLine();
                Console.Write("                                   "); int codMateria = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (codMateria)
                {

                    case 1:
                        if (lstMaterias.Contains("Português"))
                        {
                            Console.WriteLine("Materia já cadastrada");
                            Console.WriteLine();
                            Console.WriteLine("Insira uma matéria válida do menu abaixo:");
                            i--;
                            break;
                        }
                        else
                            lstMaterias.Add("Português");
                        break;


                    case 2:
                        if (lstMaterias.Contains("Matemática"))
                        {
                            Console.WriteLine("Materia já cadastrada");
                            Console.WriteLine();
                            Console.WriteLine("Insira uma matéria válida do menu abaixo:");
                            i--;
                            break;
                        }
                        else
                            lstMaterias.Add("Matemática");
                        break;


                    case 3:
                        if (lstMaterias.Contains("Ciências"))
                        {
                            Console.WriteLine("Materia já cadastrada");
                            Console.WriteLine();
                            Console.WriteLine("Insira uma matéria válida do menu abaixo:");
                            i--;
                            break;
                        }
                        else
                            lstMaterias.Add("Ciências");
                        break;


                    case 4:
                        if (lstMaterias.Contains("Geografia"))
                        {
                            Console.WriteLine("Materia já cadastrada");
                            Console.WriteLine();
                            Console.WriteLine("Insira uma matéria válida do menu abaixo:");
                            i--;
                            break;
                        }
                        else
                            lstMaterias.Add("Geografia");
                        break;


                    case 5:
                        if (lstMaterias.Contains("Biologia"))
                        {
                            Console.WriteLine("Materia já cadastrada");
                            Console.WriteLine();
                            Console.WriteLine("Insira uma matéria válida do menu abaixo:");
                            i--;
                            break;
                        }
                        else
                            lstMaterias.Add("Biologia");
                        break;


                    case 6:
                        if (lstMaterias.Contains("História"))
                        {
                            Console.WriteLine("Materia já cadastrada");
                            Console.WriteLine();
                            Console.WriteLine("Insira uma matéria válida do menu abaixo:");
                            i--;
                            break;
                        }
                        else
                            lstMaterias.Add("História");
                        break;


                    case 7:
                        if (lstMaterias.Contains("Ed.Física"))
                        {
                            Console.WriteLine("Materia já cadastrada");
                            Console.WriteLine();
                            Console.WriteLine("Insira uma matéria válida do menu abaixo:");
                            i--;
                            break;
                        }
                        else
                            lstMaterias.Add("Ed.Física");
                        break;


                    default:
                        Console.WriteLine("Opção inválida! Digite um inteiro entre 1 e 7");
                        codMateria = Convert.ToInt32(Console.ReadLine());

                        if (codMateria < 0 || codMateria >= 7)
                        {

                            while (codMateria < 0 || codMateria >= 7)
                            {

                                Console.WriteLine("Opção inválida! Digite um inteiro entre 1 e 7");
                                codMateria = Convert.ToInt32(Console.ReadLine());

                            }
                        }

                        break;
                }

            }
        }


        public override string ToString()
        {
            return $"Nome do Professor: {Nome} , Idade: {Idade} , ID: {ID}";
        }



        #endregion
    }

}


