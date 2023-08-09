using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    public class Produto
    {
        private string nome;
        private double preco;
        private int quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public string Nome { get {  return nome; } }

        public double Preco { get { return preco;} }
        public int Quantidade { get {  return quantidade; } }

        public double ValorTotalEmEstoque()
        {
            return this.preco * this.quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.quantidade += quantidade;
        }
        public void RemoverProdutos (int quantidade)
        {
            if (this.quantidade > quantidade)
                this.quantidade -= quantidade;
            else
                Console.WriteLine("Operação inválida. Não há produtos suficientes no estoque para remover.");
        }
    }
}
