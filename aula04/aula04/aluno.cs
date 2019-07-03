using System;
using System.Collections.Generic;
using System.IO;

namespace aula04
{
    class Aluno : Pessoa
    {
        public int RA;
        public List<string> Disciplinas = new List<string>();
        public Turma Atual;
        public bool Validar;
        public Aluno()
        {
         
        }
        public override void Registro(List<string>s)
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Registro(s);
            Random R = new Random();
            RA = R.Next(10000000, 99999999);
            bool C;
            do
            {
                Console.WriteLine("Materias Disponiveis");
                foreach (string v in s)
                {
                    if (!Disciplinas.Contains(v))
                        Console.WriteLine(v);
                }
                Console.WriteLine("Informe a disciplina:");
                string A = Console.ReadLine().ToUpper();
                if (s.Contains(A))
                    if (!Disciplinas.Contains(A))
                        Disciplinas.Add(A);
                    else Console.WriteLine("Materia ja esta cadastrada");
                else Console.WriteLine("Materia Invalida");
                Console.WriteLine("O aluno tera outra disciplina?(S/N)");
                C = Console.ReadLine().ToLower().Contains("s");
                Console.Clear();
            } while (C == true);
            Console.ForegroundColor = aux;
        }
        //Registro de Turma para Aluno
        public void RegistrarT(List<Turma> turma)
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            if (Atual == null)
            {
                foreach (var T in turma)
                {
                    Console.WriteLine($"Turma:{T.Nome}");
                }
                while (Validar == false)
                {
                    Console.WriteLine("Qual turma o aluno ira?");
                    string s = Console.ReadLine().ToUpper();
                    foreach (var T in turma)
                    {
                        if (T.Nome == s)
                        {
                            T.RegistraAluno(this);
                            Atual = T;
                            Validar = true;
                        }
                        else { Console.WriteLine("Digite uma turma valida!"); }
                    }
                }
            }
            else { Console.WriteLine("O Aluno ja esta em uma turma."); }
            Console.ForegroundColor = aux;
        }
        public override string ToString()
        {
            return base.ToString()+ $",RA:{RA}";
        }
        //Escrita Arquivo
        public void Lista(StreamWriter s)
        {
            foreach (string v in Disciplinas)
            {
                s.WriteLine(v);
            }
        }
    }
}
