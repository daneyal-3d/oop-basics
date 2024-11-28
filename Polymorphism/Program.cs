using System;

class Animal {
    public virtual void MakeSound() {
        Console.WriteLine("Some generic animal sound.");
    }
}

class Dog : Animal {
    public override void MakeSound() {
        Console.WriteLine("Bark!");
    }
}

class Program {
    static void Main() {
        Dog jerry = new Dog();
        jerry.MakeSound();
    }
}