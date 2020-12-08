using System;

public class Pato: Aves
{
        public string Alimentacion { get; set; }
        public string Pico { get; set; }
        public string Genero { get; set; }

        public void Graznido()
        {
            Console.WriteLine("cuack cuack cuack");
        }
}