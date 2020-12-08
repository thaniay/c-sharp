using System;

namespace _tarea_animales_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("***** MAMIFEROS *****");
            Console.WriteLine();

            Perro p = new Perro();
            Console.WriteLine("|Perro|");
            Console.WriteLine("-------");
            p.Nombre = "Tierra";
            p.CuantasPatas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Orden = "Carnivora";
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine("Nombre: " + p.Nombre);
            Console.WriteLine("Cuantas Patas: " + p.CuantasPatas);
            if (p.EsDomestico == true)
            {
                Console.WriteLine("Es domestico");
            }

            Console.WriteLine();

            Gato g = new Gato();
            Console.WriteLine("|Gato|");
            Console.WriteLine("------");
            g.Nombre = "Amarillo";
            g.CuantasPatas = 4;
            g.Pelaje = "Pelo Corto";
            g.Raza = "Persa ";
            g.Orden = "Carnivora";
            g.Comer();
            g.Caminar();
            g.Maullar();
            g.EsArisco = true;

            Console.WriteLine("Nombre: " + g.Nombre);
            Console.WriteLine("Cuantas Patas: " + g.CuantasPatas);
            Console.WriteLine("Tipo de pelaje: " + g.Pelaje);
            Console.WriteLine("Raza: " + g.Raza);

            Console.WriteLine();

            Conejo n = new Conejo();
            Console.WriteLine("|Conejo|");
            Console.WriteLine("--------");
            n.Nombre = "Teylor";
            n.CuantasPatas = 4;
            g.Raza = "Gigante";
            n.Orden = "Lagomorpha";
            n.Comer();
            n.Caminar();

            Console.WriteLine("Nombre: " + n.Nombre);
            Console.WriteLine("Cuantas Patas: " + n.CuantasPatas);
            Console.WriteLine("Orden: " + n.Orden);
            Console.WriteLine("Raza: " + g.Raza);
            if (p.EsDomestico == true)
            {
                Console.WriteLine("Es domestico");
            }

            Console.WriteLine();

            Console.WriteLine("***** AVES *****");

            Console.WriteLine();

            Pato c = new Pato();
            Console.WriteLine("|Pato|");
            Console.WriteLine("---------");
            c.Nombre = "Gorgoyon";
            c.CuantasPatas = 2;
            c.Pico = "Ancho y corto que suele ser aplanado";
            c.Genero = "Anas";
            c.Orden = "Anseriformes";
            c.Alimentacion = "se alimentan de plantas, insectos, semillas, algas o peces.";
            c.Comer();
            c.Volar();
            c.Graznido();

            Console.WriteLine("Nombre: " + c.Nombre);
            Console.WriteLine("Cuantas patas: " + c.CuantasPatas);
            Console.WriteLine("Tipo de pico: " + c.Pico);
            Console.WriteLine("Tipo de genero: " + c.Genero);
            Console.WriteLine("Tipo de Orden: " + c.Orden);
            Console.WriteLine("Alimentacion: " + c.Alimentacion);

            Console.WriteLine();

            Loro pi = new Loro();
            Console.WriteLine("|Loro|");
            Console.WriteLine("----------");
            pi.Nombre = "Facundo";
            pi.CuantasPatas = 2;
            pi.Orden = "Psittaciformes";
            pi.Pico = "forma curvada";
            pi.Alimentacion = "Semillas, frutas y verduras.";
            pi.Comunicacion = "Imitan la voz humana y otros sonidos";
            pi.Comer();
            
            Console.WriteLine("Nombre: " + pi.Nombre);
            Console.WriteLine("Cuantas patas: " + pi.CuantasPatas);
            Console.WriteLine("Tipo de Orden: " + pi.Orden);
            Console.WriteLine("Alimentacion: " + pi.Alimentacion);
            Console.WriteLine("Comunicacion: " + pi.Comunicacion);

            Console.WriteLine();

            Console.WriteLine("***** PECES *****");
            Console.WriteLine();

            PezDorado pe = new PezDorado();
            Console.WriteLine("|Pez Dorado|");
            Console.WriteLine("------------");
            pe.Nombre = "Burbuja";
            pe.Aletas = 5;
            pe.Orden = "Cypriniformes";
            pe.Alimentacion = "Lombrices, plancton, larvas, algas marinas y pequeños huevos de otros peces...";
            pe.Nadar();

            Console.WriteLine("Nombre: " + pe.Nombre);
            Console.WriteLine("Cuantas aletas: " + pe.Aletas);
            Console.WriteLine("Tipo de Orden: " + pe.Orden);
            Console.WriteLine("Alimentacion: " + pe.Alimentacion);

            Console.WriteLine();

        }
    }
}
