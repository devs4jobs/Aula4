using System;
using System.Collections.Generic;
using System.IO;
namespace aula04
{
    class Turma 
    {
        public string Nome;
        public List<Aluno> aluno = new List<Aluno>();
        public List<Professor> professors = new List<Professor>();
        public bool Validacao;
        public Turma()
        {
        }
        //Registro de turma para Professores
        public void Registro(List<Professor> professor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (Validacao==true)
            {
                foreach(Professor P in professor)
                {   if(!professors.Contains(P))
                        Console.WriteLine($"Nome:{P.Nome},N°:{P.NRProfessor}");
                }
                Console.WriteLine("Digite o N° do professor:");
                int NP = Convert.ToInt32(Console.ReadLine());
                foreach (var p in professor)
                {
                    if (NP == p.NRProfessor)
                    {
                        if (!professors.Contains(p))
                        {
                            professors.Add(p);
                            p.RegistraTurma(this);
                        }
                    }
                }
            }
            else
            {
                //Primeiro Registro da Turma
                Console.WriteLine("Digite o nome da turma:");
                Nome = Console.ReadLine().ToUpper();
                Validacao = true;
                Console.Clear();
            }
            Console.ResetColor();
        }
        //Registra aluno
        public void RegistraAluno(Aluno aluno1)
        {
            aluno.Add(aluno1);
        }
        public override string ToString()
        {
            return $"Turma:{Nome},Validacao:{Validacao}";
        }
        //Escrita Arquivo
        public void Lista(StreamWriter s)
        {
            s.WriteLine("Alunos");
            foreach(Aluno a in aluno)
            {
                s.WriteLine($"Aluno:{a.Nome} RA:{a.RA}");
            }
            s.WriteLine();
            s.WriteLine("Professores");
            foreach (Professor a in professors)
            {
                s.WriteLine($"Professor:{a.Nome} N°Professor:{a.NRProfessor}");
            }
        }
        public void RegistrarT(List<Turma> turma,Aluno a)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (a.Atual == null)
            {
                foreach (var T in turma)
                {
                    Console.WriteLine($"Turma:{T.Nome}");
                }
                while (a.Validar == false)
                {
                    Console.WriteLine("Qual turma o aluno ira?");
                    string s = Console.ReadLine().ToUpper();
                    foreach (var T in turma)
                    {
                        if (T.Nome == s)
                        {
                            T.RegistraAluno(a);
                            a.Atual = T;
                            a.Validar = true;
                        }
                        else { Console.WriteLine("Digite uma turma valida!"); }
                    }
                }
            }
            else { Console.WriteLine("O Aluno ja esta em uma turma."); }
            Console.ResetColor();
        }
    }
}
