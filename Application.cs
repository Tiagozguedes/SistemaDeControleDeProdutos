using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            double produtoMaisCaro = 0;
            Produto produto1 = null;
            Produto produto2 = null;

            int contador = 0;

            while (contador < 2)
            {
                Console.WriteLine("Digite o nome do produto:");
                string nomeProduto = Console.ReadLine();

                Console.WriteLine("Digite o preço unitário:");
                double precoUnitario;
                if (!double.TryParse(Console.ReadLine(), out precoUnitario))
                {
                    throw new ProdutoInvalidoException("Preço inválido. Digite um número válido.");
                }

                Console.WriteLine("Digite a quantidade:");
                int quantidade;
                if (!int.TryParse(Console.ReadLine(), out quantidade))
                {
                    throw new ProdutoInvalidoException("Quantidade inválida.");
                }

                Console.WriteLine("Digite o desconto:");
                int desconto;
                if (!int.TryParse(Console.ReadLine(), out desconto))
                {
                    throw new ProdutoInvalidoException("Desconto inválido.");
                }

                Produto produto = new Produto(nomeProduto, precoUnitario);

                if (produto == null)
                {
                    throw new ProdutoInvalidoException("Produto inválido.");
                }

                double custoTotal = produto.calcularPrecoTotal(quantidade);

                if (contador == 0)
                {
                    produto1 = produto;
                }
                else
                {
                    produto2 = produto;
                }

                List<Produto> produtos = new List<Produto>();
                produtos.Add(produto1);
                produtos.Add(produto2);

                if (desconto > 5000.00)
                {
                    double custoFinal = produto.calcularCustoFinal(quantidade, desconto);
                    Console.WriteLine($"Custo Total: {custoTotal}");
                    Console.WriteLine($"Custo Final: {custoFinal}");
                }
                else
                {
                    Console.WriteLine("Sem desconto aplicado.");
                    Console.WriteLine($"Custo Total: {custoTotal}");
                }

                Console.WriteLine(produto);

                contador++;
            }

            if (produto1 != null && produto2 != null)
            {
                if (produto1.PrecoUnitario > produto2.PrecoUnitario)
                {
                    Console.WriteLine($"Produto mais caro: {produto1.Nome} - Preço: {produto1.PrecoUnitario}");
                }
                else if (produto2.PrecoUnitario > produto1.PrecoUnitario)
                {
                    Console.WriteLine($"Produto mais caro: {produto2.Nome} - Preço: {produto2.PrecoUnitario}");
                }
                else
                {
                    Console.WriteLine($"Os produtos têm o mesmo preço: {produto1.Nome} e {produto2.Nome} - Preço: {produto1.PrecoUnitario}");
                }
            }
        }
        catch (ProdutoInvalidoException ex)
        {
            Console.WriteLine($"Erro de produto: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
}