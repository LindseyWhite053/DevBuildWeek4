Dog first = new Dog() { Name = "Fido", HairColor = "Black", LegCount = 4, BarkVolume = 8 };
Dog second = new Dog() { Name = "Nellie", HairColor = "Yellow", LegCount = 4, BarkVolume = 5 };
Orangutan third = new Orangutan() { Name = "Fred", HairColor = "Orange", LegCount = 2, ThumbLength = 3 };

List<Mammal> pets = new List<Mammal>();
pets.Add(first);
pets.Add(second);
pets.Add(third);

foreach (Mammal pet in pets)
{
    string info = pet.ToString();
    Console.WriteLine(pet);
}

class Mammal
{
    public string Name;
    public string HairColor;
    public int LegCount;
    
    public void Walk()
    {
        Console.WriteLine("I am walking");
    }

    // We are overriding what's called a "virtual" function. 
    // i.s. a "virtual" function is one that you can override. 
    public override string ToString()
    {
        return "This is a mammal";
    }
}

//parent class listed after the derived class separated by colon
class Dog : Mammal
{
    public int BarkVolume;

    public override string ToString()
    {
        return $"Dog named {Name}, hair {HairColor}, {LegCount} legs, barks at volume {BarkVolume}";
    }

}

class Orangutan : Mammal
{
    public int ThumbLength;

    public override string ToString()
    {
        return $"Orangutan named {Name}, hair {HairColor}, {LegCount} legs, thumb is {ThumbLength} inches";
    }

}