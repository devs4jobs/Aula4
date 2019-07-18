using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoEscola.Clasees;


namespace ProjetoEscola.Tela
{
    class TelaPrincipal
    {
        #region MenuPrincipal 
        public int MenuPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Beep();
 
            Console.WriteLine("\n\t\t============================== MENU DE REGISTRO ==============================\t\t");

            Console.WriteLine("\n\t\t\t\t\tDigite um Opção a ser feita ! :");
 

            Console.WriteLine("\n\t\t\t\t\t1 - Cadastrar Professores\n\t\t\t\t\t2 - Cadastrar Alunos\n\t\t\t\t\t3 - Cadastrar Turmas\n\t\t\t\t\t4 " +
            "- Para Menu de Exibição de turmas \n\t\t\t\t\t5 - Para Menu de Exibição de Professores\n\t\t\t\t\t" +
            "6 - Para Menu de Exibição de Alunos\n\t\t\t\t\t7 - Para Sair");

            Console.WriteLine();
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        #endregion

        #region MenuCadastroMateriasProfessor
        public int TelaCadastroMaterias(int quantidadeMaterias)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t============================ MENU DE MATÉRIAS ============================\t\t\n");
            Console.WriteLine("\t\t\t\t\tDigite um Opção a ser feita ! : \n\n");
            Console.WriteLine("\t\t\t\t\t1 - Português\n\t\t\t\t\t2 - Matemática\n\t\t\t\t\t3 - Ciências\n\t\t\t\t\t4 - Geografia\n\t\t\t\t\t5 - Artes\n\t\t\t\t\t6 - História\n\t\t\t\t\t7 - Ed.Física");
            Console.WriteLine();
            Console.Write("                                   ");
            int codMateria = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            return codMateria;
        }

        #endregion

        #region Program
        public void ProgramMethod(List<Turma> lstTurmas)
        {
            try
            {
                int op = MenuPrincipal();
                do
                {

                    if (op == 1)
                    {
                        Console.Clear();
                        Console.Write("Digite quantos Professores você deseja cadastrar: \n");
                        int N = Convert.ToInt32(Console.ReadLine());

                        if (N < 0)
                        {
                            while (N < 0 || N > 999999)
                            {

                                Console.WriteLine("Número de professores a ser cadastrados inválido!");
                                Console.Write("Digite quantos Professores você deseja cadastrar: \n");
                                N = Convert.ToInt32(Console.ReadLine());
                                int count = 1;
                                while (count == 1)
                                {
                                    try
                                    {
                                        Console.Write("\nDigite um Número de professores válido: ");
                                        N = Convert.ToInt32(Console.ReadLine());
                                        if (N > 0 || N < 100)
                                        {
                                            count = 2;
                                        }
                                        while (N < 0 || N >= 100)
                                        {

                                            bool parseOkay;
                                            Console.WriteLine("Insira uma quantidade válida \n");

                                            var valid = Console.ReadLine();
                                            int valor;
                                            parseOkay = int.TryParse(valid, out valor);

                                            if (parseOkay == true)
                                            {
                                                valor = int.Parse(valid);
                                                N = valor;
                                                count = 2;
                                            }
                                            else
                                            {
                                                valor = 111;
                                                N = valor;
                                                count = 1;
                                            }
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("ERRO ");
                                        count = 1;
                                    }
                                }

                            }
                        }

                        for (int i = 0; i < N; i++)
                        {
                            try
                            {

                                Professor prof = new Professor();
                                prof.Cadastrar(lstTurmas);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Erro Professor não cadastrado!");
                                i--;
                            }

                        }//Repetição Para Adicionar Professores a Lista !!
                    }
                    else if (op == 2)
                    {
                        Console.Write("Digite quantos Alunos você deseja cadastrar:  \n");
                        int N = Convert.ToInt32(Console.ReadLine());

                        if (N < 0)
                        {
                            while (N < 0 || N > 999999)
                            {

                                Console.WriteLine("Número de Alunos a ser cadastrados inválido!");
                                Console.Write("Digite quantos Alunos você deseja cadastrar: \n");
                                N = Convert.ToInt32(Console.ReadLine());
                                int count = 1;
                                while (count == 1)
                                {
                                    try
                                    {
                                        Console.Write("\nDigite um Número de Alunos válido: ");
                                        N = Convert.ToInt32(Console.ReadLine());
                                        if (N > 0 || N < 100)
                                        {
                                            count = 2;
                                        }
                                        while (N < 0 || N >= 100)
                                        {

                                            bool parseOkay;
                                            Console.WriteLine("Insira uma quantidade válida \n");

                                            var valid = Console.ReadLine();
                                            int valor;
                                            parseOkay = int.TryParse(valid, out valor);

                                            if (parseOkay == true)
                                            {
                                                valor = int.Parse(valid);
                                                N = valor;
                                                count = 2;
                                            }
                                            else
                                            {
                                                valor = 111;
                                                N = valor;
                                                count = 1;
                                            }
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("ERRO ");
                                        count = 1;
                                    }
                                }

                            }
                        }

                        for (int i = 0; i < N; i++)
                        {
                            Console.Clear();
                            try
                            {
                                Aluno aluno = new Aluno();
                                aluno.Cadastrar(lstTurmas);

                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Erro Aluno não cadastrado");
                                i--;
                            }
                        }//Repetição Para Adicionar Professores a Lista !!
                    }
                    else if (op == 3)
                    {

                        Console.WriteLine("Insira o código da turma a ser cadastrado. Ex : A, B, C");
                        string CodTurma1 = Console.ReadLine().ToUpper();

                        Program.CadastrarTurma(CodTurma1, lstTurmas);

                    }
                    else if (op == 4)
                    {
                        if (!lstTurmas.All(t => t.CodTurma == null))
                        {
                            Console.WriteLine("DESEJA EXIBIR 1 - PARA PROFESSORES OU 2 - PARA ALUNOS \n");
                            int opecao = Convert.ToInt32(Console.ReadLine());
                            if (opecao == 1)
                            {
                                Console.WriteLine("Qual turma deseja ver a lista de professores? ");
                                string codTurma = Console.ReadLine().Trim();
                                lstTurmas.Where(t => t.CodTurma == codTurma).Select(t => t.lstProfessores).ToList();
                                foreach (Turma turma in lstTurmas)
                                {
                                    foreach (Professor prof in turma.lstProfessores)
                                    {
                                        if (turma.lstProfessores.Count >= 0)
                                            Console.WriteLine(prof);
                                        else
                                            Console.WriteLine("Não tem nenhum professor cadastrado!");
                                    }
                                }
                            }
                            else if (opecao == 2)
                            {
                                foreach (Turma turma in lstTurmas)
                                {
                                    foreach (Aluno aluno in turma.lstAlunos)
                                    {
                                        if (turma.lstAlunos.Count >= 0)
                                            Console.WriteLine(aluno);
                                        else
                                            Console.WriteLine("Não tem nenhum aluno cadastrado!");

                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(" Não Existe nenhuma turma cadastrada ainda !");
                        }

                    }

                    else if (op == 5)
                    {
                        Console.WriteLine("RafaTheus agradece e volte sempre!");
                        Console.ReadKey();
                    }
                } while (op != 5 || op > 5);


                Program.JsonSelialize(lstTurmas);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        #region MenuProfessor
        public void MenuProfessor(List<Turma> lstTurmas)
        {
            Console.Clear();
            Console.Write("Digite quantos Professores você deseja cadastrar: \n");
            int N = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 0; i < N; i++)
            {
                try
                {

                    Professor prof = new Professor();
                    prof.Cadastrar(lstTurmas);
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro Professor não cadastrado!");
                    i--;
                }

            }//Repetição Para Adicionar Professores a Lista !!
        }
        #endregion

        #region MenuAluno
        public void MenuAluno(List<Turma> lstTurmas)
        {
            Console.Write("Digite quantos Alunos você deseja cadastrar:  \n");
            int N = Convert.ToInt32(Console.ReadLine());

            //if (N < 0)
            //{
            //    while (N < 0 || N > 999999)
            //    {

            //        Console.WriteLine("Número de Alunos a ser cadastrados inválido!");
            //        Console.Write("Digite quantos Alunos você deseja cadastrar: \n");
            //        N = Convert.ToInt32(Console.ReadLine());
            //        int count = 1;
            //        while (count == 1)
            //        {
            //            try
            //            {
            //                Console.Write("\nDigite um Número de Alunos válido: ");
            //                N = Convert.ToInt32(Console.ReadLine());
            //                if (N > 0 || N < 100)
            //                {
            //                    count = 2;
            //                }
            //                while (N < 0 || N >= 100)
            //                {

            //                    bool parseOkay;
            //                    Console.WriteLine("Insira uma quantidade válida \n");

            //                    var valid = Console.ReadLine();
            //                    int valor;
            //                    parseOkay = int.TryParse(valid, out valor);

            //                    if (parseOkay == true)
            //                    {
            //                        valor = int.Parse(valid);
            //                        N = valor;
            //                        count = 2;
            //                    }
            //                    else
            //                    {
            //                        valor = 111;
            //                        N = valor;
            //                        count = 1;
            //                    }
            //                }
            //            }
            //            catch (Exception)
            //            {
            //                Console.WriteLine("ERRO ");
            //                count = 1;
            //            }
            //        }

            //    }
            //}

            for (int i = 0; i < N; i++)
            {
                Console.Clear();
                try
                {
                    Aluno aluno = new Aluno();
                    aluno.Cadastrar(lstTurmas);

                }
                catch (Exception)
                {
                    Console.WriteLine("Erro Aluno não cadastrado");
                    i--;
                }
            }//Repetição Para Adicionar Professores a Lista !!
        }
        #endregion

        #region ManuTurma
        public void MenuTurma(List<Turma> lstTurmas)
        {
            Console.WriteLine("Insira o código da turma a ser cadastrado. Ex : A, B, C");
            string CodTurma1 = Console.ReadLine().ToUpper();

            Program.CadastrarTurma(CodTurma1, lstTurmas);
        }
        #endregion

        #region ExibirTurmas

        public void ExbirTurmas(List<Turma> lstTurmas)
        {
            if (!lstTurmas.All(t => t.CodTurma == null))
            {
                foreach (Turma item in lstTurmas)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine(" Não Existe nenhuma turma cadastrada ainda !");
            }
        }

        #endregion

        #region ExibirProfessores

        public void ExibirProfessores(List<Turma> lstTurmas)
        {
            Console.WriteLine("Você optou por ver a lista de professores!");
            if (lstTurmas.All(t => t.lstProfessores.Count >= 0))
            {
                
                    Console.WriteLine("Qual Codigo da Turma ?");
                    string codTurma = Console.ReadLine().Trim();
                    var turmas = lstTurmas.Where(t => t.CodTurma == codTurma).ToList();
                    foreach (var turma in turmas)
                    {
                        foreach (var prof in turma.lstProfessores)
                        {
                            if (turma.lstProfessores.Count >= 0)
                                Console.WriteLine(prof);
                            else
                                Console.WriteLine("Não tem nenhum professor cadastrado!");
                        }
                    }
                }
            else
            {
                Console.WriteLine(" Não Existe nenhuma turma cadastrada ainda !");
            }
        }

        #endregion

        #region ExibirAlunos

        public void ExibirAlunos(List<Turma> lstTurmas)
        {
            Console.WriteLine("Você optou por ver a lista de alunos!");
            if (lstTurmas.All(t => t.lstAlunos.Count >= 0))
            {
                Console.WriteLine("Qual Codigo da Turma ?");
                string codTurma = Console.ReadLine().Trim();
                var turmas = lstTurmas.Where(t => t.CodTurma == codTurma);
                foreach (var turma in turmas)
                {
                    foreach (var  aluno in turma.lstAlunos)
                    {
                        if (turma.lstAlunos.Count >= 0)
                            Console.WriteLine(aluno);
                        else
                            Console.WriteLine("Não tem nenhum aluno cadastrado!");
                    }
                }
            }
            else
            {
                Console.WriteLine(" Não Existe nenhuma turma cadastrada ainda !");
            }
        }

        #endregion

        #region Despedida 

     public void Despedida()
       {
           Console.WriteLine("RafaTheus agradece e volte sempre!");
           Console.ReadKey();
       }

        #endregion
    }
}
