using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    class Aluno : Professor
    {
        private int Matricula_ { get; set; }
        public object Turma; 

        public Aluno(string nome, char genero, string nacionalidade, int matricula, string dataNascimento, string pais, string cidade,object turma)
        {
            Nome = nome;
            Sexo = genero;
            Nacionaliddade = nacionalidade;
            Matricula_ = matricula;
            DataNasc = dataNascimento;
            Pais = pais;
            Cidade = cidade;
            Turma = turma;
        }

        public Aluno() { }

        public int Matricula
        {
            get { return Matricula_; }
            set {
                if (value != 0 && value >= 4)
                    Matricula_ = value;
            }
        }

        public object CadastrarAlunos()
        {
            Aluno aluno = new Aluno();
            Console.Beep();
            Console.Write("Digite o nome do Aluno(a) : ");
            aluno.Nome = Console.ReadLine();
            Console.Write("\nDigite o Genero :  ");
            aluno.Sexo = Convert.ToChar(Console.ReadLine());
            Console.Write("\nDigite a Nacionalidade:  ");
            aluno.Nacionaliddade = Console.ReadLine();
            Console.Write("\nDigite o Pais : ");
            aluno.Pais = Console.ReadLine();
            Console.Write("\t\tDigite a Cidade: ");
            aluno.Cidade = Console.ReadLine();
            Console.Write("\nDigite a Matricula(a), Ex : 1234 : ");
            aluno.Matricula = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDigite a idade : ");
            aluno.Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t\tDigite a Data de Nascimento: ");
            aluno.DataNasc = Console.ReadLine();
            return aluno;
        }
    }
}
