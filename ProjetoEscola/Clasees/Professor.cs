using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoEscola.Clasees
{
    class Professor : Pessoa
    {
        private double Salario_ { get; set; }
        private int Id_ { get; set; }

        public List<string> lstMaterias = new List<string>();
        public List<string> lstCodTurma = new List<string>();

        #region MetodosConstrutores

        public Professor(string nome, double salario, int id, string genero, string nacionalidade, string cidade, string dataNascimento, string pais, List<string> listamaterias, List<string> codigoTurma)
        {
            Nome = nome;
            Salario_ = salario;
            Id_ = id;
            Sexo = genero;
            Nacionaliddade = nacionalidade;
            DataNasc = dataNascimento;
            Pais = pais;
            Cidade = cidade;
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
            try
            {
                Random random = new Random();
                Console.Beep();
                Console.Write("Digite o nome do professor(a) : ");
                Nome = Console.ReadLine();
                Console.Write("\nDigite o Genero :  ");
                Sexo = Console.ReadLine();
                Console.Write("\nDigite a Nacionalidade:  ");
                Nacionaliddade = Console.ReadLine();
                Console.Write("\nDigite o Pais : ");
                Pais = Console.ReadLine();
                Console.Write("\nDigite a Cidade: ");
                Cidade = Console.ReadLine();
                ID = random.Next(1, 1000);
                Console.Write($"\n O ID dele(a) é {ID} \n");
                Console.Write("\nDigite a idade : ");
                Idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nDigite a Data de Nascimento: ");
                DataNasc = Console.ReadLine();
                Console.Write("\nDigite o Salario: ");
                Salario = Convert.ToDouble(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);
                Console.Write("\nDigite quantas materias esse Professor(a)  terá :");
                int QuantidadeDeMaterias = Convert.ToInt32(Console.ReadLine());
                Cadastrarmaterias(QuantidadeDeMaterias);
                CadastrarCodigoTurma(lstTurmas);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                return this;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public override void CadastrarCodigoTurma(List<Turma> lstTurmas)
        {
            Console.WriteLine("\nPara quantas turmas você dará aula?");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite qual o codigo da turma que o Professor dara aula : A ou B ou  C ");
            string codTurma = Console.ReadLine().ToUpper();

            if (quantidade > 3) { quantidade = 3; }
            for (int i = 0; i < quantidade; i++)
            {


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

                            foreach (var turma in lstTurmas)
                            {
                                if (turma.CodTurma == "A")
                                {
                                    lstCodTurma.Add("A");
                                    turma.lstProfessores.Add(this);
                                }
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

                            foreach (var turma in lstTurmas)
                            {
                                if (turma.CodTurma == "B")
                                {
                                    lstCodTurma.Add("B");
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

                            foreach (var turma in lstTurmas)
                            {
                                if (turma.CodTurma == "C")
                                {
                                    lstCodTurma.Add("C");
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
                        i--;
                        break;
                }
            }

        }

        public void Cadastrarmaterias(int QuantidadeDeMaterias)
        {
            lstMaterias = new List<string>();

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

                        if (codMateria < 0 || codMateria > 7)
                        {

                            while (codMateria < 0 || codMateria > 7)
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


