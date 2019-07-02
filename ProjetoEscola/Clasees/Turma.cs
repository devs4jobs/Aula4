using System.Collections.Generic;
using System;

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
            CodTurma = codigoTurma;
        }

        public Turma() { }

        public object CadastrarTurma(char cod)
        {

            Turma trm = new Turma(cod);
            Console.WriteLine($"Turma {cod} cadastrada com sucesso");
            return trm;
            
        }

    }
}
