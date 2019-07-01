using System.Collections.Generic;

namespace ProjetoEscola
{
    class Turma 
    {
        public List<Aluno> lstAlunos;
        public List<Professor> lstProfessores;
        public char CodTurma; 

        public Turma (List<Professor> professores , List<Aluno> alunos, char codigoTurma)
        {
            lstAlunos = alunos;
            lstProfessores =  professores;
            CodTurma = codigoTurma;
        }
        public Turma(char codigoTurma) {
            this.CodTurma = codigoTurma;
        }

        public Turma() { }
    }
}
