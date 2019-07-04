using System;
using System.Collections.Generic;
namespace aula04
{
    abstract class Pessoa
    {
        public string Nome;
        public int Idade;
        public DateTime Nascimento;
        public ulong RG;
        public Pessoa()
        {
        }
        public virtual void Registro(List<string>s)
        {
            Console.WriteLine("Informe o nome:");
            Nome = Console.ReadLine().ToUpper();
            do
            {   Console.WriteLine("Informe a Idade");
                Idade = Convert.ToInt32(Console.ReadLine());
            } while (Idade <= 0||Idade>=110);
            Console.WriteLine("Informe a Data de nascimento(DD/MM/YYYY)");
            Nascimento = Convert.ToDateTime(Console.ReadLine());
            do
            {   try
                {
                    Console.WriteLine("Informe o RG:");
                    RG = Convert.ToUInt64(Console.ReadLine());
                    if (RG <= 10000000) { Console.WriteLine("Informe RG Valido"); }
                }
                catch (Exception){Console.WriteLine("Informe RG valido");}
            } while (RG <= 10000000);
        }
        public override string ToString()
        {
            return $"Nome:{Nome}\nIdade:{Idade}\nData de Nascimento:{Nascimento.ToString("dd/MM/yyyy")}\nRG:{RG}";
        }
    }
}
