using System;

namespace CompositionSample2
{

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new Animal(), new Walkable(),new Swimmable(), new Talkable());
            var goldfish = new Goldfish(new Animal(),new Swimmable());

            Console.WriteLine("Person: ");
            person.Can();
            Console.WriteLine();
            Console.WriteLine("Fish: ");
            goldfish.Can();



        }
    }
}
