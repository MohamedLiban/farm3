using System;
using System.Collections.Generic;

class Crop
{
    public string Animal { get; set; }
    public int Quantity { get; set; }
    public string Location { get; set; }

    public Crop(string name, int quantity, string location)
    {
        Animal = name;
        Quantity = quantity;
        Location = location;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{Animal}: {Quantity} units, Location: {Location}");
    }
}

class Animal
{
    public string AnimalName { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }

    public Animal(string animalName, string species, int age)
    {
        AnimalName = animalName;
        Species = species;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{AnimalName}: {Species}, Age: {Age}");
    }
}

class Farm
{
    private List<Crop> crops = new List<Crop>();
    private List<Animal> animals = new List<Animal>();

    public void AddCrop(Crop crop)
    {
        crops.Add(crop);
    }

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void RemoveCrop(string cropName)
    {
        crops.RemoveAll(crop => crop.Animal == cropName);
    }

    public void RemoveAnimal(string animalName)
    {
        animals.RemoveAll(animal => animal.AnimalName == animalName);
    }

    public void DisplayAllCrops()
    {
        foreach (var crop in crops)
        {
            crop.DisplayInfo();
        }
    }

    public void DisplayAllAnimals()
    {
        foreach (var animal in animals)
        {
            animal.DisplayInfo();
        }
    }
}

class Program
{
    static void Main()
    {
        Farm farm = new Farm();

        Crop crop1 = new Crop("Wheat", 100, "Field 2");
        Crop crop2 = new Crop("Corn", 100, "Field 2");

        Animal animal1 = new Animal("Bessie", "Cow", 2);
        Animal animal2 = new Animal("Charlie", "Pig", 8);

        farm.AddCrop(crop1);
        farm.AddCrop(crop2);
        farm.AddAnimal(animal1);
        farm.AddAnimal(animal2);

        Console.WriteLine("All Crops:");
        farm.DisplayAllCrops();

        Console.WriteLine("\nAll Animals:");
        farm.DisplayAllAnimals();

        farm.RemoveCrop("Wheat");
        farm.RemoveAnimal("Charlie");

        Console.WriteLine("\nAfter Removal:");
        Console.WriteLine("All Crops:");
        farm.DisplayAllCrops();
        Console.WriteLine("\nAll Animals:");
        farm.DisplayAllAnimals();
    }
}