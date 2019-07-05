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
        
        //Console.WriteLine("\nPara quantas turmas você dará aula?");
        //int quantidade = Convert.ToInt32(Console.ReadLine());

        //lstTurmas = new List<Turma>();
        //   turma.lstProfessores = new List<Professor>();
        //   for (int i = 0; i < quantidade; i++)
        //   {

        //       Console.WriteLine("\nDigite qual o codigo da turma que vocÊ vai ensinar : EX: A, B, C.. ");
        //        string CodTurma = Console.ReadLine().ToUpper();

        //       if (lstTurma.Exists(x => x.CodTurma == CodTurma))
        //       {

        //           if (turma.lstProfessores.Exists(x => x.ID == ID)) { 
        //               Console.WriteLine(" já existe um professor com mesmo id nessa turma ");
        //           i--;
        //           }

        //       else
        //           turma.lstProfessores.Add(this);
        //           lstTurma.Add(turma);
        //           Console.WriteLine($"O {Nome} dara aula para Turma {CodTurma} ! ");
        //       }
        //       else
        //       {
        //           Program.CadastrarTurma(CodTurma, lstTurma);
        //           if (lstTurma.Exists(x => x.CodTurma == CodTurma))
        //               lstTurma.Add(turma);
        //       }
        //   }
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
                
                //Esse Console Write vai ensima desse metodo ! o usuario informa qual id ele quer eliminar o foreach procura o professor e assim ja excluimos ele !! 
                lstProfessores.Exists(x => x.ID == id);
                lstProfessores.Remove(prof);

            }

        }
        #endregion
    }
}