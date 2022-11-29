using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto (int quantidade)
        {
            Quantidade += quantidade ;
        }
        public void RemoverProduto(int remove)
        {
            Quantidade -= remove ;
        }

        public override string ToString()
        {
            return Nome
                + "\n$"
                + Preco.ToString("F2")
                + "\n"
                + Quantidade
                + " unidades\nTotal: $"
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
