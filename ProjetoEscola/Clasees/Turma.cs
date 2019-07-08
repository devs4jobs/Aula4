using System.Collections.Generic;
using System;

namespace ProjetoEscola.Clasees
{
    class Turma
    {

        public List<Aluno> lstAlunos = new List<Aluno>();
        public List<Professor> lstProfessores = new List<Professor>();
        public string CodTurma;

        #region Construtores
        public Turma(List<Professor> professores, List<Aluno> alunos, string codigoTurma)
        {
            lstAlunos = alunos;
            lstProfessores = professores;
            CodTurma = codigoTurma;
        }

        public Turma(string codigoTurma)
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
        
       
        public void AddProfessor(Professor objProfessor)
        {
            lstProfessores.Add(objProfessor);
        }

        public void AddAuno(Aluno objAluno)
        {
            lstAlunos.Add(objAluno);
        }
        public void RemoverProfessor(int id)
        {
            foreach (Professor prof in lstProfessores)
            {
                
                //Esse Console Write vai encima desse metodo ! o usuario informa qual id ele quer eliminar o foreach procura o professor e assim ja excluimos ele !! 
                lstProfessores.Exists(x => x.ID == id);
                lstProfessores.Remove(prof);

            }

        }
        #endregion
    }
}