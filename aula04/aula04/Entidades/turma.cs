using System;
using System.Collections.Generic;
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
        //Registro de turma
        public void Registro(List<Professor> professor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (professor.Count != professors.Count)
            {
                if (Validacao == true)
                {   //Registro de turma para Professores
                    foreach (Professor P in professor)
                    {
                        if (!professors.Contains(P))
                            Console.WriteLine($"Nome:{P.Nome},N°:{P.NRProfessor}");
                    }
                    int i = 0;
                    do
                    {
                        Console.WriteLine("Digite o N° do professor:");
                        int NP = Convert.ToInt32(Console.ReadLine());
                        Professor a = professor.Find(x => x.NRProfessor == NP);
                        if (a != null)
                        {
                            if (!professors.Contains(a))
                            {
                                professors.Add(a);
                                i++;
                            }
                            else { Console.WriteLine("Professor ja esta na turma."); }
                        } else { Console.WriteLine("Professor não existe."); }
                    } while (i < 1);
                }
                else
                {
                    //Primeiro Registro da Turma
                    Console.WriteLine("Digite o nome da turma:");
                    Nome = Console.ReadLine().ToUpper();
                    Validacao = true;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Classe Registrada");
                }
            }
            else { Console.WriteLine("Registre mais professores. "); }
            Console.Clear();
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
    }

}
