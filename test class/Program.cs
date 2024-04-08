



public class Animal
{
    public string name; public int age;
    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    //public string Name
    //{
    //    get; set;
    //}
    public void DisplayInfo() { Console.WriteLine($"Name:{name}{age}"); }

    
}
class program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal("lion", 20);

        Console.WriteLine(animal.name);
        animal.name = "cheetah";
        Console.WriteLine(animal.name);
    }
}
//public class Animal
//{
//    private string name; // Field to store the name

//    // Constructor to initialize the name field
//    public Animal(string name, int age)
//    {
//        this.name = name;
//        Age = age; // Using the property Age to set the age value
//    }

//    // Property to get and set the name using the name field
//    public string Name
//    {
//        get { return name; } // Getter to retrieve the name
//        set { name = value; } // Setter to assign a new name
//    }

//    public int Age { get; set; } // Auto-implemented property for age

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Name: {Name}, Age: {Age}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Animal animal = new Animal("lion", 20);

//        Console.WriteLine(animal.Name); // Output: lion
//        animal.Name = "tiger"; // Set a new name using the property

//        animal.DisplayInfo(); // Output: Name: tiger, Age: 20
//    }
//}
