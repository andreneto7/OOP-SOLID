namespace Teste2;

public class OperacaoRaizQuadrada: IOperacaoRaizQuadrada
{
    public double ExecutarRaizQuadrada(int valor)
    {
        return Math.Sqrt(valor);
    }
}