using System;

public abstract class Aves: Animal // Herencia
{
    public int CuantasPatas { get; set; }
 

    public void Volar() // Abastraccion
    {
        Console.WriteLine("Volando...");
    }
}