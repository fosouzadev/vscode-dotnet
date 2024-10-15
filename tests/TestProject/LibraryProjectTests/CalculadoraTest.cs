using System;
using LibraryProject;

namespace TestProject.LibraryProjectTests;

public class CalculadoraTest
{
    private readonly ICalculadora _calculadora = new Calculadora();

    [Fact]
    public void Somar_SomaDeNumerosPositivos_RetornaResultado()
    {
        // Arrange
        decimal[] valores = [ 1, 3, 5, 7, 9 ];

        // Act
        decimal resultado = _calculadora.Somar(valores);

        // Assert
        Assert.Equal(valores.Sum(), resultado);
    }

    [Fact]
    public void Somar_SomaDeNumerosNegativos_RetornaResultado()
    {
        // Arrange
        decimal[] valores = [ -1, -3, -5, -7, -9 ];

        // Act
        decimal resultado = _calculadora.Somar(valores);

        // Assert
        Assert.Equal(valores.Sum(), resultado);
    }
}
