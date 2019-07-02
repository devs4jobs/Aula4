using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoEscola.Clasees
{
    class Professor : Pessoa
    {
        private double Salario_ { get; set; }
        private int Id_ { get; set; }

        public List<string> lstMaterias;
        public List<Turma> lstTurmas;
        

        #region MetodosConstrutores


        public Professor(string nome, double salario, int id, char genero, string nacionalidade, string cidade, string dataNascimento, string pais, List<string> listamaterias, char codigoTurma, List<Turma> turmas, Turma turma)
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


        public override object Cadastrar()
        {
            Professor prof = new Professor();
            Console.Beep();
            Console.Write("Digite o nome do professor(a) : ");
            prof.Nome = Console.ReadLine();
            Console.Write("\nDigite o Genero :  ");
            prof.Sexo = Convert.ToChar(Console.ReadLine());
            Console.Write("\nDigite a Nacionalidade:  ");
            prof.Nacionaliddade = Console.ReadLine();
            Console.Write("\nDigite o Pais : ");
            prof.Pais = Console.ReadLine();
            Console.Write("\nDigite a Cidade: ");
            prof.Cidade = Console.ReadLine();
            Console.Write("\nDigite o ID dele(a), Ex : 1234 : ");
            prof.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDigite a idade : ");
            prof.Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDigite a Data de Nascimento: ");
            prof.DataNasc = Console.ReadLine();
            Console.Write("\nDigite o Salario: ");
            prof.Salario = Convert.ToDouble(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);
            Console.Write("\nDigite quantas materias esse Professor(a)  terá :");
            int QuantidadeDeMaterias = Convert.ToInt32(Console.ReadLine());
            prof.Cadastrarmaterias(QuantidadeDeMaterias);

            Console.WriteLine("Para quantas turmas você dará aula !");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < quantidade; i++)
            {
                List<Turma> lstTurmas = new List<Turma>();

                Console.WriteLine("Digite qual o codigo da turma que vocÊ dara aula : EX: A, B, C.. ");

                prof.CodTurma = Convert.ToChar(Console.ReadLine());

                //Turma turma = new Turma(CodTurma);

                if (lstTurmas.Exists(x => x.CodTurma == prof.CodTurma))
                    lstTurmas.Add(prof);
            }
            return prof;
        }

        public void Cadastrarmaterias(int qntMaterias)
        {

            for (int i = 0; i < qntMaterias; i++)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t\t============================ MENU DE MATÉRIAS ============================\t\t\n");
                Console.WriteLine("\t\t\t\t\tDigite um Opção a ser feita ! : \n\n");
                Console.WriteLine("\t\t\t\t\t1 - Português\n\t\t\t\t\t2 - Matemática\n\t\t\t\t\t3 - Ciências\n\t\t\t\t\t4 - Geografia\n\t\t\t\t\t5 - Artes\n\t\t\t\t\t6 - História\n\t\t\t\t\t7 - Ed.Física");
                int codMateria = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\t\t============================== XXXX ==============================\t\t\n");
                lstMaterias = new List<string>();

                switch (codMateria)
                {

                    case 1: lstMaterias.Add("Português"); break;
                    case 2: lstMaterias.Add("Matemática"); break;
                    case 3: lstMaterias.Add("Ciências"); break;
                    case 4: lstMaterias.Add("Geografia"); break;
                    case 5: lstMaterias.Add("Artes"); break;
                    case 6: lstMaterias.Add("História"); break;
                    case 7: lstMaterias.Add("Ed.Física"); break;
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

        #region MetodosAbstratos
        public override void ExibirListas(List<object> list)
        {

            //Console.WriteLine("Digite o código da turma que deseja ");

            Turma trm = new Turma();
            Professor professor = new Professor();


            foreach (Professor prof in lstProfessores)
            {
                Console.WriteLine(prof);
            }

            
            #endregion
        }
    }
}

