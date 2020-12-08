using System;
public class Gato: Mamifero // Herencia
{
    public string Pelaje { get; set; }
    public string Raza { get; set; }
    public bool EsArisco { get; set; }

    public Gato() // Polimorfismo
    {
        EsArisco = true;
    }
    public Gato (bool esArisco) // Polimorfismo
    {
        EsArisco = esArisco;
    }
    public void Maullar()
    {
        Console.WriteLine("Miau miau miau");

    }

}