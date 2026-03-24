class Program
{
    static void Main(string[] args)
    {
        try
        {
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

                Produto produto = new Produto(nomeProduto, precoUnitario);

                double custoTotal = produto.calcularPrecoTotal(quantidade);

                int desconto = 0;
                if (custoTotal > 5000.00)
                {
                    Console.WriteLine("Digite o desconto:");
                    if (!int.TryParse(Console.ReadLine(), out desconto))
                    {
                        throw new ProdutoInvalidoException("Desconto inválido.");
                    }
                }

                    if (contador == 0)
                        produto1 = produto;
                    else
                        produto2 = produto;

                    Console.WriteLine(produto);

                    Console.WriteLine($"Custo total: {custoTotal}");
                    Console.WriteLine($"Custo final: {produto.calcularCustoFinal(custoTotal, quantidade, desconto)}");
                    Console.WriteLine($"Desconto: {desconto}%");
                    Console.WriteLine($"Quantidade: {quantidade}");

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
                        Console.WriteLine($"Os produtos tem o mesmo preço: {produto1.Nome} e {produto2.Nome} - Preço: {produto1.PrecoUnitario}");
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

