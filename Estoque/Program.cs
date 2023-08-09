using Estoque;
using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o nome do produto:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o preço do produto:");
        double preco = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade do produto em estoque:");
        int quantidade = int.Parse(Console.ReadLine());

        Produto produto = new Produto(nome, preco, quantidade);

        MostrarDadosDoProduto(produto);

        Console.WriteLine("Quantos produtos você gostaria de adicionar ao estoque?");
        int quantidadeParaAdicionar = int.Parse(Console.ReadLine());
        produto.AdicionarProdutos(quantidadeParaAdicionar);
        MostrarDadosDoProduto(produto);

        Console.WriteLine("Quantos produtos você gostaria de remover do estoque?");
        int quantidadeParaRemover = int.Parse(Console.ReadLine());
        produto.RemoverProdutos(quantidadeParaRemover);
        MostrarDadosDoProduto(produto);
    }
    static void MostrarDadosDoProduto(Produto produto)
    {
        Console.WriteLine("\nDados do Produto:");
        Console.WriteLine("Nome: " + produto.Nome);
        Console.WriteLine($"Preço: {produto.Preco:C}");
        Console.WriteLine("Quantidade em estoque: " + produto.Quantidade);
        Console.WriteLine($"Valor total no estoque: {produto.ValorTotalEmEstoque():C}" + "\n");
    }
}