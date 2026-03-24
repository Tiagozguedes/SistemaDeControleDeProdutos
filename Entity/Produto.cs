using System.Security.AccessControl;

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

    public double calcularCustoFinal(double custoTotal,int quantidade, int desconto)
    {
        double custoFinal = 0.0;
        if (custoTotal > 5000.00)
        {
           return custoFinal = custoTotal - (custoTotal * (desconto / 100.0));
        }
        else
        {
            return custoTotal;
        }
        
    }

    
    public override string ToString()
    {
        return $"Produto: {nome},\nPreço Unitário: {precoUnitario},";
    }
}