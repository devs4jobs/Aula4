using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoEscola
{
    class Professor : Turma
    {
        private string Nome_ { get; set; }
        private double Salario_ { get; set; }
        private int Id_ { get; set; }
        public char Sexo;
        public string Nacionaliddade;
        public string DataNasc;
        public string Pais;
        public string Cidade;
        public int Idade;
        public List<string> lstMaterias;

        public Professor(string nome, double salario, int id, char genero, string nacionalidade, string cidade, string dataNascimento, string pais, List<string> listamaterias, char codigoTurma)
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
        }
        public Professor() { }

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
        public string Nome
        {
            get { return Nome_; }
            set
            {
                if (value != null && value.Length > 1)
                    Nome_ = value;
            }
        }



        #endregion

        public object CadastrarProfessor()
        {
            Professor prof = new Professor();
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
            for (int O = 0; O < QuantidadeDeMaterias; O++)
            {
                Console.WriteLine("Digite o nome da Matéria : ");
                string diciplina = Console.ReadLine();
                prof.lstMaterias.Add(diciplina);

            }
            Console.WriteLine("Para quantas turmas você dará aula !");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < quantidade; i++) { 
                Console.WriteLine("Digite qual o cofigo da turma que vocÊ dara aula : EX: A, B, C.. ");
                prof.CodTurma = Convert.ToChar(Console.ReadLine());
            }
            return prof ;
        }
    }

}
