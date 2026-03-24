class Produto
{
    private string nome;
    private double precoUnitario;

    public Produto(string nome, double precoUnitario)
    {
        this.nome = nome;
        this.precoUnitario = precoUnitario;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    
    public double PrecoUnitario
    {
        get { return precoUnitario; }
        set { precoUnitario = value; }
    }

    public double calcularPrecoTotal(int quantidade)
    {
        double custoTotal = precoUnitario * quantidade;
        return custoTotal;
    }

    public double calcularCustoFinal(int quantidade, int desconto)
    {
        double custoTotal = calcularPrecoTotal(quantidade);
        double custoFinal = custoTotal - (custoTotal * (desconto / 100.0));
        return custoFinal;
    }

    
    public override string ToString()
    {
        return $"Produto: {nome},\nPreço Unitário: {precoUnitario}";
    }
}