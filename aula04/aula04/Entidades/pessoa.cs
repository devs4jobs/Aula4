using System;
using System.Collections.Generic;
namespace aula04
{
    abstract class Pessoa
    {
        public string Nome;
        public int Idade;
        public DateTime Nascimento;
        public double RG;
        public Pessoa()
        {
        }
        public virtual void Registro(List<string> s)
        {
            Console.Clear();
            Console.WriteLine("Informe o nome:");
            Nome = Console.ReadLine().ToUpper();
            do
            {
                Console.WriteLine("Informe a Idade");
                int.TryParse(Console.ReadLine(),out Idade);
            } while (Idade <= 0 || Idade >= 110);
            Console.WriteLine("Informe a Data de nascimento(DD/MM/YYYY)");
            Nascimento = Convert.ToDateTime(Console.ReadLine());
            do
            {
                Console.WriteLine("Informe o RG:");
                double.TryParse(Console.ReadLine(), out RG);
            } while (RG == 0);
        }
        public override string ToString()
        {
            return $"Nome:{Nome}\nIdade:{Idade}\nData de Nascimento:{Nascimento.ToString("dd/MM/yyyy")}\nRG:{RG}";
        }
    }
}
