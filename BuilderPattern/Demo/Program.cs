using Stroitel;
var dog = new Dog.DogBuilder()
    .WithName("Buddy")
    .WithBreed("Labrador")
    .WithAge(5)
    .WithToys(new List<string> { "Ball", "Frisbee", "Chew Toy" })
    .Build();
Console.WriteLine($"Name: {dog.Name}");
Console.WriteLine($"Breed: {dog.Breed}");
Console.WriteLine($"Age: {dog.Age}");
Console.WriteLine("Toys:");
foreach (var toy in dog.Toys)
{
    Console.WriteLine(toy);
}
dog.ChangeName("Max");
dog.ChangeBreed("West");
dog.ChangeAge(2);
dog.AddToy("Bublik");
dog.RemoveToy("Frisbee");
Console.WriteLine();
Console.WriteLine("После изменений");

Console.WriteLine($"Name: {dog.Name}");
Console.WriteLine($"Breed: {dog.Breed}");
Console.WriteLine($"Age: {dog.Age}");
Console.WriteLine("Toys:");
foreach (var toy in dog.Toys)
{
    Console.WriteLine(toy);
}