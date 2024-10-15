namespace LibraryProject;

public class Calculadora : ICalculadora
{
    public decimal Somar(params decimal[] values) =>
        values.Sum();

    public decimal Subtrair(params decimal[] values) =>
        values.Aggregate((a, b) => a - b);
}
