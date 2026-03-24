class Produto
{
    private string nome;
    private double precoUnitario;
    private string descricao;

    public Produto(string nome, double precoUnitario, string descricao)
    {
        this.nome = nome;
        this.precoUnitario = precoUnitario;
        this.descricao = descricao;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double calcularPrecoTotal(int quantidade)
    {
        double custoTotal = precoUnitario * quantidade;
        return custoTotal;
    }

    public double calcularCustoFinal(int quantidade, double desconto)
    {
        double custoTotal = calcularPrecoTotal(quantidade);
        double custoFinal = custoTotal - (custoTotal * (desconto/100));
        return custoFinal;
    }

    
    public override string ToString()
    {
        return $"Produto: {nome},\nPreço Unitário: {precoUnitario}, \nDescrição: {descricao}";
    }
}