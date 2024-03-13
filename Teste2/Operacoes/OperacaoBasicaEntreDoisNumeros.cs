namespace Teste2;

public abstract class OperacaoBasicaEntreDoisNumeros : IOperacaoBasicaEntreDoisNumeros
{
    protected double resultado;
    
    public virtual double Executar(double a, double b)
    {
        return a + b;
    }
}