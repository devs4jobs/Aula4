using System;
using System.Collections.Generic;

namespace ProjetoEscola.Clasees
{
    class Aluno : Pessoa
    {
        private Guid Matricula_ { get; set; }
        public Turma Turma;


        #region Construtores
        public Aluno(string nome, string genero, string nacionalidade, Guid matricula, string dataNascimento, string pais, string cidade , Turma turma)
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


        public Guid Matricula
        {
            get { return Matricula_; }
            set {
                    Matricula_ = value;
            }
        }

        #endregion

        #region MetodosDaClasse



        #endregion

        #region MetodosAbstratos

        public override void Cadastrar(List<Turma> lstTurmas , Turma turma)
        {
          
            Console.Beep();
            Console.Write("Digite o nome do Aluno(a) : ");
            Nome = Console.ReadLine();
            Console.Write("\nDigite o Genero :  ");
            Sexo = Console.ReadLine();
            Console.Write("\nDigite a Nacionalidade:  ");
            Nacionaliddade = Console.ReadLine();
            Console.Write("\nDigite o Pais : ");
            Pais = Console.ReadLine();
            Console.Write("\nDigite a Cidade: ");
            Cidade = Console.ReadLine();
            Guid Matricula = Guid.NewGuid() ;
            Console.Write($"\nA Matricula(a) dele(a) é {Matricula} \n");
            Console.Write("\nDigite a idade : ");
            Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDigite a Data de Nascimento: ");
            DataNasc = Console.ReadLine();
            Console.WriteLine("\nDigite qual o codigo da turma que o aluno vai estar !! : EX: A, B, C.. ");
            string codTurma = Console.ReadLine().ToUpper();
            if (lstTurmas.Exists(x => x.CodTurma == codTurma))
            {
                turma.lstAlunos.Add(this);
                lstTurmas.Add(turma);
                Console.WriteLine($"\nO {Nome} foi inserido na Turma {codTurma} com Sucesso ! ");
            }
            else

                Program.CadastrarTurma(codTurma, lstTurmas);
                turma.lstAlunos.Add(this);
                lstTurmas.Add(turma);
        }

        public override string ToString()
        {

            return $"Nome do Aluno: {Nome} , Idade: {Idade} , Matrícula: {Matricula}";

        }

        public override void Cadastrar()
        {
            throw new NotImplementedException();
        }

        public override void CadastrarCodigoTurma(string codTurma)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

