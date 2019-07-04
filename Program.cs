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
            List<Turma> lstTurmas = new List<Turma>();

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

            //while (decisao = 2 && decisao != 1)
            //{
            //    Console.WriteLine("Erro escolha uma opção válida!");
            //    Console.WriteLine("");
            //    decisao = int.Parse(Console.ReadLine());
            //    Console.WriteLine("");
            //}


            #region "Lógica"
            int decisao=1, i = 0, N;


            d.MudarCores();
            Console.WriteLine("QUANTAS TURMAS DESEJA CADASTRAR? ");
            Console.WriteLine("");
            d.MudarCores1();
            N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {
                Console.WriteLine("QUAL TURMA DESEJA CADASTAR ? A,B,C,D OU E ?");
                string c = Console.ReadLine().ToUpper();

                Turma turma1 = new Turma();
                turma1.CadastrarTurma(c);

                lstTurmas.Add(turma1);

            }

          
            while (decisao == 2 || decisao == 1 || decisao == 3)
            {
                Console.WriteLine("");
                d.MudarCores2();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");

                d.WriteLineCenter("                DIGITE 1 PARA ALUNO / DIGITE 2 PARA PROFESSOR   / 3 PARA CADASDASTRAR TURMA                   \n");

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
                        try
                        {
                            Aluno aluno = new Aluno();
                            aluno.Cadastrar(lstTurmas);
                            turma.AddAlunos(aluno);

                         
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
                        professor.Cadastrar(lstTurmas);

                        turma.AddProfessores(professor);             

                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Erro, insira informações validas!");
                        i--;
                    }

                }


            }
                else if(decisao == 3) {

                    d.MudarCores();
                    Console.WriteLine("QUANTAS TURMAS DESEJA CADASTRAR? ");
                    Console.WriteLine("");
                    d.MudarCores1();
                    N = int.Parse(Console.ReadLine());

                    for (i = 0; i < N; i++)
                    {
                        Console.WriteLine("QUAL TURMA DESEJA CADASTAR ? A,B,C,D OU E ?");
                        string c = Console.ReadLine().ToUpper();

                        Turma turma1 = new Turma();
                        turma1.CadastrarTurma(c);

                        lstTurmas.Add(turma1);

                    }
                }
                StreamWriter sw2 = new StreamWriter(@"C:\Users\Treinamento 5\Desktop\txtarquivo\txt");
                // foreach (Aluno alunos in turma.lstAlunos)
                // {
                string g2 = JsonConvert.SerializeObject(lstTurmas);
                sw2.WriteLine($"LISTA DE ALUNOS: { g2}  \n");
                // }
                sw2.Close();


            }



        }
            #endregion

            // precisa iniciar com uma turma existente e dentro desta turma deve conter professor, aluno e materias

        }


    
} 
