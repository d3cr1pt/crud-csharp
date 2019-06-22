using System;


namespace Projeto_SQL_Montador
{

    public class Strings
    {
        public static string GetContinuar()
        {
            return "Pressione (enter) para continuar";
        }
        public static string GetRetornar()
        {
            return "Pressione (enter) para retornar ";
        }
    }
    public class Comum
    {
        public static void JanelaPrincipal()
        {
            Janela(0, 28, 0, 118);
        }
        public static void Opção(int L1, int C1, int Show, string Texto)
        {
            Console.SetCursorPosition(C1, L1);
            Console.Write("[{0}] {1}", Show, Texto);
        }

        public static void Titulo(int Esquerda, int Topo, string Titulo)
        {
            Console.SetCursorPosition(Esquerda, Topo);
            Console.Write(Titulo);
        }

        public static void Janela(int L1, int L2, int C1, int C2)
        {
            int x;
            for (x = L1; x <= L2; x++)
            {
                Console.SetCursorPosition(C1, x); Console.Write("║");
                Console.SetCursorPosition(C2, x); Console.Write("║");
            }
            for (x = C1; x <= C2; x++)
            {
                Console.SetCursorPosition(x, L1); Console.Write("═");
                Console.SetCursorPosition(x, L2); Console.Write("═");
            }
            Console.SetCursorPosition(C1, L1); Console.Write("╔");
            Console.SetCursorPosition(C2, L1); Console.Write("╗");
            Console.SetCursorPosition(C1, L2); Console.Write("╚");
            Console.SetCursorPosition(C2, L2); Console.Write("╝");
        }

        public static void Setor(int C1, int C2, int L)
        {
            int x;
            for (x = C1 + 1; x < C2; x++)
            {
                Console.SetCursorPosition(x, L); Console.Write("═");
            }
            Console.SetCursorPosition(C1, L); Console.Write("╠");
            Console.SetCursorPosition(C2, L); Console.Write("╣");
        }

        public static void Separador(int L1, int L2, int C)
        {
            int x;
            for (x = L1 + 1; x < L2; x++)
            {
                Console.SetCursorPosition(C, x); Console.Write("║");
            }
            Console.SetCursorPosition(C, L1); Console.Write("╦");
            Console.SetCursorPosition(C, L2); Console.Write("╩");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(40, 10);
            Console.Write("Bem Vindo ao Montador de SQL!");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Menu1();
        }

        public static void Menu1()
        {
            Console.Clear();
            Comum.JanelaPrincipal();   //0,29,0,118
            Comum.Janela(5, 25, 20, 98);
            Comum.Setor(20, 98, 7);
            Comum.Setor(20, 98, 23);
            Comum.Titulo(51, 6, "Consultor SQL");
            Comum.Titulo(21, 24, "SELECT ");
            Comum.Separador(7, 23, 32);
            Comum.Separador(7, 23, 86);
            Comum.Opção(8, 33, 1, "Cursos");
            //Proxima (20) //Comum.Opção(20, 33, 10, "Proxima Página");
            //Anterior (21) //Comum.Opção(21, 33, 11, "Página Anterior");
            Comum.Opção(22, 33, 0, "Sair");
            Console.SetCursorPosition(28, 24); //Select
            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                opcao = 99;
            }
            switch(opcao)
            {
                case 1:
                    {
                        Cursos.Menu();
                        break;
                    }
                case 0:
                    {
                        Environment.Exit(0);
                        break;
                    }
                case 99:
                    {
                        Menu1();
                        break;
                    }
            }
            Console.ReadLine();
        }

        

        
    }

    public class Cursos
    {
        public static void Menu()
        {
            Console.Clear();
            Comum.JanelaPrincipal();
            Comum.Janela(8, 19, 20, 98);
            Comum.Setor(20, 98, 10);
            Comum.Setor(20, 98, 17);
            //Sobrando entre 11,16
            Comum.Titulo(47, 9, "Consultor SQL: Cursos");
            Comum.Opção(11, 21, 1, "Listar");
            Comum.Opção(12, 21, 2, "Criar");
            Comum.Opção(13, 21, 3, "Ler detalhes");
            Comum.Opção(14, 21, 4, "Editar");
            Comum.Opção(15, 21, 5, "Deletar");
            Comum.Opção(16, 21, 6, "Retornar");
            Comum.Titulo(21, 18, "SELECT ");
            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                opcao = 99;
            }
            switch (opcao)
            {
                case 99:
                    {
                        Menu();
                        break;
                    }
                case 1:
                    {
                        List();
                        break;
                    }
                case 2:
                    {
                        Create();
                        break;
                    }
                case 3:
                    {
                        Find();
                        break;
                    }
                case 4:
                    {
                        Update();
                        break;
                    }
                case 5:
                    {
                        Deletar();
                        break;
                    }
                case 6:
                    {
                        Program.Menu1();
                        break;
                    }
                default:
                    {
                        Menu();
                        break;
                    }
            }
        }

        public static void List()
        {
            Console.Clear();
            Comum.JanelaPrincipal();
            Comum.Janela(8, 20, 20, 98);
            Comum.Setor(20, 98, 10);
            Comum.Titulo(21, 9, "Gerador SQL: Cursos [Listar]");
            Comum.Titulo(21, 21, Strings.GetRetornar());
            string gerado;
            gerado = "SELECT * FROM ";
            gerado += "cursos";
            Comum.Titulo(21, 19, gerado);
            Console.ReadKey();
            Menu();
        }

        public static void Create()
        {
            Console.Clear();
            Comum.JanelaPrincipal();
            Comum.Janela(8, 20, 20, 98);
            Comum.Setor(20, 98, 10);
            Comum.Titulo(21, 9, "Gerador SQL: Cursos [Criar]");
            Comum.Titulo(21, 21, Strings.GetContinuar());
            Comum.Titulo(21, 11, "Digite o nome do curso: ");
            string nome = Console.ReadLine();
            Comum.Titulo(21, 12, "Digite a sigla do curso: ");
            string sigla = Console.ReadLine();
            string gerado;
            gerado = "INSERT INTO cursos (nome, sigla) VALUES ('";
            gerado += nome;
            gerado += "','";
            gerado += sigla;
            gerado += "')";
            Comum.Titulo(21, 21, Strings.GetRetornar());
            Comum.Titulo(21, 19, gerado);
            Console.ReadKey();
            Menu();
        }

        public static void Find()
        {
            Console.Clear();
            Comum.JanelaPrincipal();
            Comum.Janela(8, 20, 20, 98);
            Comum.Setor(20, 98, 10);
            Comum.Titulo(21, 9, "Gerador SQL: Cursos [Ler]");
            Comum.Titulo(21, 21, "Pressione (enter) para retornar");
            Comum.Titulo(21, 11, "Digite o ID: ");
            string id = Console.ReadLine();
            string gerado;
            gerado = "SELECT * FROM ";
            gerado += "cursos ";
            gerado += "WHERE id = '";
            gerado += id;
            gerado += "'";
            Comum.Titulo(21, 19, gerado);
            Console.ReadKey();
            Menu();
        }

        public static void Update()
        {
            Console.Clear();
            Comum.JanelaPrincipal();
            Comum.Janela(8, 20, 20, 98);
            Comum.Setor(20, 98, 10);
            Comum.Titulo(21, 9, "Gerador SQL: Cursos [Editar]");
            Comum.Titulo(21, 21, Strings.GetContinuar());
            Comum.Titulo(21, 11, "Digite o ID: ");
            string id = Console.ReadLine();
            string gerado;
            gerado = "UPDATE cursos SET id = ";
            gerado += id;
            gerado += " WHERE id = ";
            gerado += id;
            Comum.Titulo(21, 21, Strings.GetRetornar());
            Comum.Titulo(21, 19, gerado);
            Console.ReadKey();
            Menu();
        }

        public static void Deletar()
        {
            Console.Clear();
            Comum.JanelaPrincipal();
            Comum.Janela(8, 20, 20, 98);
            Comum.Setor(20, 98, 10);
            Comum.Titulo(21, 9, "Gerador SQL: Cursos [Deletar]");
            Comum.Titulo(21, 21, Strings.GetContinuar());
            Comum.Titulo(21, 11, "Digite o ID: ");
            string id = Console.ReadLine();
            string gerado;
            gerado = "DELETE FROM cursos WHERE id = ";
            gerado += id;
            Comum.Titulo(21, 21, Strings.GetRetornar());
            Comum.Titulo(21, 19, gerado);
            Console.ReadKey();
            Menu();
        }
    }
}
