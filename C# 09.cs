using System;
class Entity
{
    public int scpid;
    public string name;
    public char dangerous;
    public Entity(int a, string n, char d)
    {
        scpid = a;
        name = n;
        dangerous = d;
    }
}
class Programm
{
    static void Main()
    {
        Entity One = new Entity(096, "Shy guy", 'B');
        Entity Two = new Entity(682, "Reptilia", 'A');
        Entity Three = new Entity(173, "Sculpture", 'B');
        Console.WriteLine(One.scpid + " " + One.name + " " + One.dangerous);
        Console.WriteLine(Two.scpid + " " + Two.name + " " + Two.dangerous);
        Console.Write(Three.scpid + " " + Three.name + " " + Three.dangerous);
    }
}
