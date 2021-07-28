namespace CompositionSample2
{
    public class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Eat(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Sleep(string message)
        {
            System.Console.WriteLine(message);

        }

    }
}
