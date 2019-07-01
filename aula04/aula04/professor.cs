using System;
using System.Collections.Generic;

namespace aula04
{
    class Professor : Pessoa
    {
        public string NRProfessor;
        public List<string> Materias=new List<string>();
        public List<Turma> Turmas = new List<Turma>();

        public Professor()
        {

        }
        public override void Registro()
        {
            base.Registro();
            int i=0;
            Console.WriteLine("Digite o numero do professor:");
            NRProfessor = Console.ReadLine();
            Console.WriteLine("Quantas o professor leciona:");
            int QMateria = Convert.ToInt32(Console.ReadLine());
            while (i<QMateria) {
                Console.WriteLine("Digite a materia que o professor leciona:");
                string Materia = Console.ReadLine();
                Materias.Add(Materia);
            }

        }
        public override string ToString()
        {
            return base.ToString() + $"N° Professor:{NRProfessor}";
        }
        public void RegistraTurma(Turma T)
        {
            Turmas.Add(T);
        }
    }
}
