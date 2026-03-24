using System;

public class ProdutoInvalidoException : Exception
{
    public ProdutoInvalidoException(string message) : base(message)
    {
    }
}