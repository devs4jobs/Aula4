using System;
using System.Collections.Generic;

namespace ProjetoEscola.Clasees
{
    class Aluno : Pessoa
    {
        private Guid Matricula_ { get; set; }
        public Turma Turma;


        #region Construtores
        public Aluno(string nome, string genero, string nacionalidade, Guid matricula, string dataNascimento, string pais, string cidade, Turma turma)
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
            try
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
                Guid Matricula = Guid.NewGuid();
                Console.Write($"\nA Matricula(a) dele(a) é {Matricula} \n");
                Console.Write("\nDigite a idade : ");
                Idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nDigite a Data de Nascimento: ");
                DataNasc = Console.ReadLine();
                CadastrarCodigoTurma(lstTurmas);

                return this;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
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

            }
        }
        #endregion
    }
}

