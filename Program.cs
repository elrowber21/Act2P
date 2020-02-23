using System;

namespace Peliculas
{   
    
    class Peliculas
    { 
    public string Titulo, Pais, Director;
    public int Año;

    public void Imprimir()
    {
        Console.WriteLine(Titulo+" "+Año+" "+Pais+" "+Director);
    }

    }
    class Program
    {
        static void Main(string[] args)
        {
           Peliculas Pelicula1= new Peliculas();
           Peliculas Pelicula2= new Peliculas();

           Pelicula1.Titulo="Spider-Man 2";
           Pelicula2.Titulo="Joker";
           Pelicula1.Año=2004;
           Pelicula2.Año=2019;
           Pelicula1.Pais="USA";
           Pelicula2.Pais="USA";
           Pelicula1.Director="Sam Raimi";
           Pelicula2.Director="Todd Phillips";

           Pelicula1.Imprimir();
           Pelicula2.Imprimir();
        }
    }
}