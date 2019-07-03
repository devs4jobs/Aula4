using System;
using CadastroEscolar.Entidades;
using CadastroEscolar.Entidades.Design;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

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

            while (decisao != 2 && decisao != 1)
            {
                Console.WriteLine("Erro escolha uma opção válida!");
                Console.WriteLine("");
                decisao = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            if (decisao == 1)
            {
                d.MudarCores();

                Console.WriteLine("QUANTOS ALUNOS DESEJA CADASTRAR?");

                Console.WriteLine("");
                d.MudarCores1();


                N = int.Parse(Console.ReadLine());


                for (i = 0; i < N; i++)
                {
                    try
                    {
                        Aluno aluno = new Aluno();
                        aluno.Cadastrar();
                        turma.AddAlunos(aluno);

                        StreamWriter sw2 = new StreamWriter(@"C:\Users\Treinamento 5\Desktop\txtarquivo\txt");
                        foreach (Aluno alunos in turma.lstAlunos)
                        {
                            string g2 = JsonConvert.SerializeObject(alunos);
                            sw2.WriteLine($"LISTA DE ALUNOS: { g2}  \n");
                        }
                        sw2.Close();

                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Erro, insira informações validas!");
                        i--;

                    }

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
                    try
                    {
                        Professor professor = new Professor();
                        professor.Cadastrar();

                        turma.AddProfessores(professor);

                        Console.WriteLine(professor.Nome);

                        StreamWriter sw1 = new StreamWriter(@"c:\users\treinamento 5\desktop\txtarquivo\txt2");
                        foreach (Professor professor1 in turma.lstProfessors)
                        {
                            string f = JsonConvert.SerializeObject(professor1);
                            sw1.WriteLine($"LISTA DE PROFESORES: {f}");
                        }
                        sw1.Close();

                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Erro, insira informações validas!");
                        i--;
                    }

                }

            }

            #endregion

            // precisa iniciar com uma turma existente e dentro desta turma deve conter professor, aluno e materias

        }


    }
}
