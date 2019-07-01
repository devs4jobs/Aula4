using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroEscolar.Entidades
{
    class Turma
    {
        public List<Turma> lstTurmas { get; set; } = new List<Turma>();
        public List<Aluno> lstAlunos { get; set; } = new List<Aluno>();
        public List<Professor> lstProfessors { get; set; } = new List<Professor>();


        public Turma()
        {

        }

        public Turma(List<Aluno> lstAlunos, List<Professor> lstProfessors)
        {
            this.lstAlunos = lstAlunos;
            this.lstProfessors = lstProfessors;
        }

        public void AddAlunos(Aluno alunos)
        {
           lstAlunos.Add(alunos);
        }

        public void AddProfessores(Professor professores)
        {
            lstProfessors.Add(professores);
        }
        
      

    }


}
 