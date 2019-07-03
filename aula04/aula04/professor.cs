using System;
using System.Collections.Generic;
using System.IO;
namespace aula04
{
    class Professor : Pessoa
    {
        public int NRProfessor;
        public double Salario;
        public List<string> Materias=new List<string>();
        public List<Turma> Turmas = new List<Turma>();

        public Professor()
        {
        }
        //Registro Professor 
        public override void Registro(List<string>s)
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            base.Registro(s);
            Random R = new Random();
            NRProfessor = R.Next(10000000, 99999999);
            //Materias professor
            Console.WriteLine("Quantas materias o professor leciona:");
            int QMateria = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < QMateria)
            {
                Console.WriteLine("Materias Disponiveis");
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
                Console.Clear();
            }
            //Loop para Salario
            do
            {
                Console.WriteLine("Quanto de Salario:");
                Salario = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = aux;
            } while (Salario <= 0);
        }
        public override string ToString()
        {
            return base.ToString() + $",N° Professor:{NRProfessor}";
        }
        //Registro das Turmas 
        public void RegistraTurma(Turma T)
        {
            Turmas.Add(T);
        }
        //Escrita Arquivos 
        public void Lista(StreamWriter s)
        {
            foreach (string v in Materias)
            {
                s.WriteLine(v);
            }
        }
    }
}
