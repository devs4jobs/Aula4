using System;
using System.Collections.Generic;
using System.IO;
namespace aula04
{
    class Turma 
    {
        public string Nome;
        List<Aluno> aluno = new List<Aluno>();
        List<Professor> professors = new List<Professor>();
        Professor coordenador;
        bool Validacao;
        public Turma()
        {
        }
        public void Registro(List<Professor> professor)
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            if (coordenador != null)
            {
                
                for (int i = 0; i < professor.Count; i++)
                {   if(professor[i]!=coordenador)
                        Console.WriteLine($"Nome:{professor[i].Nome},N°:{professor[i].NRProfessor}");
                }
                Console.WriteLine("Digite o N° do professor:");
                string NP = Console.ReadLine().ToUpper();
                foreach (var p in professor)
                {
                    if (NP == p.NRProfessor)
                    {
                        professors.Add(p);
                        p.RegistraTurma(this);
                    }
                }
            }
            else
            {
                Console.WriteLine("Digite o nome da turma:");
                Nome = Console.ReadLine().ToUpper();
                while (Validacao == false)
                {
                    for (int i = 0; i < professor.Count; i++)
                    {
                        Console.WriteLine($"Nome:{professor[i].Nome},N°:{professor[i].NRProfessor}");
                    }
                    Console.WriteLine("Registre o professor Coordenador:");
                    string NP = Console.ReadLine().ToUpper();
                    foreach (var p in professor)
                    {
                        if (NP == p.NRProfessor)
                        {
                            coordenador = p;
                            p.RegistraTurma(this);
                            professors.Add(p);
                            Validacao = true;
                        }
                    }
                    if (coordenador == null) { Console.WriteLine("Digite um N° de professor valido"); }
                }
                Console.Clear();
            }
            Console.ForegroundColor = aux;
        }
        public void RegistraAluno(Aluno aluno1)
        {
            aluno.Add(aluno1);
        }
        public override string ToString()
        {
            return $"Turma:{Nome},Coordenador:{coordenador.Nome}";
        }
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
    }
}
