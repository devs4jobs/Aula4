using System;
using System.Collections.Generic;

namespace aula04
{
    class Aluno : Pessoa
    {
        public int RA;
        public bool Validar;
        public Aluno()
        {

        }
        public override void Registro(List<string> s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Registro(s);
            Random R = new Random();
            RA = R.Next(10000000, 99999999);
        }
        //Registro de Turma para Aluno
        public void RegistrarT(List<Turma> turma, Aluno a)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (Validar)
            {
                Console.Clear();
                Console.WriteLine("Aluno ja esta em uma turma\n");
            }
            else
            {
                foreach (var T in turma)
                {
                    Console.WriteLine($"Turma:{T.Nome}");
                }
                while (a.Validar == false)
                {
                    Console.WriteLine("Qual turma o aluno ira?");
                    string s = Console.ReadLine().ToUpper();
                    Turma T = turma.Find(x => x.Nome == s);
                    if (T != null)
                    {
                        T.RegistraAluno(a);
                        a.Validar = true;
                    }
                    else { Console.WriteLine("Digite uma turma valida!"); }
                }
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"\nRA:{RA}";
        }
    }
}
