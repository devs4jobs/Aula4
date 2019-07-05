using System;
using System.Collections.Generic;
using System.Text;


namespace CadastroEscolar.Entidades
{
   public class Turma
    {
        public string NomeTurma { get; set; }
        public string CodTurma { get; set; }
        public List<Aluno> lstAlunos { get; set; } = new List<Aluno>();
        public List<Professor> lstProfessors { get; set; } = new List<Professor>();
      
        public Turma()
        {

        }

        public Turma(string nomeTurma, string codTurma, List<Aluno> lstAlunos, List<Professor> lstProfessors)
        {
            NomeTurma = nomeTurma;
            CodTurma = codTurma;
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
 

        public void CadastrarTurma(string opcao)
        {
            if (opcao == "A") { NomeTurma = "Turma A"; CodTurma = "A"; }
            else if (opcao == "B") { NomeTurma = "Turma B"; CodTurma = "B"; }
            else if (opcao == "C") { NomeTurma = "Turma C"; CodTurma = "C"; }
            else if (opcao == "D") { NomeTurma = "Turma D"; CodTurma = "D"; }
            else if (opcao == "E") { NomeTurma = "Turma E"; CodTurma = "E"; }

        }
   
    }


}
