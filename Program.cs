using LPR___Ana_e_Lucas.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPR___Ana_e_Lucas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando página de entrada 

            List<Jogo> ListadeJogo = new List<Jogo>();

            while (true)
            {



                Console.WriteLine("======BIBLIOTECA DE JOGO======");
                Console.WriteLine("");
                Console.WriteLine("1 - ADICIONAR JOGO");
                Console.WriteLine("2 - LISTAR JOGOS");
                Console.WriteLine("3 - EDITAR JOGO");
                Console.WriteLine("4 - REMOVER JOGO");
                Console.WriteLine("");
                Console.WriteLine("OPCAO: ");
                String opcao = Console.ReadLine();

                bool resultado;

                if (opcao == "1")
                {
                    resultado = AdicionarJogo(ListadeJogo);

                    if (resultado == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Cadastrado com Sucesso!");
                        Console.WriteLine("");
                        Console.WriteLine("Pressione ENTER para continuar!");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Erro no Cadastro");
                        Console.WriteLine("Pressione ENTER para continuar!");
                        Console.ReadLine();
                    }
                }
                else if (opcao == "2")
                {
                    resultado = ListarJogos(ListadeJogo);
                }
                else if (opcao == "4")
                {
                    resultado = DeletarJogo(ListadeJogo);

                }

            }

        }
        public static bool AdicionarJogo(List < Jogo > ListadeJogo)
        {
            Console.Clear();           
            Console.Write("Titulo: ");
            String titulo = Console.ReadLine();           
            Console.WriteLine("");
            Console.Write("Gênero: ");
            String genero = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Data de Lançamento: ");
            int data = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("");
            Console.Write("Número Máximo de Jogadores: ");
            int maxJogadores = Convert.ToInt32(Console.ReadLine());

            if (titulo == "") return false;
            if (genero == "") return false;
            if (data < 1950) return false;
            if (maxJogadores < 1) return false;

            Jogo novojogo = new Jogo(titulo, data, genero, maxJogadores);

            ListadeJogo.Add(novojogo);
            Console.Beep();

            return true;          
        }

        public static bool ListarJogos(List<Jogo> ListadeJogo)
        {
            Console.Clear();
            Console.WriteLine("JOGOS ADICIONADOS: ");
            Console.WriteLine("");

            foreach (Jogo jogo in ListadeJogo)
            {
                Console.Write("Jogo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano de lançamento: ");
                Console.WriteLine(jogo.getData());
                Console.Write("Gênero: ");
                Console.WriteLine(jogo.getGenero());
                Console.Write("Número máximo de jogadores: ");
                Console.WriteLine(jogo.getMaxJogadores());            
                Console.WriteLine("================================================================================================");
                Console.WriteLine("");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadLine();
            return true;
        }
        public static bool DeletarJogo(List<Jogo> ListadeJogo)
        {
            foreach (Jogo jogo in ListadeJogo)
            { 
                if()
                {

                }
            }
                return true;
        }
    }
}
