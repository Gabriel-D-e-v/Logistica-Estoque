using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica_Estoque
{
    [System.Serializable]
    internal class Notebook : Eletronicos, IEstoque
    {
        public string marca;
        public float tela;
        public string ssd;
        

        public Notebook(string modelo,string marca, float tela, string ssd, float preco, float frete)
        {
            this.marca = marca;
            this.tela = tela;
            this.ssd = ssd;
            this.preco = preco;
            this.frete = frete;
            this.modelo = modelo;
            
        }

        public void Entrada()
        {
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine("Digite a quantidade: ");
            int en = int.Parse(Console.ReadLine());
            estoque += en;

        }

        public void Exibir()
        {
            
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Tela: {tela}");
            Console.WriteLine($"SSD: {ssd}");   
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Estoque: {estoque}");

            Console.WriteLine("===========");
        }

        public void Saida()
        {
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine("Digite a quantidade: ");
            int en = int.Parse(Console.ReadLine());
            estoque -= en;
        }
    }
}
