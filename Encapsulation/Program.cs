using System;

class Car {
    private int speed;

    public void SetSpeed(int s = 50) {
        if (s > 0) speed = s; 
        else Console.WriteLine("Speed must be positive!");
    }

    public int GetSpeed() {
        return speed;
    }
}

class Program {
    static void Main() {
        Car car = new Car();
        car.SetSpeed(-100); 
        Console.WriteLine("Car Speed is: " + car.GetSpeed() + " km/h");
    }
}