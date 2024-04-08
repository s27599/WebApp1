namespace WebApplication1.Models;

public class Animal
{
    public int Id { get; set; }
    public string Imie { get; set; }
    public Categories Category { get; set; }
    public double Mass { get; set; }
    public string Color { get; set; }

    public Animal(int id, string imie, Categories category, double mass, string color)
    {
        Id = id;
        Imie = imie;
        Category = category;
        Mass = mass;
        Color = color;
    }


   
}