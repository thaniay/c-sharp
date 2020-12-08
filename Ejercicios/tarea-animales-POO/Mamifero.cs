using System;
public abstract class Mamifero: Animal 
{
    public int CuantasPatas { get; set; }
   

    public void Caminar()
    {
        Console.WriteLine("Caminando..."); 
    }
}