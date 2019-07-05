using System.Collections.Generic;
using System;

namespace ProjetoEscola.Clasees
{
    class Turma
    {

        public List<Aluno> lstAlunos = new List<Aluno>();
        public List<Professor> lstProfessores;
        public char CodTurma;

        #region Construtores
        public Turma(List<Professor> professores, List<Aluno> alunos, char codigoTurma)
        {
            lstAlunos = alunos;
            lstProfessores = professores;
            CodTurma = codigoTurma;
        }

        public Turma(char codigoTurma)
        {
            CodTurma = codigoTurma;
        }

        public Turma() { }

        #endregion

        #region MetodosDaClasse
        



       

        public void RemoverAluno()
        {
            foreach (Aluno alun in lstAlunos)
            {
                Console.WriteLine(alun);
                lstAlunos.Remove(alun);
            }
        }

        public void RemoverProfessor(int id)
        {
            foreach (Professor prof in lstProfessores)
            {
                // Console.WriteLine($"Qual Professor desseja remover? {prof.ID}");
                //Esse Console Write vai ensima desse metodo ! o usuario informa qual id ele quer eliminar o foreach procura o professor e assim ja excluimos ele !! 

                lstProfessores.Exists(x => x.ID == id);
                lstProfessores.Remove(prof);

            }

        }
        #endregion
    }
}