# Gerenciador de Produtos

## Resumo
Este é um aplicativo de console em C# (.NET 10.0) para gerenciamento simples de produtos. O programa permite cadastrar dois produtos com nome, preço unitário e quantidade, calcular o custo total, aplicar desconto se o custo ultrapassar R$ 5.000,00 e comparar qual produto é mais caro.

## Métodos Utilizados
- **Programação Orientada a Objetos (POO)**: Classe `Produto` com propriedades (`Nome`, `PrecoUnitario`), métodos `calcularPrecoTotal(int quantidade)` e `calcularCustoFinal(double custoTotal, int quantidade, int desconto)`.
- **Tratamento de Exceções**: Exceção personalizada `ProdutoInvalidoException` para entradas inválidas (preço, quantidade, desconto).
- **Entrada/Saída no Console**: Leitura via `Console.ReadLine()` com validação `TryParse`.
- **Lógica de Negócio**: Cálculo de custos, desconto condicional e comparação de preços.

## Como Rodar
1. Abra o terminal na pasta do projeto: `GerenciadorDeProdutos`.
2. Execute: `dotnet run`.
3. Siga as instruções no console para inserir dados dos produtos.

## Autor
Tiago Guedes

