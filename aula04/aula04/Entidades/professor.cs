using System;
using System.Collections.Generic;
using System.Globalization;
namespace aula04
{
    class Professor : Pessoa
    {
        public int NRProfessor;
        public List<string> Materias = new List<string>();

        public Professor()
        {
        }
        //Registro Professor 
        public override void Registro(List<string> s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Registro(s);
            Random R = new Random();
            NRProfessor = R.Next(10000000, 99999999);
            //Materias professor
            Console.WriteLine("Quantas materias o professor leciona:");
            int QMateria = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < QMateria)
            {
                Console.WriteLine("Materias Disponiveis:");
                foreach (string v in s)
                {
                    if (!Materias.Contains(v))
                        Console.WriteLine(v);
                }
                Console.WriteLine("Digite a materia que o professor leciona:");
                string Materia = Console.ReadLine().ToUpper();
                if (s.Contains(Materia))
                    if (!Materias.Contains(Materia))
                    {
                        Materias.Add(Materia);
                        i++;
                    }
                    else { Console.WriteLine("Informe uma materia valida."); }
                Console.Clear();
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"\nN° Professor:{NRProfessor}";
        }
        public void Link(List<Turma> T, Professor a)
        {
            Console.WriteLine();
            Console.WriteLine("Materias dadas");
            foreach (var v in Materias)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
            Console.WriteLine("Turmas:");
            foreach (Turma v in T)
            {
                if (v.professors.Contains(a))
                {
                    Console.WriteLine($"{v.Nome}");
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
