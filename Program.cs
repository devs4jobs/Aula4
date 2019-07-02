using System;
using CadastroEscolar.Entidades;
using CadastroEscolar.Entidades.Design;
namespace CadastroEscolar
{
    class Program
    {
        static void Main(string[] args)
        {


            Turma turma = new Turma();
            Designs d = new Designs();
            d.MudarBack();

            #region "HORA"
            DateTime tempo = DateTime.Now;
            tempo.ToString();
            Console.WriteLine("");
            d.MudarCores2();
          
            
            if (tempo.Hour >= 6 && tempo.Hour <= 12)
            {
                d.WriteLineCenter($"                               BOM DIA E SEJA BEM VINDO(A) AO SISTEMA, DIA: {DateTime.Now }                        ");

            }
            else if (tempo.Hour > 12 && tempo.Hour < 18)
            {
                d.WriteLineCenter($"                               BOA TARDE E SEJA BEM VINDO(A) AO SISTEMA DIA: {    tempo.ToString()}                        ");
            }

            else
                d.WriteLineCenter($"                               BOA NOITE E SEJA BEM VINDO(A) AO SISTEMA DIA: {DateTime.Now}                        ");

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            #endregion


            #region "Lógica"
           int decisao, i = 0, N;


            Console.WriteLine("");
            d.MudarCores2();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");

            d.WriteLineCenter("                                    DIGITE 1 PARA ALUNO / DIGITE 2 PARA PROFESSOR                                       \n");

            d.WriteLineCenter("------------------------------------------------------------------------------------------------------------------------");
            d.WriteLineCenter("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            decisao = int.Parse(Console.ReadLine());



            if (decisao == 1)
            {
                d.MudarCores();

                Console.WriteLine("QUANTOS ALUNOS DESEJA CADASTRAR?");

                Console.WriteLine("");
                d.MudarCores1();
                N = int.Parse(Console.ReadLine());

                for (i = 0; i < N; i++)
                {
                    Aluno aluno = new Aluno();
                    aluno.Cadastrar();
                    turma.AddAlunos(aluno);
                }
            }
            else if (decisao == 2)
            {
                d.MudarCores();
                Console.WriteLine("QUANTOS PROFESSORES DESEJA CADASTRAR? ");
                Console.WriteLine("");
                d.MudarCores1();
                N = int.Parse(Console.ReadLine());

                for (i = 0; i < N; i++)
                {
                    Professor professor = new Professor();
                    professor.Cadastrar();

                    turma.AddProfessores(professor);

                    Console.WriteLine(professor.Nome);
                }

            }
            #endregion
        }

        private static void Timer()
        {
            throw new NotImplementedException();
        }
    }
}
