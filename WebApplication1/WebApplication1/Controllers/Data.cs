using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class Data
{
    private static List<Animal> _animals = new()
    {
        new Animal(1, "John", Categories.Cat, 333.1, "blue"),
        new Animal(2, "jake", Categories.Dog, 123.3, "red"),
        new Animal(3, "Lola", Categories.Parrot, 15.3, "gray"),
        new Animal(4, "Tom", Categories.Hamster, 9.3, "brown")
        
    };

    private static List<Visit> _visits = new()
    {
        new Visit(new DateTime(2024, 4, 12), _animals.FirstOrDefault(an => an.Id == 1), "Accident", 12.5),
        new Visit(new DateTime(2024, 4, 12), _animals.FirstOrDefault(an => an.Id == 2), "Vaccine", 14.5),
        new Visit(new DateTime(2024, 4, 12), _animals.FirstOrDefault(an => an.Id == 3), "Diarrhea", 19.5),
    };
    
    public static List<Visit> GetVisits()
    {
        return _visits;
    }
    
    public static List<Animal> GetAnimals()
    {
        return _animals;
    }
    
}