using System;

namespace Peliculas
{   
    
    class Peliculas
    { 
    private string Titulo, Pais, Director;
    private int Año;

    public string getTitulo()
    {
        return Titulo;
    }
    public void setTitulo(string t)
    {
        Titulo=t;
    }
    public string getPais()
    {
        return Pais;
    }
    public void setPais(string p)
    {
        Pais=p;
    }
    public string getDirector()
    {
        return Director;
    }
    public void setDirector(string d){
        Director=d;
    }
    public int getAño()
    {
    return Año;
    }
    public void setAño(int a)
    {
    Año=a;
    }

    }
    class Program
    {
        static void Main(string[] args)
        {
           Peliculas Pelicula1= new Peliculas();
           Peliculas Pelicula2= new Peliculas();

           Pelicula1.setTitulo("Spider-Man 2");
           Pelicula2.setTitulo("Joker");
           Pelicula1.setAño(2004);
           Pelicula2.setAño(2019);
           Pelicula1.setPais("USA");
           Pelicula2.setPais("USA");
           Pelicula1.setDirector("Sam Raimi");
           Pelicula2.setDirector("Todd Phillips");

            
           Console.WriteLine(Pelicula1.getTitulo());
           Console.WriteLine(Pelicula1.getAño());
           Console.WriteLine(Pelicula1.getDirector());
           Console.WriteLine(Pelicula1.getPais());
           Console.WriteLine(Pelicula2.getTitulo());
           Console.WriteLine(Pelicula2.getAño());
           Console.WriteLine(Pelicula2.getDirector());
           Console.WriteLine(Pelicula2.getPais());
           
        }
    }
}