using System;
using System.Collections.Generic;

namespace aula04.Service
{
    class Show
    {
        public void ShowRegistro(List<Aluno>Alu,List<Turma>Turmas)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            int Count=0;
            foreach (var g in Alu)
            {
                if (!g.Validar){ Console.WriteLine($"Nome do aluno:{g.Nome} RA:{g.RA}"); Count++;}
            }
            if (Count == 0){ Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Registre mais alunos!");}
            else
            {
                Console.WriteLine("Qual o RA do aluno?");
                int c = Convert.ToInt32(Console.ReadLine());
                Aluno v = Alu.Find(x => x.RA == c);
                if (v != null) { v.RegistrarT(Turmas, v); }
                else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Aluno não existe"); }
            }
        }
        public void ShowRegistro(List<Professor>Prof,List<Turma> Turmas)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Turma g in Turmas)
            {
                Console.WriteLine($"Nome da turma:{g.Nome}");
            }
            Console.WriteLine("Qual o nome da turma?");
            string c = Console.ReadLine().ToUpper();
            Turma v = Turmas.Find(x => x.Nome == c);
            if (v != null) { v.RegistroT(Prof); }
            else { Console.WriteLine("Turma não existe"); }
        }
        public void ShowA(List<Aluno> Alu)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Aluno(s):");
            foreach (var v in Alu)
            {
                Console.WriteLine($"Nome:{v.Nome},RA:{v.RA}");
            }
            Console.WriteLine("Informe o RA do aluno:");
            int g = Convert.ToInt32(Console.ReadLine());
            Aluno b = Alu.Find(x => x.RA == g);
            if (b != null)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(b.ToString());
            }
            else { Console.WriteLine("Aluno não existe."); }
            Console.ReadLine();
            Console.Clear();
        }
        public void ShowP(List<Professor> Prof,List<Turma>Turmas)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Professor(es):");
            foreach (var v in Prof)
            {
                Console.WriteLine($"Nome:{v.Nome},NR:{v.NRProfessor}");
            }
            Console.ResetColor();
            Console.WriteLine("Informe o NR do professor");
            int g = Convert.ToInt32(Console.ReadLine());
            Professor a = Prof.Find(x => x.NRProfessor == g);
            if (a != null)
            {   Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(a.ToString());
                a.Link(Turmas, a);
            }
            else { Console.WriteLine("Professor não existe"); }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
