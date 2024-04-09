



//public class Animal
//{
//    public string name; public int age;
//    public Animal(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }
//    //public string Name
//    //{
//    //    get; set;
//    //}
//    public void DisplayInfo() { Console.WriteLine($"Name:{name}{age}"); }


//}
//class program
//{
//    static void Main(string[] args)
//    {
//        Animal animal = new Animal("lion", 20);

//        Console.WriteLine(animal.name);
//        animal.name = "cheetah";
//        Console.WriteLine(animal.name);
//    }
//}
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

//class Animal
//{
//    public string name;
//    public int age;
//    public Animal(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }
//    //public string Name { get; set; }
//    public void changeToLower()
//    {
//        Console.WriteLine(this.name.ToUpper());

//    }

//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Animal animal = new Animal("cat",10);
//        Console.WriteLine(animal.name);
//        animal.changeToLower();
//        Console.WriteLine("{0}asdf", animal.name);
//        int num1 = 20;
//        int num2 = 30;
//        Console.WriteLine(num1+num2);
//    }


//}
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter a number to check if it's prime: ");
//        string input = Console.ReadLine();

//        if (int.TryParse(input, out int number))
//        {
//            if (IsPrime(number))
//            {
//                Console.WriteLine($"{number} is a prime number.");
//            }
//            else
//            {
//                Console.WriteLine($"{number} is not a prime number.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. Please enter a valid integer.");
//        }
//    }

//    // Function to check if a number is prime
//    static bool IsPrime(int num)
//    {
//        // A prime number is a number greater than 1 with no positive divisors other than 1 and itself
//        if (num <= 1)
//        {
//            return false;
//        }

//        // Check for divisors from 2 to sqrt(num)
//        for (int i = 2; i * i <= num; i++)
//        {
//            if (num % i == 0)
//            {
//                return false; // Found a divisor, not a prime number
//            }
//        }

//        return true; // No divisors found, it's a prime number
//    }
//}
//using myFirstProject;
//using System;
//namespace myFirstProject
//{
//    public class Animal
//    {
//        public string colorr;
//        public  virtual void MakeSound()
//        {
//            Console.WriteLine("all animal can make sound");
//        }
//    }
//    public class Lion : Animal { 
//        public virtual void MakeSound()
//        {
//            Console.WriteLine("lion can make grrr");
//        }
//    }
//    public class Dog:Animal{
//        public override void MakeSound()
//        {
//            Console.WriteLine("dog make Bow Bow");
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Animal lion=new Lion();
//        lion.MakeSound();
//        Animal dog= new Dog();
//        dog.MakeSound();

//    }
//}
//using System;
//namespace myFirstProject
//{
//    public abstract class Animal
//    {
//        public abstract void MakeSound();
//    }
//    public class Lion : Animal
//    {
//        public override void MakeSound()
//        {
//            Console.WriteLine("lion can Roar");
//        }
//    }
//}
class Animal
{
    public string name;
    public int age;
    
    public void Speak(string name,int age)
    {
        Console.WriteLine($"{name}can make sound,and age is {age}");
    }

}
class Dog : Animal
{
    public string breed;
   
}
class Cat : Animal
{
   
    public void Meaw() { Console.WriteLine("Meaw"); }
}
class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Speak("Dog",12);
        dog.breed = "gggg";
        Console.WriteLine(dog.breed);
        Cat cat=new Cat();cat.Meaw();
        cat.Speak("cat",2);


    }

}