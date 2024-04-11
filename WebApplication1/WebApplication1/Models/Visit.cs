namespace WebApplication1.Models;

public class Visit
{
    public DateTime Date { get; set; }
    public Animal Animal { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    
   
    public Visit(DateTime date, Animal animal, string description, double price)
    {
        Date = date;
        Animal = animal;
        Description = description;
        Price = price;
    }
   
}