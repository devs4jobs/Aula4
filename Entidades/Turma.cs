using System;
using System.Collections.Generic;


namespace CadastroEscolar.Entidades
{
    public class Turma
    {
        public string NomeTurma { get; set; }
        public string CodTurma { get; set; }
        public List<Aluno> LstAlunos { get; set; } = new List<Aluno>();
        public List<Professor> LstProfessors { get; set; } = new List<Professor>();

        public Turma()
        {

        }
       

        // metodo para diicionar alunos e professores nas turmas
        public void AddAlunos(Aluno alunos)
        {
            LstAlunos.Add(alunos);
        }

        public void AddProfessores(Professor professores)
        {
            LstProfessors.Add(professores);
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
            if (LstAlunos.Count > 0)
            {

                foreach (Aluno alunos in LstAlunos)
                {
                    Console.WriteLine("LISTA DE ALUNOS");
                    Console.WriteLine($"NOME: {alunos.Nome}");
                    Console.WriteLine($"ID: {alunos.Ra}");
                    Console.WriteLine("");
                }
            }
            else
                Console.WriteLine("NAO HÁ ALUNOS REGISTRADOS");
        }
        public void MostrarProfessores()
        {
            if (LstProfessors.Count > 0)
            {
                foreach (Professor professors in LstProfessors)
                {
                    Console.WriteLine("LISTA DE PROFESSORES!");
                    Console.WriteLine($"NOME: {professors.Nome} ");
                    Console.WriteLine($"ID: {professors.Identificacao}");

                }
            }
            else
                Console.WriteLine("NAO HÁ PROFESSORES REGISTRADOS");
        }
        public void MostrarTurmas(List<Turma> turmas) {
            foreach (Turma Turma in turmas)
            {
                Console.WriteLine("LISTA DE TURMAS");
                Console.WriteLine($"TURMAS: {Turma.NomeTurma} Codigo {Turma.CodTurma} ");
            }
        }

    }
}
