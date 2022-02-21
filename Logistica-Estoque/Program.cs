using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Logistica_Estoque
{
    [System.Serializable]
    internal class Program
    {
        
        static List<IEstoque> Eletronicos = new List<IEstoque>();
        enum Menu { Listagem = 1, Adicionar, Remover, Entrada, Saida, Sair };

        static void Main(string[] args)
        {
            Carregar();
            bool a = false;
            while (a == false)
            {
                Console.WriteLine("Gestor de Estoque de Eletronicos");
                Console.WriteLine("1-Listagem\n2-Adicionar\n3-Remover\n4-Entrada de Produto\n5-Saida de Produto\n6-Sair");
                int escolha = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)escolha;

                switch (opcao)
                {
                    case Menu.Listagem:
                        Listagem();
                        break;
                    case Menu.Adicionar:
                        Adicionar();
                        break;
                    case Menu.Remover:
                        Remover();
                        break;
                    case Menu.Entrada:
                        Entrada();
                        break;
                    case Menu.Saida:
                        Saida();
                        break;
                    case Menu.Sair:
                        a = true;
                        break;
                }

                Console.Clear();
            }




        }
        enum MenuA { PC = 1, Not, Smart }
        static void Adicionar()
        {

            Console.WriteLine("Escolha o Eletronico que desejar adicionar:");
            Console.WriteLine("1- Computador\n2- Notebook\n3- Smartphone");
            int op = int.Parse(Console.ReadLine());
            MenuA opcao = (MenuA)op;

            switch (opcao)
            {
                case MenuA.PC:
                    PC();
                    break;
                case MenuA.Not:
                    Not();
                    break;
                case MenuA.Smart:
                    Smart();
                    break;
            }



        }
        static void PC()
        {
            Console.WriteLine("Eletronico Selecionado: Computador ");
            Console.WriteLine("Modelo: ");
            string M = Console.ReadLine();
            Console.WriteLine("Monitor: ");
            string m = Console.ReadLine();
            Console.WriteLine("Quantidade de GB no HD: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Fonte: ");
            string F = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float p = float.Parse(Console.ReadLine());
            Console.WriteLine("Frete: ");
            float f = float.Parse(Console.ReadLine());
            

            Computador C = new Computador(M, m, h, F, p, f);
            Eletronicos.Add(C);
            Salvar();
            Console.WriteLine("Produdo Adicionado!");
            
        }
        static void Not()
        {
            Console.WriteLine("Eletronico Selecionado: Notebook ");
            Console.WriteLine("Modelo: ");
            string M = Console.ReadLine();
            Console.WriteLine("Fabricante: ");
            string F = Console.ReadLine();
            Console.WriteLine("Tela: ");
            float t = float.Parse(Console.ReadLine());
            Console.WriteLine("SSD: ");
            string s = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float p = float.Parse(Console.ReadLine());
            Console.WriteLine("Frete: ");
            float f = float.Parse(Console.ReadLine());
            

            Notebook N = new Notebook(M, F, t, s, p, f);
            Eletronicos.Add(N);
            Salvar();
            Console.WriteLine("Produto Adicionado!");

        }
        static void Smart()
        {
            Console.WriteLine("Eletronico Selecionado: Smartphone");
            Console.WriteLine("Marca: ");
            string M = Console.ReadLine();
            Console.WriteLine("Modelo: ");
            string m = Console.ReadLine();
            Console.WriteLine("Armazenamento: ");
            string a = Console.ReadLine();
            Console.WriteLine("Cores: ");
            string c = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float p = float.Parse(Console.ReadLine());
            Console.WriteLine("Frete: ");
            float f = float.Parse(Console.ReadLine());
            

            Smartphone S = new Smartphone(M, m,a, c, p, f);
            Eletronicos.Add(S);
            Salvar();
            Console.WriteLine("Produto Adicionado!");
        }
        static void Listagem()
        {
            int id = 0;
            if (Eletronicos.Count > 0)
            {
                Console.WriteLine("Eletronicos Cadastrados: \n");
                foreach (IEstoque e in Eletronicos)
                {

                    Console.WriteLine($"ID: { id++}");
                    e.Exibir();

                }
            }
            else
            {
                Console.WriteLine("Lista Vazia!");
            }
            Console.ReadLine();
        
        }
        static void Salvar()
        {
            FileStream stream = new FileStream("Empressa.dat", FileMode.OpenOrCreate);
            BinaryFormatter salvar = new BinaryFormatter();

            salvar.Serialize(stream, Eletronicos);
            stream.Close();

        }
          static void Carregar()
        {
            FileStream stream = new FileStream("Empressa.dat", FileMode.OpenOrCreate);
            BinaryFormatter salvar = new BinaryFormatter();

            Eletronicos = salvar.Deserialize(stream) as List<IEstoque>;
            stream.Close();

        }
    
        static void Remover()
        {
            Console.WriteLine("Digite o ID: \n");
            int id  = int.Parse(Console.ReadLine());

            
            if (id >= 0 && id <= Eletronicos.Count)
            {
                Eletronicos.RemoveAt(id);
                Salvar();
            }
            

        }
    
        static void Entrada ()
        {
            Console.WriteLine("Digite o ID: \n");
            int id = int.Parse(Console.ReadLine());
            
            if (id >= 0 && id <= Eletronicos.Count)
            {
                Eletronicos[id].Entrada();
                Salvar();
            }

        }
        static void Saida ()
        {
            Console.WriteLine("Digite o ID: \n");
            int id = int.Parse(Console.ReadLine());

            if (id >= 0 && id <= Eletronicos.Count)
            {
                Eletronicos[id].Saida();
                Salvar();
            }
        }
    }
}