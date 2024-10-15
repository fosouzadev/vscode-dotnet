using System;

namespace LibraryProject;

public interface ICalculadora
{
    decimal Somar(params decimal[] values);
    decimal Subtrair(params decimal[] values);
}
