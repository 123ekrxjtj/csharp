using System;
class Man
{
    public static string name;
    public int age;
    public float weight;
}
public class Person
{
    public static void Main()
    {
        Man m1 = new Man();
        Man.name = "KBS";
        m1.age = 222;
        m1.weight = 55.5F;
        Console.WriteLine(" {0}, {1}, {2}", Man.name, m1.age, m1.weight);
    }
}