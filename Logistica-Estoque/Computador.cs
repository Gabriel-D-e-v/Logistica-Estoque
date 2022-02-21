using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica_Estoque
{
      [System.Serializable]
     public class Computador : Eletronicos, IEstoque
    {
        
        public string monitor;
        public int hd;
        public string fonte;
        

        public Computador( string modelo, string monitor, int hd, string fonte, float preco, float frete)
        {
            this.monitor = monitor;
            this.hd = hd;
            this.fonte = fonte;
            this.modelo = modelo;
            this.preco = preco;
            this.frete = frete;
            
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
            Console.WriteLine($"Monitor: {monitor}");
            Console.WriteLine($"HD: {hd}");
            Console.WriteLine($"Fonte: {fonte}");
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
