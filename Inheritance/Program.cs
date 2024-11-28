using System;

class Animal {
    public void Eat() {
        Console.WriteLine("This animal eats food.");
    }
}

class Dog : Animal {
    public void Bark() {
        Console.WriteLine("The dog barks.");
    }
}

class Program {
    static void Main() {
        Dog dog = new Dog();
        dog.Eat(); // From Parent
        dog.Bark(); // From Child
    }
}