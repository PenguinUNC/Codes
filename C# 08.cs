using System;
class Car
{
    public string model;
    public double speed;
}
class Hero
{
    public string name;
    public double hp;
}
class Cat
{
    public string CatName;
    public bool isHungry = true;
    public void Eat()
    {
        isHungry = false;
        Console.WriteLine(CatName + " not hungry");
    }
}
class Father
{
    public string namme;
    public bool hasSlipper = true;
    public void Attack()
    {
        hasSlipper = false;
        Console.WriteLine(namme + " find");
    }
}
class Weapon
{
    public string title;
    public double damage;
}
class Program
{
    static void Main()
    {
        Car First = new Car();
        First.model = "Tesla";
        First.speed = 250;
        Hero Second = new Hero();
        Second.name = "Player";
        Second.hp = 100;
        Cat Third = new Cat();
        Third.CatName = "Barsik";
        Third.isHungry = false;
        Father Four = new Father();
        Four.namme = "Bogdan";
        Four.hasSlipper = true;
        Weapon Five = new Weapon();
        Five.title = "GUN3000";
        Five.damage = 10000000000;
        Console.WriteLine(First.model + ", " + First.speed);
        Console.WriteLine(Second.name + ", " + Second.hp);
        Console.WriteLine(Third.CatName + " Hunhry? " + Third.isHungry);
        Third.Eat();
        Console.WriteLine(Third.CatName + " Hunhry? " + Third.isHungry);
        Four.Attack();
        Four.hasSlipper = true;
        Four.Attack();
        Console.WriteLine(Five.title + ", " + Five.damage);
    }
}
