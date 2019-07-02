using System;
using System.Collections.Generic;
namespace aula04
{
    abstract class Pessoa
    {
        public string Nome;
        public int Idade;
        public DateTime Nascimento;
        public string RG;
        public Pessoa()
        {
        }
        public virtual void Registro(List<string>s)
        {
            Console.WriteLine("Informe o nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Informe a Idade");
            Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a Data de nascimento");
            Nascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Informe o RG:");
            RG = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Nome:{Nome}\nIdade:{Idade}\nData de Nascimento:{Nascimento.ToString("dd/MM/yyyy")}\nRG:{RG}";
        }
    }
}
