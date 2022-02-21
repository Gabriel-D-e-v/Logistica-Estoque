using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica_Estoque
{
    [System.Serializable]
    internal class Smartphone : Eletronicos, IEstoque
    {
        public string marca;
        public string cores;
        public string armazenamento;
        

        public Smartphone(string marca,string modelo,string armazenamento, string cores,float preco, float frete)
        {
            this.marca = marca;
            this.cores = cores;
            this.preco = preco;
            this.frete = frete;
            this.modelo = modelo;  
            this.armazenamento = armazenamento;
            
            
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
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Armazenamento: {armazenamento}");
            Console.WriteLine($"Cores: {cores}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine("=============");
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
