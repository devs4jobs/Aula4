using System;
using System.Collections.Generic;
using System.Text;

namespace aula04
{
    class Aluno : Pessoa
    {
        public string RA;
        List<string> Disciplinas = new List<string>();
        public Turma Atual = new Turma();
        bool Validar;
        public Aluno()
        {
         
        }
        public override void Registro()
        {
            base.Registro();
            Console.WriteLine("Informe o RA:");
            RA = Console.ReadLine();
            bool C;
            do
            {
                Console.WriteLine("Informe a disciplina:");
                string A = Console.ReadLine();
                Disciplinas.Add(A);
                Console.WriteLine("O aluno tera outra disciplina?(S/N)");
                C = Console.ReadLine().ToLower().Contains("s");
                Console.Clear();
            } while (C == true);
            
        }
        public void RegistrarT(List<Turma> turma)
        {
            if (Atual == null)
            {
                foreach (var T in turma)
                {
                    Console.WriteLine($"Turma:{T.Nome}");
                }
                while (Validar == false)
                {
                    Console.WriteLine("Qual turma o aluno ira?");
                    string s = Console.ReadLine();
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
        }
    }
}
