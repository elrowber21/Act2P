using System;

namespace Peliculas
{   
    
    class Pelicula
    { 
    public string Titulo, Pais, Director;
    public int Año;
    
    public Pelicula( string Titulo, string Año, string Director, int Año)
    {
        this.Titulo=Titulo;
        this.Pais=Pais;
        this.Director=Director;
        this.Año=Año;
    }

public Pelicula()
{

}

    public void Imprimir()
    {
        Console.WriteLine("{0}({1}, {2}, {3})", this.Titulo, this.Director, this.Pais, this.Año);
    }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
           Pelicula Pelicula1= new Pelicula("Spider-Man 2",2004, "USA", "Sam Raimi" );
           Pelicula Pelicula2= new Pelicula("Joker", 2019, "USA", "Todd Phillips");

           Pelicula1.Imprimir();
           Pelicula2.Imprimir();
        }
    }
}