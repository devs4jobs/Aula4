using System;
using System.Collections.Generic;

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
            if (coordenador != null)
            {
                professor.Remove(coordenador);
                for (int i = 0; i < professor.Count; i++)
                {
                    Console.WriteLine($"Nome:{professor[i].Nome},N°{professor[i].NRProfessor}");
                }
                Console.WriteLine("Digite o N° do professor:");
                string NP = Console.ReadLine();
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
                Nome = Console.ReadLine();
                while (Validacao == false)
                {
                    for (int i = 0; i < professor.Count; i++)
                    {
                        Console.WriteLine($"Nome:{professor[i].Nome},N°{professor[i].NRProfessor}");
                    }
                    Console.WriteLine("Registre o professor Coordenador:");
                    string NP = Console.ReadLine();
                    foreach (var p in professor)
                    {
                        if (NP == p.NRProfessor)
                        {
                            coordenador = p;
                            p.RegistraTurma(this);
                            professors.Add(p);

                        }
                    }
                    if (coordenador == null) { Console.WriteLine("Digite um N° de professor valido"); }
                    Console.Clear();
                }
            }
        }
        public void RegistraAluno(Aluno aluno1)
        {
            aluno.Add(aluno1);
        }
    }
}
