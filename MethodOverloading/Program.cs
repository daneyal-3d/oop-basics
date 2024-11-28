using System;

class Calculator {
    public int Add(int a, int b) {
        return a + b;
    }

    public double Add(double a, double b) {
        return a + b;
    }

    public string Add(string a, string b) {
        return a + b;
    }
}

class Program {
    static void Main() {
        Calculator calc = new Calculator();
        
        Console.WriteLine("Enter 1st number: ");
        var num1 = Console.ReadLine(); 
        Console.WriteLine("Enter 2nd number: ");
        var num2 = Console.ReadLine();

        if (string.IsNullOrEmpty(num1) || string.IsNullOrEmpty(num2))
        {
            Console.WriteLine("You must enter both numbers.");
        }
        else
        {
            Console.WriteLine(calc.Add(2, 3));        // Output: 5
            Console.WriteLine(calc.Add(2.5, 3.2));    // Output: 5.7
            Console.WriteLine(calc.Add("Hello, ", "World!")); // Output: Hello, World!
            
            // Console.WriteLine(calc.Add(num1, num2));
        }
        
        
    }
}