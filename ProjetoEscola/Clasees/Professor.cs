using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoEscola.Clasees
{
    class Professor : Pessoa
    {
        private double Salario_ { get; set; }
        private int Id_ { get; set; }

        public List<string> lstMaterias ;
        public List<Turma> lstTurmas;


        #region MetodosConstrutores


        public Professor(string nome, double salario, int id, char genero, string nacionalidade, string cidade, string dataNascimento, string pais, List<string> listamaterias, char codigoTurma, List<Turma> turmas)
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
            CodTurma = codigoTurma;
            lstTurmas = turmas;


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

        public override void Cadastrar(List<Turma> lstTurma, Turma turma)
        {
            Random random = new Random();
            Console.Beep();
            Console.Write("Digite o nome do professor(a) : ");
            Nome = Console.ReadLine();
            Console.Write("\nDigite o Genero :  ");
            Sexo = Convert.ToChar(Console.ReadLine());
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

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nPara quantas turmas você dará aula?");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {

                Console.WriteLine("\nDigite qual o codigo da turma que vocÊ vai ensinar : EX: A, B, C.. ");
                CodTurma = Convert.ToChar(Console.ReadLine().ToUpper());

                if (lstTurma.Exists(x => x.CodTurma == CodTurma))
                {

                    if (turma.lstProfessores.Exists(x => x.ID == ID)) { 
                        Console.WriteLine(" já existe um professor com mesmo id nessa turma ");
                    i--;
                    }

                else
                    turma.lstProfessores.Add(this);
                    Console.WriteLine($"O {Nome} dara aula para Turma {CodTurma} ! ");
                }
                else
                {
                    Program.CadastrarTurma(CodTurma, lstTurma);
                    if (lstTurma.Exists(x => x.CodTurma == CodTurma))
                        turma.lstProfessores.Add(this);

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
                Console.Write("                                   ");int codMateria = Convert.ToInt32(Console.ReadLine());
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


