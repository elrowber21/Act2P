using System;

namespace Peliculas
{   
    
    class Peliculas
    { 
    public string Titulo, Pais, Director;
    public int Año;
    }
    class Program
    {
        static void Main(string[] args)
        {
           Peliculas Pelicula1= new Peliculas();
           Peliculas Pelicula2= new Peliculas();

           Pelicula1.Titulo= "Spider-Man 2";
           Pelicula2.Titulo="Joker";
           Pelicula1.Año=2004;
           Pelicula2.Año=2019;
           Pelicula1.Pais="USA";
           Pelicula2.Pais="USA";
           Pelicula1.Director="Saim Raimi";
           Pelicula2.Director="Todd Phillips";

           Console.WriteLine(Pelicula1.Titulo);
           Console.WriteLine(Pelicula1.Año);
           Console.WriteLine(Pelicula2.Titulo);
           Console.WriteLine(Pelicula2.Año);
           
        }
    }
}