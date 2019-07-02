using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Clasees
{
    class Aluno : Pessoa
    {
        private int Matricula_ { get; set; }

        #region Construtores
        public Aluno(string nome, char genero, string nacionalidade, int matricula, string dataNascimento, string pais, string cidade)
        {
            Nome = nome;
            Sexo = genero;
            Nacionaliddade = nacionalidade;
            Matricula_ = matricula;
            DataNasc = dataNascimento;
            Pais = pais;
            Cidade = cidade;
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

        #endregion

        #region MetodosDaClasse


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
            Console.Write("\nDigite a Cidade: ");
            aluno.Cidade = Console.ReadLine();
            Console.Write("\nDigite a Matricula(a), Ex : 1234 : ");
            aluno.Matricula = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDigite a idade : ");
            aluno.Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDigite a Data de Nascimento: ");
            aluno.DataNasc = Console.ReadLine();
            Console.WriteLine("Digite qual o codigo da turma que vocÊ vai estar !! : EX: A, B, C.. ");
            aluno.CodTurma = Convert.ToChar(Console.ReadLine());
            List<Turma> lstTurmas = new List<Turma>();

            for (int i = 0; i <lstTurmas.Count; i++)
            {
               Turma obj = new Turma();

                if (obj.CodTurma == aluno.CodTurma)
                {

                    obj.lstAlunos.Add(aluno);
                        
                }   
            }

           

            //public abstract void exibir();

            return aluno;
        }

        #endregion

        #region MetodosAbstratos

        #endregion
    }
}

