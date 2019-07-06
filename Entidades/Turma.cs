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

        // metodo para diicionar alunos e professores nas turmas
        public void AddAlunos(Aluno alunos)
        {
            lstAlunos.Add(alunos);
        }

        public void AddProfessores(Professor professores)
        {
            lstProfessors.Add(professores);
        }

        // metodo para definir a turma
        public void CadastrarTurma(string opcao)
        {
            if (opcao == "A") { NomeTurma = "Turma A"; CodTurma = "A"; }
            else if (opcao == "B") { NomeTurma = "Turma B"; CodTurma = "B"; }
            else if (opcao == "C") { NomeTurma = "Turma C"; CodTurma = "C"; }
            else if (opcao == "D") { NomeTurma = "Turma D"; CodTurma = "D"; }
            else if (opcao == "E") { NomeTurma = "Turma E"; CodTurma = "E"; }

        }
        // metodos para exibir alunos e professores
        public void MostrarAlunos()
        {
            if (lstAlunos.Count > 0)
            {

                foreach (Aluno alunos in lstAlunos)
                {
                    Console.WriteLine("LISTA DE ALUNOS");
                    Console.WriteLine($"NOME: {alunos.Nome}");
                    Console.WriteLine($"ID: {alunos.Ra}");
                }
            }
            else
                Console.WriteLine("NAO HÁ ALUNOS REGISTRADOS");
        }
        public void MostrarProfessores()
        {
            if (lstProfessors.Count > 0)
            {
                foreach (Professor professors in lstProfessors)
                {
                    Console.WriteLine("LISTA DE PROFESSORES!");
                    Console.WriteLine($"NOME: {professors.Nome} ");
                    Console.WriteLine($"ID: {professors.Identificacao}");

                }
            }
            else
                Console.WriteLine("NAO HÁ PROFESSORES REGISTRADOS");
        }
    }
}
