using System;
using System.Collections.Generic;
namespace aula04
{
    class Turma
    {
        public string Nome;
        public List<string> aluno = new List<string>();
        public List<string> professors = new List<string>();
        public List<string> Materias = new List<string>();
        public bool Validacao;
        public Turma()
        {
        }
        //Registro de turma para Professores
        public void Registro(List<Professor> professor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (Validacao == true)
            {
                foreach (Professor P in professor)
                { if (!professors.Contains(P.Nome))
                        Console.WriteLine($"Nome:{P.Nome},N°:{P.NRProfessor}");
                }
                int i = 0;
                do
                {
                    Console.WriteLine("Digite o N° do professor:");
                    int NP = Convert.ToInt32(Console.ReadLine());
                    foreach (var p in professor)
                    {
                        if (NP == p.NRProfessor)
                        {
                            if (!professors.Contains(p.Nome))
                            {
                                professors.Add(p.Nome);
                                p.RegistraTurma(this);
                                i++;
                            }
                            else { Console.WriteLine("Informe um professor valido"); }
                        }
                    }
                    Console.WriteLine("Informe um prof valido");
                } while (i < 1);
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
            aluno.Add(aluno1.Nome);
        }
        public override string ToString()
        {
            return $"Turma:{Nome},Validacao:{Validacao}";
        }
    }
    
}
