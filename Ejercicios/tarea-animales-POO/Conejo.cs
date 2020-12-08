using System;

public class Conejo: Mamifero // Herencia
{

   public string Raza { get; set; }
   public bool EsDomestico { get; set; }

    public Conejo() // Polimorfismo
    {
        EsDomestico = true;
    }

    public Conejo(bool esDomestico) // Polimorfismo
    {
        EsDomestico = esDomestico;
    }


   
}
