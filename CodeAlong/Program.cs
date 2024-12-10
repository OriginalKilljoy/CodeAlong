// Skriv et program som lar brukeren opprette og lagre informasjon om dyr.
// Programmet skal be brukeren om å skrive inn navn, art og alder for et dyr og deretter lagre denne informasjonen. 
// Senere skal programmet kunne skrive ut informasjonen om dyrene i konsollen. 
// Brukeren skal da kunne velge “Vis alle” eller “Søk på art”.
// Søk skal ta vare på brukerens input og så vise de dyrene av arten brukeren etterspør. 
// Om ingen har denne arten skal dette også gis beskjed om i console. 

using System.Runtime.InteropServices.Marshalling;
using CodeAlong;

List<Animal> animals = new List<Animal>();
Animal animal1 = new Animal("Gunnar", "Ku", 12);
Animal animal2 = new Animal("Petrine","Hest", 7);

animals.Add(animal1);
animals.Add(animal2);

Console.WriteLine("Hei og velkommen!");

bool isChoosing = true;
while (isChoosing)
{
    Console.WriteLine("\nVelg ett alternativ:\n[1]Vis alle dyr\n[2]Søk etter et dyr\n[3]Legg til et dyr");
    var userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            ShowAnimals();
            break;
        case "2":
            SearchForAnimals();
            break;
        case "3":
            AddAnimal();
            break;
    }
}

void AddAnimal()
{
    Animal newAnimal = new Animal(name: "", type: "", age: 0);
    newAnimal.ReadAllAnimalInfo();
    animals.Add(newAnimal);
    Console.WriteLine($"Du la til: {newAnimal.Name}");
}

void ShowAnimals()
{
    foreach (var animal in animals)
    {
        animal.PrintInfo();
    }
}

void SearchForAnimals()
{
    var userInput = Console.ReadLine();

    foreach (var animal in animals)
    {
        if (userInput == animal.Type)
        {
            animal.PrintInfo();
        }
    }
}